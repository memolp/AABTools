/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/6/30
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AndroidAppBundleTools
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox _deviceList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox LogoPic;
		private System.Windows.Forms.Panel DevicesPanel;
		private System.Windows.Forms.Panel AABContentPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button CreateProjectButton;
		private System.Windows.Forms.Panel LeftPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel ProjectListPanel;
		private System.Windows.Forms.Panel panel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) 
			{
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		#region Windows Form Designer generated code
		/// <summary>
		/// 
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._deviceList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LogoPic = new System.Windows.Forms.PictureBox();
			this.DevicesPanel = new System.Windows.Forms.Panel();
			this.CreateProjectButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.AABContentPanel = new System.Windows.Forms.Panel();
			this.LeftPanel = new System.Windows.Forms.Panel();
			this.ProjectListPanel = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
			this.DevicesPanel.SuspendLayout();
			this.LeftPanel.SuspendLayout();
			this.ProjectListPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _deviceList
			// 
			this._deviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._deviceList.FormattingEnabled = true;
			this._deviceList.Location = new System.Drawing.Point(89, 49);
			this._deviceList.Name = "_deviceList";
			this._deviceList.Size = new System.Drawing.Size(277, 20);
			this._deviceList.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(7, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "已连接设备:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LogoPic
			// 
			this.LogoPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(69)))));
			this.LogoPic.Dock = System.Windows.Forms.DockStyle.Top;
			this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
			this.LogoPic.Location = new System.Drawing.Point(0, 0);
			this.LogoPic.Name = "LogoPic";
			this.LogoPic.Size = new System.Drawing.Size(159, 81);
			this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.LogoPic.TabIndex = 0;
			this.LogoPic.TabStop = false;
			// 
			// DevicesPanel
			// 
			this.DevicesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
			this.DevicesPanel.Controls.Add(this.CreateProjectButton);
			this.DevicesPanel.Controls.Add(this.label2);
			this.DevicesPanel.Controls.Add(this._deviceList);
			this.DevicesPanel.Controls.Add(this.label1);
			this.DevicesPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.DevicesPanel.ForeColor = System.Drawing.Color.White;
			this.DevicesPanel.Location = new System.Drawing.Point(0, 0);
			this.DevicesPanel.Name = "DevicesPanel";
			this.DevicesPanel.Size = new System.Drawing.Size(463, 81);
			this.DevicesPanel.TabIndex = 8;
			// 
			// CreateProjectButton
			// 
			this.CreateProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(138)))));
			this.CreateProjectButton.FlatAppearance.BorderSize = 0;
			this.CreateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateProjectButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CreateProjectButton.Location = new System.Drawing.Point(375, 44);
			this.CreateProjectButton.Name = "CreateProjectButton";
			this.CreateProjectButton.Size = new System.Drawing.Size(80, 28);
			this.CreateProjectButton.TabIndex = 0;
			this.CreateProjectButton.Text = "创建项目";
			this.CreateProjectButton.UseVisualStyleBackColor = false;
			this.CreateProjectButton.Click += new System.EventHandler(this.OnOpenSettings);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(101, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "请选择需要安装的机器设备号，需要打开开发者USB调试设置";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AABContentPanel
			// 
			this.AABContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
			this.AABContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.AABContentPanel.ForeColor = System.Drawing.Color.White;
			this.AABContentPanel.Location = new System.Drawing.Point(0, 81);
			this.AABContentPanel.Name = "AABContentPanel";
			this.AABContentPanel.Size = new System.Drawing.Size(463, 353);
			this.AABContentPanel.TabIndex = 9;
			// 
			// LeftPanel
			// 
			this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
			this.LeftPanel.Controls.Add(this.ProjectListPanel);
			this.LeftPanel.Controls.Add(this.LogoPic);
			this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftPanel.Name = "LeftPanel";
			this.LeftPanel.Size = new System.Drawing.Size(159, 434);
			this.LeftPanel.TabIndex = 10;
			// 
			// ProjectListPanel
			// 
			this.ProjectListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(69)))));
			this.ProjectListPanel.Controls.Add(this.button3);
			this.ProjectListPanel.Controls.Add(this.button1);
			this.ProjectListPanel.Controls.Add(this.button2);
			this.ProjectListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProjectListPanel.Location = new System.Drawing.Point(0, 81);
			this.ProjectListPanel.Name = "ProjectListPanel";
			this.ProjectListPanel.Size = new System.Drawing.Size(159, 353);
			this.ProjectListPanel.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(127)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(0, 86);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(159, 43);
			this.button3.TabIndex = 3;
			this.button3.Text = "Genesis";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(21)))), ((int)(((byte)(87)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(127)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "WOW";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(127)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(159, 43);
			this.button2.TabIndex = 2;
			this.button2.Text = "Flite";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.AABContentPanel);
			this.panel1.Controls.Add(this.DevicesPanel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(159, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(463, 434);
			this.panel1.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 434);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LeftPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AAB安装器 - V2.0";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosingEvt);
			((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
			this.DevicesPanel.ResumeLayout(false);
			this.LeftPanel.ResumeLayout(false);
			this.ProjectListPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	#endregion
	}
}
