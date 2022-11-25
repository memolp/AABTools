/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/7/1
 * Time: 10:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// Description of CommandTools.
	/// </summary>
	public class CommandTools
	{
		/// <summary>
		/// 连接到指定的设备
		/// </summary>
		private const string ADB_CONNECT_CMD = "adb connect {0}:{1}";
		/// <summary>
		/// 显示连接的设备列表
		/// </summary>
		private const string ADB_DEVICES_CMD = "adb devices";
		/// <summary>
		/// 设备列表的标记
		/// </summary>
		private const string ADB_DEVICES_TAG = "List of devices attached";
		/// <summary>
		/// 换行分隔符
		/// </summary>
		private static char[] ADB_LINE_SPLIT = "\r\n".ToCharArray();
		/// <summary>
		/// 创建APKS命令
		/// </summary>
		private const string BUILD_APKS_CMD = "java -jar bundletool-all.jar build-apks --bundle=\"{0}\" --output=\"{1}\" --ks=\"{2}\" --ks-key-alias={3} --ks-pass=pass:{4}";
		/// <summary>
		/// 安装APKS命令
		/// </summary>
		private const string INSTALL_APKS_CMD = "java -jar bundletool-all.jar install-apks --apks=\"{0}\" --device-id=\"{1}\"";
		
		public CommandTools()
		{
		}
		/// <summary>
		/// 获取设备列表
		/// </summary>
		/// <param name="devices"></param>
		/// <returns></returns>
		public static bool GetDeivcesList(out string[] devices)
		{
			string result = string.Empty;
			List<string> data = new List<string>();
			if(CommandTools.execute_cmd(ADB_DEVICES_CMD, out result))
			{
				bool match = false;
				foreach (string line in result.Split(ADB_LINE_SPLIT)) 
				{
					if(line.Equals(ADB_DEVICES_TAG))
					{
						match = true;
						continue;
					}
					if(match && !string.IsNullOrWhiteSpace(line))
					{
						string[] name_type = line.Split();
						if(name_type.Length > 1 && name_type[1].Equals("device"))
						{
							data.Add(name_type[0]);
						}
					}
				}
				devices = data.ToArray();
				return true;
			}else
			{
				devices = null;
			}
			return false;
		}
		/// <summary>
		/// 将AAB文件转换成APKS文件
		/// </summary>
		/// <param name="aabfilePath"></param>
		/// <param name="apksfilePath"></param>
		/// <returns></returns>
		public static bool BuildApks(string aabfilePath, string apksfilePath, string keystore, string alias, string password)
		{
			string cmd = string.Format(BUILD_APKS_CMD, aabfilePath, apksfilePath, keystore, alias, password);
			string result = string.Empty;
			if(!CommandTools.execute_cmd(cmd, out result))
			{
				Console.WriteLine(result);
				return false;
			}
			return true;
		}
		/// <summary>
		/// 将APKS文件安装到指定的设备
		/// </summary>
		/// <param name="apksfilePath"></param>
		/// <param name="device_id"></param>
		/// <returns></returns>
		public static bool InstallApks(string apksfilePath, string device_id)
		{
			string cmd = string.Format(INSTALL_APKS_CMD, apksfilePath, device_id);
			string result = string.Empty;
			if(!CommandTools.execute_cmd(cmd, out result))
			{
				Console.WriteLine(result);
				return false;
			}
			return true;
		}
		/// <summary>
		/// 执行命令行
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public static bool execute_cmd(string command, out string result) 
		{
		    System.Diagnostics.Process pro = new System.Diagnostics.Process();
		    pro.StartInfo.FileName = "cmd.exe";
		    pro.StartInfo.UseShellExecute = false;
		    pro.StartInfo.RedirectStandardError = true;
		    pro.StartInfo.RedirectStandardInput = true;
		    pro.StartInfo.RedirectStandardOutput = true;
		    pro.StartInfo.CreateNoWindow = true;
		    
		    //pro.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
		    pro.Start();
		    pro.StandardInput.WriteLine(command + "&exit");
//		    pro.StandardInput.WriteLine("exit");
		    pro.StandardInput.AutoFlush = true;
		    //获取cmd窗口的输出信息
		    result = pro.StandardOutput.ReadToEnd();
		    pro.WaitForExit();//等待程序执行完退出进程
		    int code = pro.ExitCode;
		    pro.Close();
		    return code == 0;
		}
		/// <summary>
		/// 设置环境变量
		/// </summary>
		/// <param name="envName"></param>
		/// <param name="envValue"></param>
		/// <param name="replace">是否直接替换原数据</param>
		/// <returns></returns>
		public static void SetEnvironment(string envName,string envValue, bool replace) 
        {
           
			string envValues = Environment.GetEnvironmentVariable(envName, EnvironmentVariableTarget.Machine);
			if (string.IsNullOrEmpty(envValues) || replace)
            {
                Environment.SetEnvironmentVariable(envName, envValue, EnvironmentVariableTarget.Machine);
            }
            else
            {
                string temp="";
                string[] vlist = envValues.Split(';');
                foreach (string item in vlist)
                {
                    if (item != envValue && item != "")
                        temp += item+";";
                }
                Environment.SetEnvironmentVariable(envName, temp +  envValue + ";", EnvironmentVariableTarget.Machine);
            }
        }
	}
}
