/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/6/30
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QGUI
{
	/// <summary>
	/// Description of TextBoxEx.
	/// </summary>
	public class TextBoxEx : System.Windows.Forms.TextBox
	{
		public TextBoxEx()
		{
		}
		/// <summary>
		/// 设置默认提示信息
		/// </summary>
		public String PlaceHolderStr { get; set; }
		/// <summary>
		/// 重新消息
		/// </summary>
		/// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xF || m.Msg == 0x133)
            {
                WmPaint(ref m);
            }
        }
        /// <summary>
        /// 绘制
        /// </summary>
        /// <param name="m"></param>
        private void WmPaint(ref Message m)
        {
            Graphics g = Graphics.FromHwnd(base.Handle);
            if (!String.IsNullOrEmpty(this.PlaceHolderStr) && string.IsNullOrEmpty(this.Text))
                g.DrawString(this.PlaceHolderStr, this.Font, new SolidBrush(Color.LightGray), 0, 0);
        }
	}
}
