/*
 * 用户： 覃贵锋
 * 日期: 2022/11/25
 * 时间: 10:54
 * 
 * 
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// Description of ProjectAAB.
	/// </summary>
	public partial class ProjectAAB : UserControl
	{
		private delegate void TaskResultRunable(bool result);
		/// <summary>
		/// 存储apks的目录
		/// </summary>
		private const string APKS_FILE_EXT = ".apks";
		/// <summary>
		/// 记录当前的文件列表
		/// </summary>
		private Dictionary<string, string> _APKSFileList = new Dictionary<string, string>();
		private ProjectItem _project = null;
		public ProjectAAB(ProjectItem item)
		{
			InitializeComponent();
			_project = item;
			ProjectNameLabel.Text = item.ProjectName;
		}
		
		void OnFrameLoad(object sender, EventArgs e)
		{
			OnRefreshListView();
		}
		/// <summary>
		/// 设置环境路径
		/// </summary>
		void OnSetEnvironment()
		{
			// 设置java路径
			if(!string.IsNullOrEmpty(_project.ProjectJDKPath))
			{
				CommandTools.SetEnvironment("JAVA_HOME", _project.ProjectJDKPath, true);
				CommandTools.SetEnvironment("PATH", @"%JAVA_HOME%\bin", false);
			}
			// 设置adb 的路径
			if(!string.IsNullOrEmpty(_project.ProjectADBPath))
			{
				CommandTools.SetEnvironment("PATH", _project.ProjectADBPath, false);
			}
		}
		
		void OnItemChecked(object sender, ItemCheckEventArgs e)
		{
			foreach(int nIndex in _ListAABView.CheckedIndices)
			{
				if(nIndex!=e.Index)
					_ListAABView.SetItemCheckState(nIndex,CheckState.Unchecked);
			}
		}
		
		void OnRemoveSelectAAb(object sender, EventArgs e)
		{
			
		}
		
		void OnRefreshListView()
		{
			// 清理列表
			_ListAABView.Items.Clear();
			if(!Directory.Exists(_project.ProjectAPKsPath))
			{
				Directory.CreateDirectory(_project.ProjectAPKsPath);
			}
			// 遍历目录，获取APKS文件
			foreach (string fullpath in Directory.GetFileSystemEntries(_project.ProjectAPKsPath)) 
			{
				if(File.Exists(fullpath) && fullpath.EndsWith(APKS_FILE_EXT, StringComparison.CurrentCultureIgnoreCase))
				{
					string base_name = Path.GetFileNameWithoutExtension(fullpath); // 获取文件名
					_APKSFileList.Add(base_name, fullpath);
					_ListAABView.Items.Add(base_name);
				}
			}
		}
		
		void OnAddAABFile(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "aab files (*.aab)|*.aab";
            dlg.RestoreDirectory = true;
            dlg.InitialDirectory = _project.ProjectAABPath;
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
				
				string output = Path.Combine(_project.ProjectAPKsPath, base_name + ".apks");
				LoadingForm.ShowLoad("编译AAB文件中...");
				Task cmdTask = new Task();
				// disable once ConvertToLambdaExpression
				cmdTask.start(()=>{return CommandTools.BuildApks(dlg.FileName, output, _project.ProjectKeystore, _project.KeySAlias, _project.KeySPassword);});
				cmdTask.FinishEvent += (object res, EventArgs evt) => {
					// disable once ConvertToLambdaExpression
					this.Invoke(new TaskResultRunable((bool rst)=>{
                          LoadingForm.CloseLoad();
                          if(rst)
						  {
							_APKSFileList.Add(base_name, output);
							_ListAABView.Items.Add(base_name);
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
			string name_path = _APKSFileList[item_value];
			if(!File.Exists(name_path))
			{
				MessageBox.Show("选择安装的AAB包已被删除", "错误", MessageBoxButtons.OK);
				return;
			}
			// 这样写除了懒，就是懒
			string device = MainForm.Instance.GetDeviceName();
			if(string.IsNullOrWhiteSpace(device) || string.IsNullOrWhiteSpace(name_path))
			{
				MessageBox.Show("设备不存在或AAB包错误", "错误", MessageBoxButtons.OK);
				return;
			}
			LoadingForm.ShowLoad("安装AAB文件中...");
			//这个写法我自己都不太明白
			// 1. start里面创建一个委托，让线程调用它，
			// 2. 线程结束时调用事件， 事件里面再执行委托
			Task cmdTask = new Task();
			// disable once ConvertToLambdaExpression
			cmdTask.start(() => { return CommandTools.InstallApks(name_path, device);});
			// disable once ConvertToLambdaExpression
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
		/// <summary>
		/// 修改项目配置
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnProjectSetting(object sender, EventArgs e)
		{
			SettingForm dlg = new SettingForm(_project);
			dlg.ShowDialog();
		}
		/// <summary>
		/// 右键选中安装
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnSelectInstallEvt(object sender, EventArgs e)
		{
			var checkAABItem = _ListAABView.SelectedItems;
			if(checkAABItem == null || checkAABItem.Count < 1)
			{
				MessageBox.Show("请选择安装的AAB包", "提示", MessageBoxButtons.OK);
				return;
			}
			string item_value = checkAABItem[0].ToString();
			string name_path = _APKSFileList[item_value];
			if(!File.Exists(name_path))
			{
				MessageBox.Show("选择安装的AAB包已被删除", "错误", MessageBoxButtons.OK);
				return;
			}
			// 这样写除了懒，就是懒
			string device = MainForm.Instance.GetDeviceName();
			if(string.IsNullOrWhiteSpace(device) || string.IsNullOrWhiteSpace(name_path))
			{
				MessageBox.Show("设备不存在或AAB包错误", "错误", MessageBoxButtons.OK);
				return;
			}
			LoadingForm.ShowLoad("安装AAB文件中...");
			//这个写法我自己都不太明白
			// 1. start里面创建一个委托，让线程调用它，
			// 2. 线程结束时调用事件， 事件里面再执行委托
			Task cmdTask = new Task();
			// disable once ConvertToLambdaExpression
			cmdTask.start(() => { return CommandTools.InstallApks(name_path, device);});
			// disable once ConvertToLambdaExpression
			cmdTask.FinishEvent += (object res, EventArgs evt)=>{ this.Invoke(new TaskResultRunable(OnInstallApksResult), (bool)res);};
		}
		/// <summary>
		/// 右键选择删除
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnSelectRemoveEvt(object sender, EventArgs e)
		{
			var checkAABItem = _ListAABView.SelectedItems;
			if(checkAABItem == null || checkAABItem.Count < 1)
			{
				return;
			}
			foreach (var element in checkAABItem) 
			{
				string key = element.ToString();
				string path = _APKSFileList[key];
				if(File.Exists(path))
					File.Delete(path);
				_APKSFileList.Remove(key);
				_ListAABView.Items.Remove(element);
			}
		}
		/// <summary>
		/// 清空列表
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnClearAPKSEvt(object sender, EventArgs e)
		{
			_ListAABView.Items.Clear();
			foreach (string path in _APKSFileList.Values) 
			{
				if(File.Exists(path))
					File.Delete(path);
			}
			_APKSFileList.Clear();
		}
		
	}
}
