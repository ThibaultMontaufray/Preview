/*
 * Created by SharpDevelop.
 * User: C357555
 * Date: 26/10/2011
 * Time: 14:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Tools4Libraries
{
	/// <summary>
	/// Description of ToolStripMenuManager.
	/// </summary>
	public class ToolStripMenuManager
    {
		#region Attributes
		private Panel currentTabPage;
		//private RibbonTab ribbontab;
		#endregion
		
		#region Properties
		public Panel CurrentTabPage
		{
			get { return currentTabPage; }
			set { currentTabPage = value;}
		}
		
		//public RibbonTab RibbonTabMenu
		//{
		//	get { return ribbontab; }
		//	set { ribbontab = value; }
		//}
		#endregion
		
		#region Constructor
		public ToolStripMenuManager()
		{
			//this.Left = 330;	
		}
		#endregion
	}
}
