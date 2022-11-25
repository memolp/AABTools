/*
 * 用户： 覃贵锋
 * 日期: 2022/11/25
 * 时间: 10:54
 * 
 * 
 */
namespace AndroidAppBundleTools
{
	partial class ProjectAAB
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button _btnAddAAB;
		private System.Windows.Forms.Button _btnSetupAAB;
		private System.Windows.Forms.CheckedListBox _ListAABView;
		private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem _installMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _removeMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label ProjectNameLabel;
		private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ProjectNameLabel = new System.Windows.Forms.Label();
			this._ListAABView = new System.Windows.Forms.CheckedListBox();
			this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._installMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this._btnAddAAB = new System.Windows.Forms.Button();
			this._btnSetupAAB = new System.Windows.Forms.Button();
			this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this._contextMenuStrip.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ProjectNameLabel);
			this.panel1.Controls.Add(this._ListAABView);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(373, 280);
			this.panel1.TabIndex = 0;
			// 
			// ProjectNameLabel
			// 
			this.ProjectNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ProjectNameLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ProjectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ProjectNameLabel.Location = new System.Drawing.Point(118, 7);
			this.ProjectNameLabel.Name = "ProjectNameLabel";
			this.ProjectNameLabel.Size = new System.Drawing.Size(100, 23);
			this.ProjectNameLabel.TabIndex = 12;
			this.ProjectNameLabel.Text = "WOW";
			this.ProjectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _ListAABView
			// 
			this._ListAABView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._ListAABView.CheckOnClick = true;
			this._ListAABView.ContextMenuStrip = this._contextMenuStrip;
			this._ListAABView.FormattingEnabled = true;
			this._ListAABView.Location = new System.Drawing.Point(3, 35);
			this._ListAABView.Name = "_ListAABView";
			this._ListAABView.Size = new System.Drawing.Size(365, 196);
			this._ListAABView.TabIndex = 9;
			// 
			// _contextMenuStrip
			// 
			this._contextMenuStrip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._installMenuItem,
			this._removeMenuItem,
			this.清空列表ToolStripMenuItem});
			this._contextMenuStrip.Name = "_contextMenuStrip";
			this._contextMenuStrip.Size = new System.Drawing.Size(153, 92);
			// 
			// _installMenuItem
			// 
			this._installMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._installMenuItem.Name = "_installMenuItem";
			this._installMenuItem.Size = new System.Drawing.Size(152, 22);
			this._installMenuItem.Text = "选择安装";
			this._installMenuItem.Click += new System.EventHandler(this.OnSelectInstallEvt);
			// 
			// _removeMenuItem
			// 
			this._removeMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._removeMenuItem.Name = "_removeMenuItem";
			this._removeMenuItem.Size = new System.Drawing.Size(152, 22);
			this._removeMenuItem.Text = "选择删除";
			this._removeMenuItem.Click += new System.EventHandler(this.OnSelectRemoveEvt);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this._btnAddAAB);
			this.panel3.Controls.Add(this._btnSetupAAB);
			this.panel3.Location = new System.Drawing.Point(3, 236);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(367, 41);
			this.panel3.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(73)))), ((int)(((byte)(69)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(23, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 24);
			this.button1.TabIndex = 9;
			this.button1.Text = "项目设置";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.OnProjectSetting);
			// 
			// _btnAddAAB
			// 
			this._btnAddAAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this._btnAddAAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
			this._btnAddAAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnAddAAB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnAddAAB.ForeColor = System.Drawing.Color.White;
			this._btnAddAAB.Location = new System.Drawing.Point(128, 9);
			this._btnAddAAB.Name = "_btnAddAAB";
			this._btnAddAAB.Size = new System.Drawing.Size(73, 24);
			this._btnAddAAB.TabIndex = 7;
			this._btnAddAAB.Text = "添加AAB";
			this._btnAddAAB.UseVisualStyleBackColor = false;
			this._btnAddAAB.Click += new System.EventHandler(this.OnAddAABFile);
			// 
			// _btnSetupAAB
			// 
			this._btnSetupAAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this._btnSetupAAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this._btnSetupAAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSetupAAB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnSetupAAB.ForeColor = System.Drawing.Color.White;
			this._btnSetupAAB.Location = new System.Drawing.Point(240, 9);
			this._btnSetupAAB.Name = "_btnSetupAAB";
			this._btnSetupAAB.Size = new System.Drawing.Size(73, 24);
			this._btnSetupAAB.TabIndex = 8;
			this._btnSetupAAB.Text = "安装AAB";
			this._btnSetupAAB.UseVisualStyleBackColor = false;
			this._btnSetupAAB.Click += new System.EventHandler(this.OnInstallSelectAAB);
			// 
			// 清空列表ToolStripMenuItem
			// 
			this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
			this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.清空列表ToolStripMenuItem.Text = "清空列表";
			this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.OnClearAPKSEvt);
			// 
			// ProjectAAB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "ProjectAAB";
			this.Size = new System.Drawing.Size(373, 280);
			this.Load += new System.EventHandler(this.OnFrameLoad);
			this.panel1.ResumeLayout(false);
			this._contextMenuStrip.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
