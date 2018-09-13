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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvsalesview = new System.Windows.Forms.DataGridView();
            this.dgvPaymentView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblCusCredit = new System.Windows.Forms.Label();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvReturnView = new System.Windows.Forms.DataGridView();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnView)).BeginInit();
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
            this.dgvsalesview.Location = new System.Drawing.Point(51, 214);
            this.dgvsalesview.Name = "dgvsalesview";
            this.dgvsalesview.ReadOnly = true;
            this.dgvsalesview.RowHeadersVisible = false;
            this.dgvsalesview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvsalesview.RowTemplate.Height = 24;
            this.dgvsalesview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsalesview.Size = new System.Drawing.Size(809, 335);
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
            this.dgvPaymentView.Location = new System.Drawing.Point(1232, 204);
            this.dgvPaymentView.Name = "dgvPaymentView";
            this.dgvPaymentView.ReadOnly = true;
            this.dgvPaymentView.RowHeadersVisible = false;
            this.dgvPaymentView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPaymentView.RowTemplate.Height = 24;
            this.dgvPaymentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentView.Size = new System.Drawing.Size(538, 345);
            this.dgvPaymentView.TabIndex = 182;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(71, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 25);
            this.label10.TabIndex = 183;
            this.label10.Text = "Search by Customer Name";
            // 
            // txtCusName
            // 
            this.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCusName.Location = new System.Drawing.Point(367, 174);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(244, 22);
            this.txtCusName.TabIndex = 184;
            this.txtCusName.Leave += new System.EventHandler(this.txtCusName_Leave);
            // 
            // lblCusCredit
            // 
            this.lblCusCredit.AutoSize = true;
            this.lblCusCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusCredit.Location = new System.Drawing.Point(910, 338);
            this.lblCusCredit.Name = "lblCusCredit";
            this.lblCusCredit.Size = new System.Drawing.Size(120, 25);
            this.lblCusCredit.TabIndex = 185;
            this.lblCusCredit.Text = "Credit Value";
            // 
            // txtcredit
            // 
            this.txtcredit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcredit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcredit.Location = new System.Drawing.Point(1057, 341);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(126, 22);
            this.txtcredit.TabIndex = 184;
            this.txtcredit.Leave += new System.EventHandler(this.txtCusName_Leave);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(1371, 725);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(281, 140);
            this.btnReport.TabIndex = 186;
            this.btnReport.Text = "Report on Credit Customers";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvReturnView
            // 
            this.dgvReturnView.AllowUserToAddRows = false;
            this.dgvReturnView.AllowUserToDeleteRows = false;
            this.dgvReturnView.AllowUserToResizeColumns = false;
            this.dgvReturnView.AllowUserToResizeRows = false;
            this.dgvReturnView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturnView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnView.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvReturnView.Location = new System.Drawing.Point(51, 616);
            this.dgvReturnView.Name = "dgvReturnView";
            this.dgvReturnView.ReadOnly = true;
            this.dgvReturnView.RowHeadersVisible = false;
            this.dgvReturnView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReturnView.RowTemplate.Height = 24;
            this.dgvReturnView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnView.Size = new System.Drawing.Size(956, 335);
            this.dgvReturnView.TabIndex = 187;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Teal;
            this.lblOrder.Location = new System.Drawing.Point(112, 40);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(825, 96);
            this.lblOrder.TabIndex = 188;
            this.lblOrder.Text = "CUSTOMER REPORTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 189;
            this.label1.Text = "Customer Returns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1229, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 190;
            this.label2.Text = "Customer Payment:";
            // 
            // frmCustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.dgvReturnView);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnView)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvReturnView;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}