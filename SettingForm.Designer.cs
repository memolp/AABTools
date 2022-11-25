/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/6/30
 * Time: 18:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AndroidAppBundleTools
{
	partial class SettingForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button _btnADBSelect;
		private System.Windows.Forms.Button _btnJavaSDKSelect;
		private QGUI.TextBoxEx _inputAdbPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _labelJavaSdk;
		private QGUI.TextBoxEx _inputJavaSdk;
		private System.Windows.Forms.TextBox _inputKSPassword;
		private System.Windows.Forms.TextBox _inputKSAlias;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button _btnSelectKS;
		private System.Windows.Forms.Label label3;
		private QGUI.TextBoxEx _inputKSPath;
		private System.Windows.Forms.Button _btnSaveConf;
		private System.Windows.Forms.TextBox ProjectNameInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox ProjectAABInput;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
			this._btnSaveConf = new System.Windows.Forms.Button();
			this._inputKSPath = new QGUI.TextBoxEx();
			this._inputKSPassword = new System.Windows.Forms.TextBox();
			this._inputKSAlias = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._btnSelectKS = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this._btnADBSelect = new System.Windows.Forms.Button();
			this._btnJavaSDKSelect = new System.Windows.Forms.Button();
			this._inputAdbPath = new QGUI.TextBoxEx();
			this.label1 = new System.Windows.Forms.Label();
			this._labelJavaSdk = new System.Windows.Forms.Label();
			this._inputJavaSdk = new QGUI.TextBoxEx();
			this.label2 = new System.Windows.Forms.Label();
			this.ProjectNameInput = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ProjectAABInput = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnSaveConf
			// 
			this._btnSaveConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSaveConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this._btnSaveConf.FlatAppearance.BorderSize = 0;
			this._btnSaveConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSaveConf.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnSaveConf.Location = new System.Drawing.Point(429, 175);
			this._btnSaveConf.Name = "_btnSaveConf";
			this._btnSaveConf.Size = new System.Drawing.Size(87, 34);
			this._btnSaveConf.TabIndex = 19;
			this._btnSaveConf.Text = "保存";
			this._btnSaveConf.UseVisualStyleBackColor = false;
			this._btnSaveConf.Click += new System.EventHandler(this.OnSaveConfig);
			// 
			// _inputKSPath
			// 
			this._inputKSPath.Location = new System.Drawing.Point(108, 132);
			this._inputKSPath.Name = "_inputKSPath";
			this._inputKSPath.PlaceHolderStr = null;
			this._inputKSPath.ReadOnly = true;
			this._inputKSPath.Size = new System.Drawing.Size(313, 21);
			this._inputKSPath.TabIndex = 18;
			// 
			// _inputKSPassword
			// 
			this._inputKSPassword.Location = new System.Drawing.Point(109, 190);
			this._inputKSPassword.Name = "_inputKSPassword";
			this._inputKSPassword.Size = new System.Drawing.Size(312, 21);
			this._inputKSPassword.TabIndex = 16;
			// 
			// _inputKSAlias
			// 
			this._inputKSAlias.Location = new System.Drawing.Point(108, 161);
			this._inputKSAlias.Name = "_inputKSAlias";
			this._inputKSAlias.Size = new System.Drawing.Size(313, 21);
			this._inputKSAlias.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "KS PassWord:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "KS Alias:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _btnSelectKS
			// 
			this._btnSelectKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSelectKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
			this._btnSelectKS.FlatAppearance.BorderSize = 0;
			this._btnSelectKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSelectKS.Location = new System.Drawing.Point(429, 130);
			this._btnSelectKS.Name = "_btnSelectKS";
			this._btnSelectKS.Size = new System.Drawing.Size(87, 23);
			this._btnSelectKS.TabIndex = 11;
			this._btnSelectKS.Text = "选择...";
			this._btnSelectKS.UseVisualStyleBackColor = false;
			this._btnSelectKS.Click += new System.EventHandler(this.OnSelectKeyStore);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Key Store 文件:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _btnADBSelect
			// 
			this._btnADBSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnADBSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
			this._btnADBSelect.FlatAppearance.BorderSize = 0;
			this._btnADBSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnADBSelect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnADBSelect.Location = new System.Drawing.Point(429, 101);
			this._btnADBSelect.Name = "_btnADBSelect";
			this._btnADBSelect.Size = new System.Drawing.Size(87, 23);
			this._btnADBSelect.TabIndex = 8;
			this._btnADBSelect.Text = "选择...";
			this._btnADBSelect.UseVisualStyleBackColor = false;
			this._btnADBSelect.Click += new System.EventHandler(this.OnSelectADBPath);
			// 
			// _btnJavaSDKSelect
			// 
			this._btnJavaSDKSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnJavaSDKSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
			this._btnJavaSDKSelect.FlatAppearance.BorderSize = 0;
			this._btnJavaSDKSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnJavaSDKSelect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnJavaSDKSelect.Location = new System.Drawing.Point(429, 72);
			this._btnJavaSDKSelect.Name = "_btnJavaSDKSelect";
			this._btnJavaSDKSelect.Size = new System.Drawing.Size(87, 23);
			this._btnJavaSDKSelect.TabIndex = 6;
			this._btnJavaSDKSelect.Text = "选择...";
			this._btnJavaSDKSelect.UseVisualStyleBackColor = false;
			this._btnJavaSDKSelect.Click += new System.EventHandler(this.OnSelectJavaSDK);
			// 
			// _inputAdbPath
			// 
			this._inputAdbPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._inputAdbPath.Location = new System.Drawing.Point(108, 101);
			this._inputAdbPath.Name = "_inputAdbPath";
			this._inputAdbPath.PlaceHolderStr = "<默认路径>";
			this._inputAdbPath.ReadOnly = true;
			this._inputAdbPath.Size = new System.Drawing.Size(313, 23);
			this._inputAdbPath.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(6, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "ADB 路径:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _labelJavaSdk
			// 
			this._labelJavaSdk.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._labelJavaSdk.Location = new System.Drawing.Point(6, 70);
			this._labelJavaSdk.Name = "_labelJavaSdk";
			this._labelJavaSdk.Size = new System.Drawing.Size(100, 23);
			this._labelJavaSdk.TabIndex = 0;
			this._labelJavaSdk.Text = "JAVA SDK 路径:";
			this._labelJavaSdk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _inputJavaSdk
			// 
			this._inputJavaSdk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._inputJavaSdk.Location = new System.Drawing.Point(108, 70);
			this._inputJavaSdk.Name = "_inputJavaSdk";
			this._inputJavaSdk.PlaceHolderStr = "<默认路径>";
			this._inputJavaSdk.ReadOnly = true;
			this._inputJavaSdk.Size = new System.Drawing.Size(313, 23);
			this._inputJavaSdk.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "项目名称:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ProjectNameInput
			// 
			this.ProjectNameInput.Location = new System.Drawing.Point(108, 12);
			this.ProjectNameInput.Name = "ProjectNameInput";
			this.ProjectNameInput.Size = new System.Drawing.Size(313, 21);
			this.ProjectNameInput.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "AAB包根路径:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ProjectAABInput
			// 
			this.ProjectAABInput.Location = new System.Drawing.Point(109, 41);
			this.ProjectAABInput.Name = "ProjectAABInput";
			this.ProjectAABInput.Size = new System.Drawing.Size(312, 21);
			this.ProjectAABInput.TabIndex = 23;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(429, 42);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "选择...";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.OnSelectAABRootPath);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ProjectNameInput);
			this.panel1.Controls.Add(this._btnSaveConf);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this._inputKSPassword);
			this.panel1.Controls.Add(this._inputKSAlias);
			this.panel1.Controls.Add(this._inputKSPath);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this._inputJavaSdk);
			this.panel1.Controls.Add(this._inputAdbPath);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.ProjectAABInput);
			this.panel1.Controls.Add(this._labelJavaSdk);
			this.panel1.Controls.Add(this._btnSelectKS);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this._btnADBSelect);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this._btnJavaSDKSelect);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(523, 238);
			this.panel1.TabIndex = 25;
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(523, 238);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "项目环境配置";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
