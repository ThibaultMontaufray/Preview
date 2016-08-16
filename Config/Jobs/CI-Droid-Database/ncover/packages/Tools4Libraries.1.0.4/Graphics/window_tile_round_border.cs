using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tools4Libraries
{
    public partial class window_tile_round_border : Panel
    {
        #region Attribute
        private bool allowMoveWindow;
        private int offsetX;
        private int offsetY;
        #endregion

        #region Properties
        public System.Windows.Forms.Control.ControlCollection BodyControls
        {
            get { return panelMiddle.Controls; }
        }
        #endregion

        #region Constructor
        public window_tile_round_border()
        {
            InitializeComponent();
            allowMoveWindow = false;
        }
        #endregion

        #region Event
        #endregion
    }
}
