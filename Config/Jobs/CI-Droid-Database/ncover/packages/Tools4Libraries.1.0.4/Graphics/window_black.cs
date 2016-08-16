using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tools4Libraries
{
    public partial class window_black : Form
    {
        #region Attribute
        private bool allowMoveWindow;
        private int offsetX;
        private int offsetY;
        #endregion
        
        #region Constructor
        public window_black()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void AddControl(Control ctrl)
        {
            panelControl.Controls.Add(ctrl);
        }
        public void DelControl(Control ctrl)
        {
            panelControl.Controls.Remove(ctrl);
        }
        #endregion

        #region Methods private
        private void Init()
        {
            allowMoveWindow = false;
            this.KeyPress += window_black_KeyPress;
        }
        #endregion

        #region Event
        private void window_black_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keys k = (Keys)e.KeyChar;
            if (k.Equals(Keys.Escape))
            {
                this.Close();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        #endregion
    }
}
