namespace Tools4Libraries
{
    partial class window_jarvis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window_jarvis));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopMiddle = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.textBoxMessageHolder = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.paneleftMiddle = new System.Windows.Forms.Panel();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelRightMiddle = new System.Windows.Forms.Panel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelBottomMiddle = new System.Windows.Forms.Panel();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelBottomRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(861, 20);
            this.panelTop.TabIndex = 18;
            // 
            // panelTopMiddle
            // 
            this.panelTopMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopMiddle.BackgroundImage")));
            this.panelTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopMiddle.Location = new System.Drawing.Point(20, 0);
            this.panelTopMiddle.Name = "panelTopMiddle";
            this.panelTopMiddle.Size = new System.Drawing.Size(700, 20);
            this.panelTopMiddle.TabIndex = 22;
            // 
            // panelTopRight
            // 
            this.panelTopRight.BackColor = System.Drawing.Color.Transparent;
            this.panelTopRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopRight.BackgroundImage")));
            this.panelTopRight.Controls.Add(this.textBoxMessageHolder);
            this.panelTopRight.Controls.Add(this.buttonClose);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(720, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(141, 20);
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
            this.panelTopLeft.Size = new System.Drawing.Size(20, 20);
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
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.paneleftMiddle);
            this.panelLeft.Controls.Add(this.panelBottomLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 20);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(20, 362);
            this.panelLeft.TabIndex = 20;
            // 
            // paneleftMiddle
            // 
            this.paneleftMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneleftMiddle.BackgroundImage")));
            this.paneleftMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneleftMiddle.Location = new System.Drawing.Point(0, 0);
            this.paneleftMiddle.Name = "paneleftMiddle";
            this.paneleftMiddle.Size = new System.Drawing.Size(20, 227);
            this.paneleftMiddle.TabIndex = 23;
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelBottomLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomLeft.BackgroundImage")));
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 227);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(20, 135);
            this.panelBottomLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.panelRightMiddle);
            this.panelRight.Controls.Add(this.panelBottomRight);
            this.panelRight.Location = new System.Drawing.Point(720, 20);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(141, 362);
            this.panelRight.TabIndex = 21;
            // 
            // panelRightMiddle
            // 
            this.panelRightMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRightMiddle.BackgroundImage")));
            this.panelRightMiddle.Location = new System.Drawing.Point(0, 0);
            this.panelRightMiddle.Name = "panelRightMiddle";
            this.panelRightMiddle.Size = new System.Drawing.Size(141, 227);
            this.panelRightMiddle.TabIndex = 2;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.panelBottomRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomRight.BackgroundImage")));
            this.panelBottomRight.Controls.Add(this.buttonMenu);
            this.panelBottomRight.Location = new System.Drawing.Point(0, 227);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(141, 135);
            this.panelBottomRight.TabIndex = 1;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenu.BackgroundImage")));
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(207)))), ((int)(((byte)(253)))));
            this.buttonMenu.Location = new System.Drawing.Point(39, 33);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(102, 102);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.panelMiddle.Location = new System.Drawing.Point(20, 20);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(700, 350);
            this.panelMiddle.TabIndex = 22;
            // 
            // panelBottomMiddle
            // 
            this.panelBottomMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottomMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomMiddle.BackgroundImage")));
            this.panelBottomMiddle.Location = new System.Drawing.Point(20, 247);
            this.panelBottomMiddle.Name = "panelBottomMiddle";
            this.panelBottomMiddle.Size = new System.Drawing.Size(700, 135);
            this.panelBottomMiddle.TabIndex = 2;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackColor = System.Drawing.Color.Maroon;
            this.pictureBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(397, 329);
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            // 
            // window_jarvis
            // 
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(861, 382);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottomMiddle);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(433, 246);
            this.Name = "window_jarvis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.panelTop.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelBottomRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelTopMiddle;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.TextBox textBoxMessageHolder;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelBottomLeft;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Panel panelBottomMiddle;
        private System.Windows.Forms.Panel paneleftMiddle;
        private System.Windows.Forms.Panel panelRightMiddle;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBoxMenu;

    }
}