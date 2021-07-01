/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/6/30
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private delegate void TaskResultRunable(bool result);
		/// <summary>
		/// 存储apks的目录
		/// </summary>
		private const string APKS_FILE_PAHT = "./apks";
		/// <summary>
		/// 记录当前的文件列表
		/// </summary>
		private Dictionary<string, string> _APKSFileList = new Dictionary<string, string>();
		
		private Timer _tickTimer;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitApplicationData();
			
			_tickTimer = new Timer();
			_tickTimer.Interval = 5000;
			_tickTimer.Tick += new EventHandler(OnTimerTick);
			_tickTimer.Start();
		}
		/// <summary>
		/// 初始化数据
		/// </summary>
		void InitApplicationData()
		{
			Const.LoadFromData();
			// 设置环境路径
			this.OnSetEnvironment();
			// 如果目录不存在则创建
			if(!Directory.Exists(APKS_FILE_PAHT))
			{
				Directory.CreateDirectory(APKS_FILE_PAHT);
			}
			OnRefreshListView();
		}
		
		void OnRefreshListView()
		{
			// 清理列表
			_ListAABView.Items.Clear();
			// 遍历目录，获取APKS文件
			foreach (string fullpath in Directory.GetFileSystemEntries(APKS_FILE_PAHT)) 
			{
				if(File.Exists(fullpath))
				{
					string base_name = Path.GetFileNameWithoutExtension(fullpath); // 获取文件名
					_APKSFileList.Add(base_name, fullpath);
					_ListAABView.Items.Add(string.Format("{0}-{1}", base_name, fullpath));
				}
			}
		}
		
		void OnAddAABFile(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "aab files (*.aab)|*.aab";
            dlg.RestoreDirectory = true;
			DialogResult result =  dlg.ShowDialog();
			if(result == DialogResult.OK)
			{
				if(string.IsNullOrEmpty(dlg.FileName))
				{
					return;
				}
				if(!File.Exists(dlg.FileName))
				{
					MessageBox.Show("AAB文件不存在", "错误", MessageBoxButtons.OK);
					return;
				}
				string base_name = Path.GetFileNameWithoutExtension(dlg.FileName); // 获取文件名
				if(_APKSFileList.ContainsKey(base_name))
				{
					MessageBox.Show("请勿重复添加", "错误", MessageBoxButtons.OK);
					return;
				}
				string output = Path.Combine(APKS_FILE_PAHT, base_name + ".apks");
				LoadingForm.ShowLoad("编译AAB文件中...");
				Task cmdTask = new Task();
				cmdTask.start(()=>{return CommandTools.BuildApks(dlg.FileName, output);});
				cmdTask.FinishEvent += (object res, EventArgs evt) => {
					this.Invoke(new TaskResultRunable((bool rst)=>{
                          LoadingForm.CloseLoad();
                          if(rst)
						  {
							_APKSFileList.Add(base_name, output);
							_ListAABView.Items.Add(string.Format("{0}-{1}", base_name, output));
							MessageBox.Show("AAB文件添加成功", "提示", MessageBoxButtons.OK);
							return;
						  }
						 MessageBox.Show("AAB文件添加失败", "错误", MessageBoxButtons.OK);
                          }), (bool)res);};
			}
		}
		/// <summary>
		/// 安装
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnInstallSelectAAB(object sender, EventArgs e)
		{
			var checkAABItem = _ListAABView.CheckedItems;
			if(checkAABItem == null || checkAABItem.Count <= 0)
			{
				MessageBox.Show("请选择安装的AAB包", "提示", MessageBoxButtons.OK);
				return;
			}
			string item_value = checkAABItem[0].ToString();
			string[] name_path = item_value.Split('-');
			if(name_path.Length <= 1)
			{
				MessageBox.Show("AAB包读取失败", "错误", MessageBoxButtons.OK);
				return;
			}
			if(!File.Exists(name_path[1]))
			{
				MessageBox.Show("选择安装的AAB包已被删除", "错误", MessageBoxButtons.OK);
				return;
			}
			string device = _deviceList.Text;
			if(string.IsNullOrWhiteSpace(device) || string.IsNullOrWhiteSpace(name_path[1]))
			{
				MessageBox.Show("设备不存在或AAB包错误", "错误", MessageBoxButtons.OK);
				return;
			}
			LoadingForm.ShowLoad("安装AAB文件中...");
			//这个写法我自己都不太明白
			// 1. start里面创建一个委托，让线程调用它，
			// 2. 线程结束时调用事件， 事件里面再执行委托
			Task cmdTask = new Task();
			cmdTask.start(() => { return CommandTools.InstallApks(name_path[1], device);});
			cmdTask.FinishEvent += (object res, EventArgs evt)=>{ this.Invoke(new TaskResultRunable(OnInstallApksResult), (bool)res);};
		}
		/// <summary>
		/// 安装成功回调
		/// </summary>
		/// <param name="result"></param>
		void OnInstallApksResult(bool result)
		{
			LoadingForm.CloseLoad();
			if(result)
			{
				MessageBox.Show("安装成功", "提示", MessageBoxButtons.OK);
			}else
			{
				MessageBox.Show("安装失败", "错误", MessageBoxButtons.OK);
			}
		}
		
		void OnOpenSettings(object sender, EventArgs e)
		{
			SettingForm dlg = new SettingForm();
			dlg.ShowDialog();
			// 设置环境路径
			this.OnSetEnvironment();
		}
		
		void OnRemoveSelectAAb(object sender, EventArgs e)
		{
	
		}
		/// <summary>
		/// 设置环境路径
		/// </summary>
		void OnSetEnvironment()
		{
			// 设置java路径
			if(!string.IsNullOrEmpty(Const.Instance.JAVA_SDK_PATH))
			{
				CommandTools.SetEnvironment("JAVA_HOME", Const.Instance.JAVA_SDK_PATH, true);
				CommandTools.SetEnvironment("PATH", @"%JAVA_HOME%\bin", false);
			}
			// 设置adb 的路径
			if(!string.IsNullOrEmpty(Const.Instance.ADB_PATH))
			{
				CommandTools.SetEnvironment("PATH", Const.Instance.ADB_PATH, false);
			}
		}
		/// <summary>
		/// 定时器-用于刷新设备列表
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		void OnTimerTick(object sender, EventArgs args)
		{
			string[] devices = null;
			Task cmdTask = new Task();
			cmdTask.start(() => { return CommandTools.GetDeivcesList(out devices);});
			cmdTask.FinishEvent += (object res, EventArgs evt)=>{ 
				this.Invoke(new TaskResultRunable(delegate(bool result){
				                                  	if(result)
				                                  	{
				                                  		_deviceList.Items.Clear();
														_deviceList.Items.AddRange(devices);
				                                  	}
		    }), (bool)res);};
			/*if(CommandTools.GetDeivcesList(out devices))
			{
				_deviceList.Items.Clear();
				_deviceList.Items.AddRange(devices);
			}*/
		}
		void OnItemChecked(object sender, ItemCheckEventArgs e)
		{
			foreach(int nIndex in _ListAABView.CheckedIndices)
			{
				if(nIndex!=e.Index)
					_ListAABView.SetItemCheckState(nIndex,CheckState.Unchecked);
			}
		}
	
	}
}
