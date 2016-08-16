/*
 * Crée par SharpDevelop.
 * Utilisateur: C357555
 * Date: 05/08/2011
 * Heure: 18:27
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tools4Libraries
{
	/// <summary>
	/// Description of Droid.
	/// </summary>
	public class GPInterface
	{	
		#region Attributes
		private List<string> listvisiblecomponents = null;	
		private string pathFile;
		private string extention;
		private bool openned;
		#endregion
		
		#region Properties
		public string PathFile
		{
			get { return pathFile; }
			set { pathFile = value; }
		}
		
		public string Extention
		{
			get { return extention; }
			set { extention = value; }
		}
				
		public virtual bool Openned
		{
			get { return openned; }
			set { openned = value; }
		}
		
		public virtual List<string> Listvisiblecomponents
		{
			get { return listvisiblecomponents; }
		}
		
		#endregion
		
		#region Constructor / Destructor
		public GPInterface()
		{
			openned = false;
		}
		
		~GPInterface()
		{
			
		}
		#endregion
		
		#region Methods
        public virtual bool Open(object obj)
        {
            return false;
        }
        public virtual void Print()
		{
			
		}
		public virtual bool Save()
		{
			return false;
		}
		public virtual bool Save(object s)
		{
			return false;
		}
		public virtual void Close()
		{
			
		}
		public virtual void ZoomIn()
		{
			
		}
		public virtual void ZoomOut()
		{
			
		}
		public virtual void Copy()
		{
			
		}
		public virtual void Cut()
		{			
			
		}
		public virtual void Paste()
		{
			
		}
		public virtual void Resize()
		{
		
		}
		public virtual void Refresh()
		{
			
		}
		public virtual void GlobalAction(object sender, EventArgs e)
		{
			
		}
		#endregion
	}
}
