using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CRM_MODEL
{
	[System.Serializable]
	public class ContextSettings
	{ 
		public string Source { get; set; }
		public string Catalog { get; set; }
		public string User { get; set; }
		public string Password { get; set; }

		static ContextSettings _instance;
		public static CRM_MODEL.ContextSettings Instance
		{
			get
			{
				if (_instance == null) _instance = LoadInstance();				
				return _instance;
			}
		}
		public static string FileName
		{
			get { return "ContextSettings.xml"; }
		}

		public void Save()
		{
			XmlSerializer formatter = new XmlSerializer(typeof(ContextSettings));
			using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate)) {
				formatter.Serialize(fs, this);
			}
		}
		static ContextSettings LoadInstance()
		{
			XmlSerializer formatter = new XmlSerializer(typeof(ContextSettings));
			if (!File.Exists(FileName)) return new ContextSettings();
			using (FileStream fs = new FileStream(FileName, FileMode.Open)) {
				return (ContextSettings)formatter.Deserialize(fs);
			}
		}
		public override string ToString()
		{
			if (string.IsNullOrEmpty(Source) || string.IsNullOrEmpty(Catalog)) return "CRMDBConnectionString";
            return string.Format("Data Source={0};Initial Catalog={1};user={2};password={3}", Source, Catalog, User, Password);
		}
	}
}
