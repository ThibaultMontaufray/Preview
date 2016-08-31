using System;
using System.Drawing;
using System.Windows.Forms;

namespace GAMES
{
    public partial class CheckersForm : UserControl
    {
        #region Attribute
        private Checkers _checkers;
        private DataGridViewCell _cellTemplate;
        private Pion _currentPion;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageListPion;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public CheckersForm()
        {
            InitializeComponent();
            _cellTemplate = new DataGridViewImageCell();

            _checkers = new Checkers();
            UpdateMap();
        }
        #endregion

        #region Methods private
        private void UpdateMap()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.SelectionChanged -= new EventHandler(dataGridView1_SelectionChanged);
            
            _checkers.Rafraichir_carte();
            for (int i = 0; i < _checkers.Largeur; i++) { dataGridView1.Columns.Add(new DataGridViewColumn(_cellTemplate) { DefaultCellStyle = new DataGridViewCellStyle() { NullValue = null }, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }); }
            for (int i = 0; i < _checkers.Hauteur; i++) { dataGridView1.Rows.Add(new DataGridViewRow() { Height = dataGridView1.Height / _checkers.Hauteur }); }

            CleanMapColor();
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
        }
        private void CleanMapColor()
        {
            bool color = false;
            for (int i = 0; i < _checkers.Hauteur; i++)
            {
                color = !color;
                for (int j = 0; j < _checkers.Largeur; j++)
                {
                    color = !color;
                    dataGridView1.Rows[j].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Rows[j].Cells[i].Style.SelectionForeColor = Color.Red;
                    dataGridView1.Rows[j].Cells[i].Style.SelectionBackColor = color ? Color.LightGray : Color.White;
                    dataGridView1.Rows[j].Cells[i].Style.BackColor = color ? Color.LightGray : Color.White;
                    if (_checkers.Carte[i, j] != null && _checkers.Carte[i, j].Equals("X")) dataGridView1.Rows[j].Cells[i].Value = imageListPion.Images[imageListPion.Images.IndexOfKey("noir")];
                    else if (_checkers.Carte[i, j] != null && _checkers.Carte[i, j].Equals("O")) dataGridView1.Rows[j].Cells[i].Value = imageListPion.Images[imageListPion.Images.IndexOfKey("blanc")];
                }
            }
        }
        private void ShowDeplacement()
        {
            CleanMapColor();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (var coord in _currentPion.Deplacements)
                {
                    if (coord["type"].Equals((int)Pion.TYPE.ATTAQUE)) dataGridView1.Rows[coord["y"]].Cells[coord["x"]].Style.BackColor = Color.Red;
                    else dataGridView1.Rows[coord["y"]].Cells[coord["x"]].Style.BackColor = Color.Orange;
                }
            }
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckersForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageListPion = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(294, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageListPion
            // 
            this.imageListPion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPion.ImageStream")));
            this.imageListPion.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPion.Images.SetKeyName(0, "blanc");
            this.imageListPion.Images.SetKeyName(1, "jaune");
            this.imageListPion.Images.SetKeyName(2, "orange");
            this.imageListPion.Images.SetKeyName(3, "rouge");
            this.imageListPion.Images.SetKeyName(4, "bleu");
            this.imageListPion.Images.SetKeyName(5, "vert");
            this.imageListPion.Images.SetKeyName(6, "noir");
            // 
            // CheckersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckersForm";
            this.Text = "Checkers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Methods protected
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Methods public
        #endregion

        #region Event
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (dataGridView1.SelectedCells[0].Style.BackColor == Color.Orange)
                {
                    _checkers.ACTION_Deplacer_pion(_currentPion, dataGridView1.SelectedCells[0].ColumnIndex, dataGridView1.SelectedCells[0].RowIndex);
                    UpdateMap();
                }
                else if (dataGridView1.SelectedCells[0].Style.BackColor == Color.Red)
                {
                    _checkers.ACTION_Attaquer_pion(_currentPion, dataGridView1.SelectedCells[0].ColumnIndex, dataGridView1.SelectedCells[0].RowIndex);
                    UpdateMap();
                }
                else
                {
                    _currentPion = _checkers.Selectionner_pion(dataGridView1.SelectedCells[0].ColumnIndex, dataGridView1.SelectedCells[0].RowIndex);
                    ShowDeplacement();
                }
            }
        }
        #endregion
    }
}
