/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/7/1
 * Time: 14:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// Description of LoadingForm.
	/// </summary>
	public partial class LoadingForm : Form
	{
		private static LoadingForm _instance = new LoadingForm();
		public LoadingForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static void ShowLoad(string title)
		{
			_instance.Text = title;
			_instance.Show();
		}
		
		public static void CloseLoad()
		{
			_instance.Hide();
		}
	}
}
