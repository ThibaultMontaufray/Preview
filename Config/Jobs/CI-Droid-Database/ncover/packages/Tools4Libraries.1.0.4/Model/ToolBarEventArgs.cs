
using System;
using System.Windows.Forms;

namespace Tools4Libraries
{
	/// <summary>
	/// Description of ToolBarEventArgs.
	/// </summary>
	public delegate void EventHandlerAction(object sender, EventArgs e); 
	
	public class ToolBarEventArgs : EventArgs
	{
		#region Attributes
		private string EventAction = null;		
		#endregion
				
		#region Properties	
		public string EventText
		{
			get { return this.EventAction; }
		}	
		#endregion
		
		#region Methods
		public ToolBarEventArgs(string EventText)
		{			
			if (EventText == null) throw new NullReferenceException();
			EventAction = EventText; 
		}
		#endregion
	}

}
