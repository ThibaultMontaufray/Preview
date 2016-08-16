// LOG CODE 99 01
using System;
using System.IO;
using System.Collections.Generic;

namespace Tools4Libraries
{
	public class AppliParams
	{
        // TODO : change the class in static singleton
		#region Attributes
		private string dicoPath;
		private string cryptoPath;
		private string configPath;
		private string languagePath;
        private string videoPath;
		private string logPath;
		private string musicPath;
        private string curLang = "en-US";
        private List<string> listModules;
		#endregion
		
		#region Properties
        public string MusicPath
        {
            get
            {
                if (musicPath == null)
                {
                    try
                    {
                        if (Directory.GetFiles(@"C:\Users\Default\Music\").Length > 0) musicPath = @"C:\Users\Default\Music";
                        else if (Directory.GetFiles(@"C:\Users\user\Music\").Length > 0) musicPath = @"C:\Users\user\Music\";
                    }
                    catch (Exception exp9901)
                    {
                        Log.write("[ WRN : 9901 ] no default music folder found.\n" + exp9901.Message);
                    }
                }
                return musicPath;
            }
            set
            {
                if (value == null)
                {
                    try
                    {
                        if (Directory.GetFiles(@"C:\Users\Default\Music\").Length > 0) musicPath = @"C:\Users\Default\Music";
                        else if (Directory.GetFiles(@"C:\Users\user\Music\").Length > 0) musicPath = @"C:\Users\user\Music\";
                    }
                    catch (Exception exp9901)
                    {
                        Log.write("[ WRN : 9901 ] no default music folder found.\n" + exp9901.Message);
                    }
                }
                else musicPath = value;
            }
        }
        public string VideoPath
        {
            get
            {
                if (videoPath == null)
                {
                    try
                    {
                        if (Directory.GetFiles(@"C:\Users\Default\Videos\").Length > 0) videoPath = @"C:\Users\Default\Videos\";
                        else if (Directory.GetFiles(@"C:\Users\user\Videos\").Length > 0) videoPath = @"C:\Users\user\Videos\";
                    }
                    catch (Exception exp9901)
                    {
                        Log.write("[ WRN : 9901 ] no default video folder found.\n" + exp9901.Message);
                    }
                }
                return videoPath;
            }
            set
            {
                if (value == null)
                {
                    try
                    {
                        if (Directory.GetFiles(@"C:\Users\Default\Videos\").Length > 0) musicPath = @"C:\Users\Default\Videos\";
                        else if (Directory.GetFiles(@"C:\Users\user\Videos\").Length > 0) musicPath = @"C:\Users\user\Videos\";
                    }
                    catch (Exception exp9901)
                    {
                        Log.write("[ WRN : 9901 ] no default videos folder found.\n" + exp9901.Message);
                    }
                }
                else videoPath = value;
            }
        }
        public string LogPath
		{
			get { return logPath; }
			set { logPath = value; }
		}
		public string DicoPath
		{
			get { return dicoPath; }
			set { dicoPath = value; }
		}
		public string CryptoPath
		{
			get { return cryptoPath; }
			set { cryptoPath = value; }
		}
		public string ConfigPath
		{
			get { return configPath; }
			set { configPath = value; }
		}
		public string LanguagePath
		{
			get { return languagePath; }
			set { languagePath = value; }
		}
        public string Language
        {
            get { return curLang; }
            set { curLang = value; }
        }
        public List<string> ListModules
        {
            get
            {
                if (listModules == null) listModules = new List<string>();
                return listModules;
            }
            set
            {
                if (listModules == null) listModules = new List<string>();
                listModules = value;
            }
        }
		#endregion
		
		#region Constructor
		public AppliParams()
		{
			LogPath = Environment.CurrentDirectory + @"\Log\";
			ConfigPath = Environment.CurrentDirectory + @"\Config\";
		}
		#endregion
		
		#region Methods
		public void CreateAppliPlateform()
		{
			try
			{
				// directory construction
				if (!Directory.Exists(ConfigPath))
				{
					ConfigPath = Environment.CurrentDirectory + @"\Config\";
					Directory.CreateDirectory(ConfigPath);
//					if (Environment.CurrentDirectory..Contains("Config"))
//					{
//						AppliParams.ConfigPath = Environment.CurrentDirectory;
//						Directory.CreateDirectory(AppliParams.ConfigPath);
//					}
//					else
//					{
//						AppliParams.ConfigPath = @"C:\Program Files\DaddyMummy\Config\";
//						Directory.CreateDirectory(AppliParams.ConfigPath);
//					}
				}
				if (!Directory.Exists(CryptoPath))
				{
					CryptoPath = Environment.CurrentDirectory + @"\Crypto\";
					Directory.CreateDirectory(CryptoPath);
				}
				if (!Directory.Exists(DicoPath))
				{
					DicoPath = Environment.CurrentDirectory + @"\Dico\";
					Directory.CreateDirectory(DicoPath);
				}
				if (!Directory.Exists(LanguagePath))
				{
					LanguagePath = Environment.CurrentDirectory + @"\Language\";
					Directory.CreateDirectory(LanguagePath);
				}
				if (!Directory.Exists(LogPath))
				{
					LogPath = Environment.CurrentDirectory + @"\Log\";
					Directory.CreateDirectory(LogPath);
				}
				
				// files construction
				if (!File.Exists(ConfigPath + "userconfig.conf"))
				{
					// nothing to do
				}
				if (!File.Exists(CryptoPath + "Dico_english.txt"))
				{
					// nothing to do
				}
				if (!File.Exists(DicoPath + "CBAE 4.05.xml"))
				{
					// nothing to do
				}
				if (!File.Exists(LanguagePath + "Language_GUI.xml"))
				{
					// nothing to do
				}
				if (!File.Exists(LogPath + "application.log"))
				{
					// nothing to do
				}
			}
			catch (Exception exp9900)
			{
				Log.write("[ ERR : 9900 ] cannot create the plateform for you're application.\n" + exp9900.Message);
			}
		}
		#endregion
	}
}
