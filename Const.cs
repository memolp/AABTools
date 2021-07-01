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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AndroidAppBundleTools
{
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
		
		private string _java_sdk_path = string.Empty;
		/// <summary>
		/// 返回JAVA SDK的路径
		/// </summary>
		public string JAVA_SDK_PATH
		{
			set
			{
				_java_sdk_path = value;
			}
			get
			{
				return _java_sdk_path;
			}
		}
		private string _adb_path = string.Empty;
		/// <summary>
		/// 返回ADB的路径
		/// </summary>
		public string ADB_PATH
		{
			set
			{
				_adb_path = value;
			}
			get
			{
				return _adb_path;
			}
		}
		
		private string _key_store_path = string.Empty;
		/// <summary>
		/// keystore路径
		/// </summary>
		public string KEYSTORE_PAHT
		{
			set
			{
				_key_store_path = value;
			}
			get
			{
				return _key_store_path;
			}
		}
		
		private string _key_store_alias = string.Empty;
		/// <summary>
		/// keystore 别名
		/// </summary>
		public string KEYSTORE_ALIAS
		{
			set
			{
				_key_store_alias = value;
			}
			get
			{
				return _key_store_alias;
			}
		}
		
		private string _key_store_passwd = string.Empty;
		/// <summary>
		/// keystore 密码
		/// </summary>
		public string KEYSTORE_PASSWD
		{
			set
			{
				_key_store_passwd = value;
			}
			get
			{
				return _key_store_passwd;
			}
		}
		
	}
}
