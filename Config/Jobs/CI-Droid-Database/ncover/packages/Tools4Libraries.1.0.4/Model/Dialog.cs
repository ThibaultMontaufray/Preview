using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools4Libraries
{
    public static class Dialog
    {
        /// <summary>
        /// Push the message on the screen with the current dialog mode
        /// </summary>
        /// <param name="speak">sentence to said</param>
        public static void Push(string speak)
        {
            MessageBox.Show(speak, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Return a user input
        /// </summary>
        /// <returns>the text inserted by the user without modification</returns>
        public static string Get()
        {
            return "";
        }
    }
}
