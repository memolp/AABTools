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
		private System.Windows.Forms.GroupBox _groupBoxEnv;
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
			this._groupBoxEnv = new System.Windows.Forms.GroupBox();
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
			this._groupBoxEnv.SuspendLayout();
			this.SuspendLayout();
			// 
			// _groupBoxEnv
			// 
			this._groupBoxEnv.Controls.Add(this._btnSaveConf);
			this._groupBoxEnv.Controls.Add(this._inputKSPath);
			this._groupBoxEnv.Controls.Add(this._inputKSPassword);
			this._groupBoxEnv.Controls.Add(this._inputKSAlias);
			this._groupBoxEnv.Controls.Add(this.label5);
			this._groupBoxEnv.Controls.Add(this.label4);
			this._groupBoxEnv.Controls.Add(this._btnSelectKS);
			this._groupBoxEnv.Controls.Add(this.label3);
			this._groupBoxEnv.Controls.Add(this._btnADBSelect);
			this._groupBoxEnv.Controls.Add(this._btnJavaSDKSelect);
			this._groupBoxEnv.Controls.Add(this._inputAdbPath);
			this._groupBoxEnv.Controls.Add(this.label1);
			this._groupBoxEnv.Controls.Add(this._labelJavaSdk);
			this._groupBoxEnv.Controls.Add(this._inputJavaSdk);
			this._groupBoxEnv.Dock = System.Windows.Forms.DockStyle.Fill;
			this._groupBoxEnv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._groupBoxEnv.Location = new System.Drawing.Point(0, 0);
			this._groupBoxEnv.Name = "_groupBoxEnv";
			this._groupBoxEnv.Size = new System.Drawing.Size(609, 181);
			this._groupBoxEnv.TabIndex = 6;
			this._groupBoxEnv.TabStop = false;
			// 
			// _btnSaveConf
			// 
			this._btnSaveConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this._btnSaveConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this._btnSaveConf.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnSaveConf.Location = new System.Drawing.Point(522, 118);
			this._btnSaveConf.Name = "_btnSaveConf";
			this._btnSaveConf.Size = new System.Drawing.Size(75, 50);
			this._btnSaveConf.TabIndex = 19;
			this._btnSaveConf.Text = "保存";
			this._btnSaveConf.UseVisualStyleBackColor = false;
			this._btnSaveConf.Click += new System.EventHandler(this.OnSaveConfig);
			// 
			// _inputKSPath
			// 
			this._inputKSPath.Location = new System.Drawing.Point(110, 86);
			this._inputKSPath.Name = "_inputKSPath";
			this._inputKSPath.PlaceHolderStr = null;
			this._inputKSPath.ReadOnly = true;
			this._inputKSPath.Size = new System.Drawing.Size(401, 23);
			this._inputKSPath.TabIndex = 18;
			// 
			// _inputKSPassword
			// 
			this._inputKSPassword.Location = new System.Drawing.Point(111, 147);
			this._inputKSPassword.Name = "_inputKSPassword";
			this._inputKSPassword.Size = new System.Drawing.Size(400, 23);
			this._inputKSPassword.TabIndex = 16;
			// 
			// _inputKSAlias
			// 
			this._inputKSAlias.Location = new System.Drawing.Point(110, 118);
			this._inputKSAlias.Name = "_inputKSAlias";
			this._inputKSAlias.Size = new System.Drawing.Size(401, 23);
			this._inputKSAlias.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "KS PassWord:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "KS Alias:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _btnSelectKS
			// 
			this._btnSelectKS.Location = new System.Drawing.Point(522, 85);
			this._btnSelectKS.Name = "_btnSelectKS";
			this._btnSelectKS.Size = new System.Drawing.Size(75, 23);
			this._btnSelectKS.TabIndex = 11;
			this._btnSelectKS.Text = "选择...";
			this._btnSelectKS.UseVisualStyleBackColor = true;
			this._btnSelectKS.Click += new System.EventHandler(this.OnSelectKeyStore);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Key Store 文件:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _btnADBSelect
			// 
			this._btnADBSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnADBSelect.Location = new System.Drawing.Point(523, 52);
			this._btnADBSelect.Name = "_btnADBSelect";
			this._btnADBSelect.Size = new System.Drawing.Size(75, 23);
			this._btnADBSelect.TabIndex = 8;
			this._btnADBSelect.Text = "选择...";
			this._btnADBSelect.UseVisualStyleBackColor = true;
			this._btnADBSelect.Click += new System.EventHandler(this.OnSelectADBPath);
			// 
			// _btnJavaSDKSelect
			// 
			this._btnJavaSDKSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._btnJavaSDKSelect.Location = new System.Drawing.Point(523, 17);
			this._btnJavaSDKSelect.Name = "_btnJavaSDKSelect";
			this._btnJavaSDKSelect.Size = new System.Drawing.Size(75, 23);
			this._btnJavaSDKSelect.TabIndex = 6;
			this._btnJavaSDKSelect.Text = "选择...";
			this._btnJavaSDKSelect.UseVisualStyleBackColor = true;
			this._btnJavaSDKSelect.Click += new System.EventHandler(this.OnSelectJavaSDK);
			// 
			// _inputAdbPath
			// 
			this._inputAdbPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._inputAdbPath.Location = new System.Drawing.Point(110, 52);
			this._inputAdbPath.Name = "_inputAdbPath";
			this._inputAdbPath.PlaceHolderStr = "<默认路径>";
			this._inputAdbPath.ReadOnly = true;
			this._inputAdbPath.Size = new System.Drawing.Size(401, 23);
			this._inputAdbPath.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(9, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "ADB 路径:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _labelJavaSdk
			// 
			this._labelJavaSdk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._labelJavaSdk.Location = new System.Drawing.Point(9, 17);
			this._labelJavaSdk.Name = "_labelJavaSdk";
			this._labelJavaSdk.Size = new System.Drawing.Size(100, 23);
			this._labelJavaSdk.TabIndex = 0;
			this._labelJavaSdk.Text = "JAVA SDK 路径:";
			this._labelJavaSdk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _inputJavaSdk
			// 
			this._inputJavaSdk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._inputJavaSdk.Location = new System.Drawing.Point(110, 17);
			this._inputJavaSdk.Name = "_inputJavaSdk";
			this._inputJavaSdk.PlaceHolderStr = "<默认路径>";
			this._inputJavaSdk.ReadOnly = true;
			this._inputJavaSdk.Size = new System.Drawing.Size(401, 23);
			this._inputJavaSdk.TabIndex = 1;
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 181);
			this.Controls.Add(this._groupBoxEnv);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "环境配置";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this._groupBoxEnv.ResumeLayout(false);
			this._groupBoxEnv.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
