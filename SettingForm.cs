/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/6/30
 * Time: 18:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// Description of SettingForm.
	/// </summary>
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
				Const.Instance.JAVA_SDK_PATH = dlg.SelectedPath;
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
				Const.Instance.ADB_PATH = dlg.SelectedPath;
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
				Const.Instance.KEYSTORE_PAHT = dlg.FileName;
			}
		}
		/// <summary>
		/// 保存配置
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnSaveConfig(object sender, EventArgs e)
		{
			string ks_alias = _inputKSAlias.Text;
			string ks_passwd = _inputKSPassword.Text;
			Const.Instance.KEYSTORE_ALIAS = ks_alias;
			Const.Instance.KEYSTORE_PASSWD = ks_passwd;
			Const.SaveData();
			this.Close();
		}
		/// <summary>
		/// 窗口加载的时候设置默认数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnFormLoad(object sender, EventArgs e)
		{
			_inputJavaSdk.Text = Const.Instance.JAVA_SDK_PATH;
			_inputAdbPath.Text = Const.Instance.ADB_PATH;
			_inputKSPath.Text = Const.Instance.KEYSTORE_PAHT;
			_inputKSAlias.Text = Const.Instance.KEYSTORE_ALIAS;
			_inputKSPassword.Text = Const.Instance.KEYSTORE_PASSWD;
		}
	}
}
