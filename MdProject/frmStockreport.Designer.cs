namespace MdProject
{
    partial class frmStockreport
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbStockSelect = new System.Windows.Forms.ComboBox();
            this.lblexpiredate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReportExpDate = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstockView
            // 
            this.dgvstockView.AllowUserToAddRows = false;
            this.dgvstockView.AllowUserToDeleteRows = false;
            this.dgvstockView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvstockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstockView.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvstockView.Location = new System.Drawing.Point(44, 246);
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
            this.dgvstockView.Size = new System.Drawing.Size(954, 348);
            this.dgvstockView.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(56, 195);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(202, 25);
            this.lblSearch.TabIndex = 113;
            this.lblSearch.Text = "Search By Item Name";
            // 
            // cmbStockSelect
            // 
            this.cmbStockSelect.FormattingEnabled = true;
            this.cmbStockSelect.Location = new System.Drawing.Point(276, 198);
            this.cmbStockSelect.Name = "cmbStockSelect";
            this.cmbStockSelect.Size = new System.Drawing.Size(237, 24);
            this.cmbStockSelect.TabIndex = 112;
            this.cmbStockSelect.TextChanged += new System.EventHandler(this.cmbStockSelect_TextChanged);
            // 
            // lblexpiredate
            // 
            this.lblexpiredate.AutoSize = true;
            this.lblexpiredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpiredate.Location = new System.Drawing.Point(43, 634);
            this.lblexpiredate.Name = "lblexpiredate";
            this.lblexpiredate.Size = new System.Drawing.Size(129, 25);
            this.lblexpiredate.TabIndex = 114;
            this.lblexpiredate.Text = "Expire Before";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 637);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 115;
            // 
            // btnReportExpDate
            // 
            this.btnReportExpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnReportExpDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportExpDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportExpDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportExpDate.Location = new System.Drawing.Point(818, 634);
            this.btnReportExpDate.Name = "btnReportExpDate";
            this.btnReportExpDate.Size = new System.Drawing.Size(180, 60);
            this.btnReportExpDate.TabIndex = 116;
            this.btnReportExpDate.Text = "Report";
            this.btnReportExpDate.UseVisualStyleBackColor = false;
            this.btnReportExpDate.Click += new System.EventHandler(this.btnReportExpDate_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Teal;
            this.lblOrder.Location = new System.Drawing.Point(60, 51);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(652, 96);
            this.lblOrder.TabIndex = 178;
            this.lblOrder.Text = "STOCKS REPORT";
            // 
            // frmStockreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1089, 737);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnReportExpDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblexpiredate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbStockSelect);
            this.Controls.Add(this.dgvstockView);
            this.MaximizeBox = false;
            this.Name = "frmStockreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStockreport";
            this.Load += new System.EventHandler(this.frmStockreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstockView;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbStockSelect;
        private System.Windows.Forms.Label lblexpiredate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReportExpDate;
        private System.Windows.Forms.Label lblOrder;
    }
}