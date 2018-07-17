namespace MdProject
{
    partial class frmCustomerReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvsalesview = new System.Windows.Forms.DataGridView();
            this.dgvPaymentView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblCusCredit = new System.Windows.Forms.Label();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsalesview
            // 
            this.dgvsalesview.AllowUserToAddRows = false;
            this.dgvsalesview.AllowUserToDeleteRows = false;
            this.dgvsalesview.AllowUserToResizeColumns = false;
            this.dgvsalesview.AllowUserToResizeRows = false;
            this.dgvsalesview.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsalesview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsalesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesview.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvsalesview.Location = new System.Drawing.Point(470, 267);
            this.dgvsalesview.Name = "dgvsalesview";
            this.dgvsalesview.ReadOnly = true;
            this.dgvsalesview.RowHeadersVisible = false;
            this.dgvsalesview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvsalesview.RowTemplate.Height = 24;
            this.dgvsalesview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsalesview.Size = new System.Drawing.Size(809, 246);
            this.dgvsalesview.TabIndex = 181;
            // 
            // dgvPaymentView
            // 
            this.dgvPaymentView.AllowUserToAddRows = false;
            this.dgvPaymentView.AllowUserToDeleteRows = false;
            this.dgvPaymentView.AllowUserToResizeColumns = false;
            this.dgvPaymentView.AllowUserToResizeRows = false;
            this.dgvPaymentView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentView.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPaymentView.Location = new System.Drawing.Point(470, 519);
            this.dgvPaymentView.Name = "dgvPaymentView";
            this.dgvPaymentView.ReadOnly = true;
            this.dgvPaymentView.RowHeadersVisible = false;
            this.dgvPaymentView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPaymentView.RowTemplate.Height = 24;
            this.dgvPaymentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentView.Size = new System.Drawing.Size(538, 219);
            this.dgvPaymentView.TabIndex = 182;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(466, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 20);
            this.label10.TabIndex = 183;
            this.label10.Text = "Search by Customer Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCusName.Location = new System.Drawing.Point(707, 127);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(244, 22);
            this.txtCusName.TabIndex = 184;
            this.txtCusName.Leave += new System.EventHandler(this.txtCusName_Leave);
            // 
            // lblCusCredit
            // 
            this.lblCusCredit.AutoSize = true;
            this.lblCusCredit.Location = new System.Drawing.Point(1177, 597);
            this.lblCusCredit.Name = "lblCusCredit";
            this.lblCusCredit.Size = new System.Drawing.Size(85, 17);
            this.lblCusCredit.TabIndex = 185;
            this.lblCusCredit.Text = "Credit Value";
            // 
            // txtcredit
            // 
            this.txtcredit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcredit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcredit.Location = new System.Drawing.Point(1277, 597);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(126, 22);
            this.txtcredit.TabIndex = 184;
            this.txtcredit.Leave += new System.EventHandler(this.txtCusName_Leave);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(847, 860);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(190, 47);
            this.btnReport.TabIndex = 186;
            this.btnReport.Text = "Report on Credit Customers";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmCustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblCusCredit);
            this.Controls.Add(this.txtcredit);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPaymentView);
            this.Controls.Add(this.dgvsalesview);
            this.Name = "frmCustomerReports";
            this.ShowIcon = false;
            this.Text = "Customer Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsalesview;
        private System.Windows.Forms.DataGridView dgvPaymentView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblCusCredit;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Button btnReport;
    }
}