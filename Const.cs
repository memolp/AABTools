/*
 * Created by SharpDevelop.
 * User: qingf
 * Date: 2021/6/30
 * Time: 17:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AndroidAppBundleTools
{
	/// <summary>
	/// 每个项目的配置数据存储结构
	/// </summary>
	[Serializable]
	public class ProjectItem
	{
		/// <summary>
		/// 项目名称
		/// </summary>
		public string ProjectName = "";
		/// <summary>
		/// 项目的JDK路径，可以不设置
		/// </summary>
		public string ProjectJDKPath = "";
		/// <summary>
		/// 项目的ADB路径，可以不设置
		/// </summary>
		public string ProjectADBPath = "";
		/// <summary>
		/// 项目的Keystore文件
		/// </summary>
		public string ProjectKeystore = "";
		/// <summary>
		/// keystore的alias
		/// </summary>
		public string KeySAlias = "";
		/// <summary>
		/// keystore的alias的密码
		/// </summary>
		public string KeySPassword = "";
		/// <summary>
		/// 这个随机生成，并固定
		/// </summary>
		public string ProjectAPKsPath = "";
		/// <summary>
		/// 项目的aab路径，方便不用每次切换
		/// </summary>
		public string ProjectAABPath = "";
	}
	/// <summary>
	/// Description of Const.
	/// </summary>
	[Serializable]
	public class Const
	{
		/// <summary>
		/// 缓存应用数据
		/// </summary>
		public static string LOCAL_DATA_PATH = "app.dat";
		/// <summary>
		/// 项目列表
		/// </summary>
		public Dictionary<string, ProjectItem> ProjectList = new Dictionary<string, ProjectItem>();
		/// <summary>
		/// 单例对象
		/// </summary>
		private static Const _instance = null;
		/// <summary>
		/// 加载数据
		/// </summary>
		/// <param name="data_path"></param>
		/// <returns></returns>
		public static Const LoadFromData()
		{
			if(!File.Exists(LOCAL_DATA_PATH))
			{
				_instance = new Const();
				return _instance;
			}
			IFormatter formatter = new BinaryFormatter();
			using (FileStream fs = new FileStream(LOCAL_DATA_PATH, FileMode.Open))
			{
				Const _cst = (Const)formatter.Deserialize(fs);
				_instance = _cst;
			}
			return _instance;
		}
		/// <summary>
		/// 保存数据
		/// </summary>
		public static void SaveData()
		{
			IFormatter formatter = new BinaryFormatter();
			using (FileStream fs = new FileStream(LOCAL_DATA_PATH, FileMode.OpenOrCreate))
			{
			    formatter.Serialize(fs, _instance);
			}
		}
		/// <summary>
		/// 获取实例对象，必须首先调用LoadFromData方法加载数据。
		/// </summary>
		public static Const Instance
		{
			get
			{
				return _instance;
			}
		}
	}
}
