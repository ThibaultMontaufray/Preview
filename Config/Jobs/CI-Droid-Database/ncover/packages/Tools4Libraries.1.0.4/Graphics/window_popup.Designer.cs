namespace Tools4Libraries
{
    partial class window_popup
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window_popup));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopMiddle = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.textBoxMessageHolder = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBottomMiddle = new System.Windows.Forms.Panel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.panelTopMiddle);
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Controls.Add(this.panelTopLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(433, 147);
            this.panelTop.TabIndex = 18;
            // 
            // panelTopMiddle
            // 
            this.panelTopMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopMiddle.BackgroundImage")));
            this.panelTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopMiddle.Location = new System.Drawing.Point(226, 0);
            this.panelTopMiddle.Name = "panelTopMiddle";
            this.panelTopMiddle.Size = new System.Drawing.Size(0, 147);
            this.panelTopMiddle.TabIndex = 22;
            // 
            // panelTopRight
            // 
            this.panelTopRight.BackColor = System.Drawing.Color.Transparent;
            this.panelTopRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopRight.BackgroundImage")));
            this.panelTopRight.Controls.Add(this.textBoxMessageHolder);
            this.panelTopRight.Controls.Add(this.buttonClose);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(223, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(210, 147);
            this.panelTopRight.TabIndex = 1;
            // 
            // textBoxMessageHolder
            // 
            this.textBoxMessageHolder.BackColor = System.Drawing.Color.Khaki;
            this.textBoxMessageHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessageHolder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessageHolder.Location = new System.Drawing.Point(0, 40);
            this.textBoxMessageHolder.Multiline = true;
            this.textBoxMessageHolder.Name = "textBoxMessageHolder";
            this.textBoxMessageHolder.ReadOnly = true;
            this.textBoxMessageHolder.Size = new System.Drawing.Size(164, 24);
            this.textBoxMessageHolder.TabIndex = 24;
            this.textBoxMessageHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMessageHolder.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(153, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 24);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelTopLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopLeft.BackgroundImage")));
            this.panelTopLeft.Controls.Add(this.labelTitle);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(226, 147);
            this.panelTopLeft.TabIndex = 23;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(39, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(33, 17);
            this.labelTitle.TabIndex = 24;
            this.labelTitle.Text = "Title";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.panelBottomMiddle);
            this.panelBottom.Controls.Add(this.panelBottomRight);
            this.panelBottom.Controls.Add(this.panelBottomLeft);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 139);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(433, 107);
            this.panelBottom.TabIndex = 19;
            // 
            // panelBottomMiddle
            // 
            this.panelBottomMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomMiddle.BackgroundImage")));
            this.panelBottomMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomMiddle.Location = new System.Drawing.Point(230, 0);
            this.panelBottomMiddle.Name = "panelBottomMiddle";
            this.panelBottomMiddle.Size = new System.Drawing.Size(0, 107);
            this.panelBottomMiddle.TabIndex = 2;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.panelBottomRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomRight.BackgroundImage")));
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBottomRight.Location = new System.Drawing.Point(229, 0);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(204, 107);
            this.panelBottomRight.TabIndex = 1;
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelBottomLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomLeft.BackgroundImage")));
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(230, 107);
            this.panelBottomLeft.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 147);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(108, 0);
            this.panelLeft.TabIndex = 20;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(286, 147);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(147, 0);
            this.panelRight.TabIndex = 21;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(108, 147);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(178, 0);
            this.panelMiddle.TabIndex = 22;
            // 
            // window_popup
            // 
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(433, 246);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(433, 246);
            this.Name = "window_popup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.panelTop.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Panel panelBottomLeft;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelTopMiddle;
        private System.Windows.Forms.Panel panelBottomMiddle;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.TextBox textBoxMessageHolder;

    }
}