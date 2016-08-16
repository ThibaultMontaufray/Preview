using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tools4Libraries
{
    public partial class window_jarvis : Form
    {
        #region Attribute
        private bool allowMoveWindow;
        private int offsetX;
        private int offsetY;
        #endregion
        
        #region Constructor
        public window_jarvis()
        {
            InitializeComponent();
            allowMoveWindow = false;
        }
        #endregion

        #region Event
        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            if (!allowMoveWindow)
            {
                allowMoveWindow = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }
        private void panelHead_MouseUp(object sender, MouseEventArgs e)
        {
            allowMoveWindow = false;
        }
        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowMoveWindow)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }
        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (!allowMoveWindow)
            {
                allowMoveWindow = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }
        private void labelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            allowMoveWindow = false;
        }
        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowMoveWindow)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
