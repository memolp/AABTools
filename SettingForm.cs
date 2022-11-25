using System;
using System.Windows.Forms;
using System.IO;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// 项目配置对话框
	/// </summary>
	public partial class SettingForm : Form
	{
		public delegate void OnCreateProjectEventHandler(ProjectItem item);
		
		private ProjectItem _projectItem = null;
		/// <summary>
		/// 创建项目
		/// </summary>
		public OnCreateProjectEventHandler OnCreateProject = null;
		/// <summary>
		/// 默认构造函数，新建项目配置
		/// </summary>
		public SettingForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 修改项目配置的构造函数
		/// </summary>
		/// <param name="item"></param>
		public SettingForm(ProjectItem item)
		{
			InitializeComponent();
			_projectItem = item;
			ProjectNameInput.Text = item.ProjectName;
			ProjectNameInput.ReadOnly = true;
			ProjectAABInput.Text = item.ProjectAABPath;
			_inputJavaSdk.Text = item.ProjectJDKPath;
			_inputAdbPath.Text = item.ProjectADBPath;
			_inputKSPath.Text = item.ProjectKeystore;
			_inputKSAlias.Text = item.KeySAlias;
			_inputKSPassword.Text = item.KeySPassword;
		}
		/// <summary>
		/// 指定JAVA SDK的路径
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSelectJavaSDK(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			DialogResult result = dlg.ShowDialog();
			if(result == DialogResult.OK)
			{
				if(string.IsNullOrEmpty(dlg.SelectedPath))
				{
					return;
				}
				if(!Directory.Exists(dlg.SelectedPath))
				{
					return;
				}
				_inputJavaSdk.Text = dlg.SelectedPath;
			}
		}
		/// <summary>
		/// 指定 ADB 的路径
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSelectADBPath(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			DialogResult result = dlg.ShowDialog();
			if(result == DialogResult.OK)
			{
				if(string.IsNullOrEmpty(dlg.SelectedPath))
				{
					return;
				}
				if(!Directory.Exists(dlg.SelectedPath))
				{
					return;
				}
				_inputAdbPath.Text = dlg.SelectedPath;
			}
		}
		/// <summary>
		/// 选择 keystore 的路径
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnSelectKeyStore(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "选择证书文件";
			dlg.Filter = "ks files (*.keystore)|*.keystore|All files (*.*)|*.*";
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
					return;
				}
				_inputKSPath.Text = dlg.FileName;
			}
		}
		/// <summary>
		/// 保存配置
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnSaveConfig(object sender, EventArgs e)
		{
			// 新建
			if(_projectItem == null)
			{
				string projectName = ProjectNameInput.Text;
				if(string.IsNullOrEmpty(projectName))
				{
					MessageBox.Show("请输入项目名称", "提示");
					return;
				}
				if(Const.Instance.ProjectList.ContainsKey(projectName))
				{
					MessageBox.Show("输入的项目名称已经存在", "提示");
					return;
				}
				_projectItem = new ProjectItem();
				_projectItem.ProjectName = projectName;
				_projectItem.ProjectAABPath = ProjectAABInput.Text;
				_projectItem.ProjectJDKPath = _inputJavaSdk.Text;
				_projectItem.ProjectADBPath = _inputAdbPath.Text;
				_projectItem.ProjectAPKsPath = Guid.NewGuid().ToString();
				_projectItem.ProjectKeystore = _inputKSPath.Text;
				_projectItem.KeySAlias = _inputKSAlias.Text;
				_projectItem.KeySPassword = _inputKSPassword.Text;
				Const.Instance.ProjectList.Add(projectName, _projectItem);
				if(OnCreateProject != null) OnCreateProject.Invoke(_projectItem);
			}else
			{
				_projectItem.ProjectAABPath = ProjectAABInput.Text;
				_projectItem.ProjectJDKPath = _inputJavaSdk.Text;
				_projectItem.ProjectADBPath = _inputAdbPath.Text;
				_projectItem.ProjectKeystore = _inputKSPath.Text;
				_projectItem.KeySAlias = _inputKSAlias.Text;
				_projectItem.KeySPassword = _inputKSPassword.Text;
			}
			Const.SaveData();
			this.Close();
		}

		void OnSelectAABRootPath(object sender, EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			folder.Description = "选则项目AAB包的根路径，方便每次快速定位";
			folder.ShowNewFolderButton = false;
			if(DialogResult.OK == folder.ShowDialog())
			{
				if(Directory.Exists(folder.SelectedPath))
				{
					ProjectAABInput.Text = folder.SelectedPath;
				}
			}
		}
	}
}
