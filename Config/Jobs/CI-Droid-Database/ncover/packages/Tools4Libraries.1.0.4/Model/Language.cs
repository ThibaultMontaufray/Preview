// log code 13

using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Xml;
using System.Xml.XPath;
using System.Collections.Generic;

namespace Tools4Libraries
{
	/// <summary>
	/// Description of Language.
	/// </summary>
	public class Language
	{
		#region Attribute
		private List<string> List_index;
		private List<string> List_fr;
		private List<string> List_en;
		private List<string> List_esp;
		private List<string> List_it;
		private List<string> List_de;
        private string lang;
        private string module;
		private string path;
		#endregion
		
		#region Properties
		#endregion
		
		#region Constructor
		public Language(string pathlanguage)
		{
			module = "GUI";
			path = pathlanguage;
			
			List_index = new List<string>();
			List_fr = new List<string>();
			List_en = new List<string>();
			List_esp = new List<string>();
			List_it = new List<string>();
			List_de = new List<string>();
			
			LoadLanguageList();
		}
		#endregion
		
		#region Methods		
		private void LoadLanguageList()
		{
			if (File.Exists(path + "Language_" + module + ".xml"))
   			{
	            try
	            {
					XmlDocument xml = new XmlDocument();
					xml.Load(path + "Language_" + module + ".xml");
					
					XmlNodeList  rootelement = xml.GetElementsByTagName("class");
					foreach (XmlNode element in rootelement)
					{
						XmlNodeList xnl = element.ChildNodes;
						foreach (XmlNode e in xnl) 
						{
							List_index.Add(e.Attributes.GetNamedItem("name").Value);
							List_fr.Add(e.Attributes.GetNamedItem("name").Value + "|" + e.Attributes.GetNamedItem("french").Value);
							List_en.Add(e.Attributes.GetNamedItem("name").Value + "|" + e.Attributes.GetNamedItem("english").Value);
							List_it.Add(e.Attributes.GetNamedItem("name").Value + "|" + e.Attributes.GetNamedItem("italian").Value);
							List_esp.Add(e.Attributes.GetNamedItem("name").Value + "|" + e.Attributes.GetNamedItem("spanish").Value);
							List_de.Add(e.Attributes.GetNamedItem("name").Value + "|" + e.Attributes.GetNamedItem("deutsch").Value);
						}
					}
	            }
	            catch (Exception exp1300)
	            {
	            	Console.WriteLine(" [ WRN : 1300 ] Cannot open the language dictionnarty.\n" + exp1300.Message);
	            }
			}
		}
		
		public string GetText(string lg, string name, string defVal)
		{
			int index = 0;
			foreach (string element in List_index) 
			{
				if(element.Equals(name))
				{
					try
					{
						switch (lg) 
						{
							case "fr": 
								return !string.IsNullOrEmpty(((List_fr[index]).Split('|'))[1])?((List_fr[index]).Split('|'))[1]:defVal;
							case "en": 
							case "ca":
							case "irl":
							case "usa":
							case "au":    
								return !string.IsNullOrEmpty(((List_en[index]).Split('|'))[1])?((List_en[index]).Split('|'))[1]:defVal;
							case "esp": 
							case "mx": 
								return !string.IsNullOrEmpty(((List_esp[index]).Split('|'))[1])?((List_esp[index]).Split('|'))[1]:defVal;
							case "it": 
								return !string.IsNullOrEmpty(((List_it[index]).Split('|'))[1])?((List_it[index]).Split('|'))[1]:defVal;
							case "de": 
								return !string.IsNullOrEmpty(((List_de[index]).Split('|'))[1])?((List_de[index]).Split('|'))[1]:defVal;
						}
					}
					catch
					{
						return defVal;
					}
				}
				index++;
			}
			return defVal;
		}
		#endregion
	}
}
