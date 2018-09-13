namespace MdProject
{
    partial class frmSalesReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvsalesview = new System.Windows.Forms.DataGridView();
            this.txtSalesId = new System.Windows.Forms.TextBox();
            this.lblSalesId = new System.Windows.Forms.Label();
            this.lblsalesmonth = new System.Windows.Forms.Label();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.btnReportMonth = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsalesview
            // 
            this.dgvsalesview.AllowUserToAddRows = false;
            this.dgvsalesview.AllowUserToDeleteRows = false;
            this.dgvsalesview.AllowUserToResizeColumns = false;
            this.dgvsalesview.AllowUserToResizeRows = false;
            this.dgvsalesview.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsalesview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvsalesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesview.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvsalesview.Location = new System.Drawing.Point(44, 224);
            this.dgvsalesview.Name = "dgvsalesview";
            this.dgvsalesview.ReadOnly = true;
            this.dgvsalesview.RowHeadersVisible = false;
            this.dgvsalesview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvsalesview.RowTemplate.Height = 24;
            this.dgvsalesview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsalesview.Size = new System.Drawing.Size(963, 259);
            this.dgvsalesview.TabIndex = 181;
            this.dgvsalesview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalesview_CellDoubleClick);
            // 
            // txtSalesId
            // 
            this.txtSalesId.Location = new System.Drawing.Point(174, 183);
            this.txtSalesId.Name = "txtSalesId";
            this.txtSalesId.Size = new System.Drawing.Size(145, 22);
            this.txtSalesId.TabIndex = 183;
            this.txtSalesId.TextChanged += new System.EventHandler(this.txtSalesId_TextChanged);
            // 
            // lblSalesId
            // 
            this.lblSalesId.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesId.Location = new System.Drawing.Point(50, 183);
            this.lblSalesId.Name = "lblSalesId";
            this.lblSalesId.Size = new System.Drawing.Size(103, 30);
            this.lblSalesId.TabIndex = 182;
            this.lblSalesId.Text = "Sales ID             ";
            // 
            // lblsalesmonth
            // 
            this.lblsalesmonth.BackColor = System.Drawing.Color.Transparent;
            this.lblsalesmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalesmonth.Location = new System.Drawing.Point(51, 497);
            this.lblsalesmonth.Name = "lblsalesmonth";
            this.lblsalesmonth.Size = new System.Drawing.Size(183, 30);
            this.lblsalesmonth.TabIndex = 182;
            this.lblsalesmonth.Text = "Sales on Month";
            // 
            // cmbmonth
            // 
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octomber",
            "November",
            "December"});
            this.cmbmonth.Location = new System.Drawing.Point(240, 497);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(121, 24);
            this.cmbmonth.TabIndex = 184;
            // 
            // btnReportMonth
            // 
            this.btnReportMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportMonth.Location = new System.Drawing.Point(827, 497);
            this.btnReportMonth.Name = "btnReportMonth";
            this.btnReportMonth.Size = new System.Drawing.Size(180, 60);
            this.btnReportMonth.TabIndex = 185;
            this.btnReportMonth.Text = "Get Report";
            this.btnReportMonth.UseVisualStyleBackColor = false;
            this.btnReportMonth.Click += new System.EventHandler(this.btnReportMonth_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Teal;
            this.lblOrder.Location = new System.Drawing.Point(50, 25);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(572, 96);
            this.lblOrder.TabIndex = 186;
            this.lblOrder.Text = "SALES REPORT";
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1048, 614);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnReportMonth);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.txtSalesId);
            this.Controls.Add(this.lblsalesmonth);
            this.Controls.Add(this.lblSalesId);
            this.Controls.Add(this.dgvsalesview);
            this.Name = "frmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesReport";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsalesview;
        private System.Windows.Forms.TextBox txtSalesId;
        private System.Windows.Forms.Label lblSalesId;
        private System.Windows.Forms.Label lblsalesmonth;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.Button btnReportMonth;
        private System.Windows.Forms.Label lblOrder;
    }
}