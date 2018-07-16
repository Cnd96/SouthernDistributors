namespace MdProject
{
    partial class frmStocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvstockView = new System.Windows.Forms.DataGridView();
            this.cmbStockSelect = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstockView
            // 
            this.dgvstockView.AllowUserToAddRows = false;
            this.dgvstockView.AllowUserToDeleteRows = false;
            this.dgvstockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstockView.Location = new System.Drawing.Point(450, 299);
            this.dgvstockView.Name = "dgvstockView";
            this.dgvstockView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstockView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvstockView.RowHeadersVisible = false;
            this.dgvstockView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvstockView.RowTemplate.Height = 24;
            this.dgvstockView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstockView.Size = new System.Drawing.Size(938, 348);
            this.dgvstockView.TabIndex = 0;
            this.dgvstockView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstockView_CellDoubleClick);
            // 
            // cmbStockSelect
            // 
            this.cmbStockSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbStockSelect.FormattingEnabled = true;
            this.cmbStockSelect.Location = new System.Drawing.Point(622, 149);
            this.cmbStockSelect.Name = "cmbStockSelect";
            this.cmbStockSelect.Size = new System.Drawing.Size(237, 24);
            this.cmbStockSelect.TabIndex = 110;
            this.cmbStockSelect.TextChanged += new System.EventHandler(this.cmbStockSelect_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(436, 152);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(144, 17);
            this.lblSearch.TabIndex = 111;
            this.lblSearch.Text = "Search By Item Name";
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbStockSelect);
            this.Controls.Add(this.dgvstockView);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.Name = "frmStocks";
            this.ShowIcon = false;
            this.Text = "frmStocks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstockView;
        private System.Windows.Forms.ComboBox cmbStockSelect;
        private System.Windows.Forms.Label lblSearch;
    }
}