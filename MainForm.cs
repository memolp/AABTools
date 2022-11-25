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
		public static MainForm Instance = null;

		private Timer _tickTimer;
		
		public MainForm()
		{
			Instance = this;
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
			OnInitProjectListView();
		}
		/// <summary>
		/// 获取设备名
		/// </summary>
		/// <returns></returns>
		public string GetDeviceName()
		{
			return _deviceList.Text;
		}
		/// <summary>
		/// 刷新项目列表
		/// </summary>
		void OnInitProjectListView()
		{
			ProjectListPanel.Controls.Clear();
			foreach (ProjectItem item in Const.Instance.ProjectList.Values)
			{
				Button btn = new Button();
				btn.Text = item.ProjectName;
				btn.FlatAppearance.BorderSize = 0;
				btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
				btn.Dock = DockStyle.Top;
				btn.FlatStyle = FlatStyle.Flat;
				btn.ForeColor = Color.White;
				btn.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
				btn.Size = new Size(158, 40);
				btn.UseVisualStyleBackColor = false;
				btn.Click += OnSelectProjectEvt;
				ProjectListPanel.Controls.Add(btn);
			}
		}

		void OnSelectProjectEvt(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			string projectName = btn.Text;
			ProjectItem item = Const.Instance.ProjectList[projectName];
			AABContentPanel.Controls.Clear();
			ProjectAAB aabPanel = new ProjectAAB(item);
			aabPanel.Dock = DockStyle.Fill;
			AABContentPanel.Controls.Add(aabPanel);
			foreach (var element in ProjectListPanel.Controls) 
			{
				Button control = (Button)element;
				if(control == btn)
				{
					control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(21)))), ((int)(((byte)(87)))));
				}else
				{
					control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
				}
			}
		}
		
		void OnOpenSettings(object sender, EventArgs e)
		{
			SettingForm dlg = new SettingForm();
			dlg.OnCreateProject = (ojb) => {
				if(!Directory.Exists(ojb.ProjectAPKsPath))
				{
					Directory.CreateDirectory(ojb.ProjectAPKsPath);
				}
				// disable once ConvertToLambdaExpression
				this.OnInitProjectListView();
			};
			dlg.ShowDialog();
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
				this.Invoke(new TaskResultRunable(delegate(bool result)
				  {
                  	if(result)
                  	{
                  		_deviceList.Items.Clear();
						_deviceList.Items.AddRange(devices);
                  	}
		    }), (bool)res);};
		}
		
		void OnFormClosingEvt(object sender, FormClosingEventArgs e)
		{
			_tickTimer.Stop();
		}
	}
}
