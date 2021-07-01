/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/7/1
 * Time: 14:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AndroidAppBundleTools
{
	partial class LoadingForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox _loadImageCtrl;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
			this._loadImageCtrl = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._loadImageCtrl)).BeginInit();
			this.SuspendLayout();
			// 
			// _loadImageCtrl
			// 
			this._loadImageCtrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._loadImageCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._loadImageCtrl.ErrorImage = ((System.Drawing.Image)(resources.GetObject("_loadImageCtrl.ErrorImage")));
			this._loadImageCtrl.Image = ((System.Drawing.Image)(resources.GetObject("_loadImageCtrl.Image")));
			this._loadImageCtrl.InitialImage = ((System.Drawing.Image)(resources.GetObject("_loadImageCtrl.InitialImage")));
			this._loadImageCtrl.Location = new System.Drawing.Point(0, 0);
			this._loadImageCtrl.Name = "_loadImageCtrl";
			this._loadImageCtrl.Size = new System.Drawing.Size(259, 138);
			this._loadImageCtrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._loadImageCtrl.TabIndex = 0;
			this._loadImageCtrl.TabStop = false;
			// 
			// LoadingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(259, 138);
			this.ControlBox = false;
			this.Controls.Add(this._loadImageCtrl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoadingForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "加载中....";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this._loadImageCtrl)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
