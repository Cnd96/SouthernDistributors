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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvstockView = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbStockSelect = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstockView
            // 
            this.dgvstockView.AllowUserToAddRows = false;
            this.dgvstockView.AllowUserToDeleteRows = false;
            this.dgvstockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstockView.Location = new System.Drawing.Point(86, 282);
            this.dgvstockView.Name = "dgvstockView";
            this.dgvstockView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstockView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvstockView.RowHeadersVisible = false;
            this.dgvstockView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvstockView.RowTemplate.Height = 24;
            this.dgvstockView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstockView.Size = new System.Drawing.Size(938, 425);
            this.dgvstockView.TabIndex = 0;
            this.dgvstockView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstockView_CellDoubleClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(87, 245);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(208, 25);
            this.lblSearch.TabIndex = 111;
            this.lblSearch.Text = "Search By Item Name:";
            // 
            // cmbStockSelect
            // 
            this.cmbStockSelect.FormattingEnabled = true;
            this.cmbStockSelect.Location = new System.Drawing.Point(316, 246);
            this.cmbStockSelect.Name = "cmbStockSelect";
            this.cmbStockSelect.Size = new System.Drawing.Size(237, 24);
            this.cmbStockSelect.TabIndex = 110;
            this.cmbStockSelect.TextChanged += new System.EventHandler(this.cmbStockSelect_TextChanged);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Teal;
            this.lblOrder.Location = new System.Drawing.Point(74, 71);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(337, 96);
            this.lblOrder.TabIndex = 178;
            this.lblOrder.Text = "STOCKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 21);
            this.label1.TabIndex = 179;
            this.label1.Text = "i. Double click on relevant stock details to update";
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1092, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbStockSelect);
            this.Controls.Add(this.dgvstockView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStocks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStocks";
            this.Load += new System.EventHandler(this.frmStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstockView;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbStockSelect;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
    }
}