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
		private System.Windows.Forms.GroupBox _groupBoxList;
		private System.Windows.Forms.Button _btnSetupAAB;
		private System.Windows.Forms.Button _btnAddAAB;
		private System.Windows.Forms.CheckedListBox _ListAABView;
		private System.Windows.Forms.Button _btnSetting;
		private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem _installMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _removeMenuItem;
		private System.Windows.Forms.ComboBox _deviceList;
		private System.Windows.Forms.Label label1;
		
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
		protected void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._groupBoxList = new System.Windows.Forms.GroupBox();
			this._ListAABView = new System.Windows.Forms.CheckedListBox();
			this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._installMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._deviceList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._btnSetting = new System.Windows.Forms.Button();
			this._btnSetupAAB = new System.Windows.Forms.Button();
			this._btnAddAAB = new System.Windows.Forms.Button();
			this._groupBoxList.SuspendLayout();
			this._contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _groupBoxList
			// 
			this._groupBoxList.Controls.Add(this._ListAABView);
			this._groupBoxList.Controls.Add(this._deviceList);
			this._groupBoxList.Controls.Add(this.label1);
			this._groupBoxList.Controls.Add(this._btnSetting);
			this._groupBoxList.Controls.Add(this._btnSetupAAB);
			this._groupBoxList.Controls.Add(this._btnAddAAB);
			this._groupBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
			this._groupBoxList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._groupBoxList.Location = new System.Drawing.Point(0, 0);
			this._groupBoxList.Name = "_groupBoxList";
			this._groupBoxList.Size = new System.Drawing.Size(607, 406);
			this._groupBoxList.TabIndex = 4;
			this._groupBoxList.TabStop = false;
			// 
			// _ListAABView
			// 
			this._ListAABView.CheckOnClick = true;
			this._ListAABView.ContextMenuStrip = this._contextMenuStrip;
			this._ListAABView.FormattingEnabled = true;
			this._ListAABView.Location = new System.Drawing.Point(12, 53);
			this._ListAABView.Name = "_ListAABView";
			this._ListAABView.Size = new System.Drawing.Size(583, 346);
			this._ListAABView.TabIndex = 6;
			this._ListAABView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnItemChecked);
			// 
			// _contextMenuStrip
			// 
			this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._installMenuItem,
			this._removeMenuItem});
			this._contextMenuStrip.Name = "_contextMenuStrip";
			this._contextMenuStrip.Size = new System.Drawing.Size(125, 48);
			// 
			// _installMenuItem
			// 
			this._installMenuItem.Name = "_installMenuItem";
			this._installMenuItem.Size = new System.Drawing.Size(124, 22);
			this._installMenuItem.Text = "选择安装";
			this._installMenuItem.Click += new System.EventHandler(this.OnInstallSelectAAB);
			// 
			// _removeMenuItem
			// 
			this._removeMenuItem.Name = "_removeMenuItem";
			this._removeMenuItem.Size = new System.Drawing.Size(124, 22);
			this._removeMenuItem.Text = "选择删除";
			this._removeMenuItem.Click += new System.EventHandler(this.OnRemoveSelectAAb);
			// 
			// _deviceList
			// 
			this._deviceList.FormattingEnabled = true;
			this._deviceList.Location = new System.Drawing.Point(88, 22);
			this._deviceList.Name = "_deviceList";
			this._deviceList.Size = new System.Drawing.Size(230, 25);
			this._deviceList.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(7, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "已连接设备:";
			// 
			// _btnSetting
			// 
			this._btnSetting.BackColor = System.Drawing.SystemColors.Highlight;
			this._btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnSetting.Location = new System.Drawing.Point(515, 24);
			this._btnSetting.Name = "_btnSetting";
			this._btnSetting.Size = new System.Drawing.Size(80, 24);
			this._btnSetting.TabIndex = 3;
			this._btnSetting.Text = "环境设置";
			this._btnSetting.UseVisualStyleBackColor = false;
			this._btnSetting.Click += new System.EventHandler(this.OnOpenSettings);
			// 
			// _btnSetupAAB
			// 
			this._btnSetupAAB.BackColor = System.Drawing.Color.Coral;
			this._btnSetupAAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSetupAAB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnSetupAAB.Location = new System.Drawing.Point(324, 23);
			this._btnSetupAAB.Name = "_btnSetupAAB";
			this._btnSetupAAB.Size = new System.Drawing.Size(80, 24);
			this._btnSetupAAB.TabIndex = 2;
			this._btnSetupAAB.Text = "安装AAB";
			this._btnSetupAAB.UseVisualStyleBackColor = false;
			this._btnSetupAAB.Click += new System.EventHandler(this.OnInstallSelectAAB);
			// 
			// _btnAddAAB
			// 
			this._btnAddAAB.BackColor = System.Drawing.Color.Turquoise;
			this._btnAddAAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnAddAAB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnAddAAB.Location = new System.Drawing.Point(420, 24);
			this._btnAddAAB.Name = "_btnAddAAB";
			this._btnAddAAB.Size = new System.Drawing.Size(80, 24);
			this._btnAddAAB.TabIndex = 1;
			this._btnAddAAB.Text = "添加AAB";
			this._btnAddAAB.UseVisualStyleBackColor = false;
			this._btnAddAAB.Click += new System.EventHandler(this.OnAddAABFile);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 406);
			this.Controls.Add(this._groupBoxList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AAB安装器 - V1.0";
			this._groupBoxList.ResumeLayout(false);
			this._contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
