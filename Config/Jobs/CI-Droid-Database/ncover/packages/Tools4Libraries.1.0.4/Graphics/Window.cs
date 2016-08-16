using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tools4Libraries
{
    public partial class Window : window_black
    {
        public override string Text
        {
            get { return labelTitle != null ? labelTitle.Text : string.Empty; }
            set { labelTitle.Text = value; }
        }

        public Window()
        {
            InitializeComponent();
        }
    }
}
