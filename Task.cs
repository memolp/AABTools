/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/7/1
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// Description of Task.
	/// </summary>
	public class Task
	{
		/// <summary>
		/// 任务完成事件
		/// </summary>
		public event EventHandler FinishEvent;
		
		public delegate bool Runable();
		
		private Runable _runable;
		public Task()
		{
			
		}
		
		public void start(Runable runable)
		{
			_runable = runable;
			Thread thread = new Thread(new ThreadStart(run));
			thread.Start();
		}
		
		void run()
		{
			bool res = _runable();
			FinishEvent.Invoke(res, null);
		}
	}
}
