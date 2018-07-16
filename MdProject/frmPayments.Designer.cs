﻿namespace MdProject
{
    partial class frmPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPaymentView = new System.Windows.Forms.DataGridView();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txtcusId = new System.Windows.Forms.TextBox();
            this.lblCreditValue = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lblAmountPaying = new System.Windows.Forms.Label();
            this.txtAmountPaying = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentView
            // 
            this.dgvPaymentView.AllowUserToAddRows = false;
            this.dgvPaymentView.AllowUserToDeleteRows = false;
            this.dgvPaymentView.AllowUserToResizeColumns = false;
            this.dgvPaymentView.AllowUserToResizeRows = false;
            this.dgvPaymentView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentView.Location = new System.Drawing.Point(94, 295);
            this.dgvPaymentView.Name = "dgvPaymentView";
            this.dgvPaymentView.ReadOnly = true;
            this.dgvPaymentView.RowHeadersVisible = false;
            this.dgvPaymentView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPaymentView.RowTemplate.Height = 24;
            this.dgvPaymentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentView.Size = new System.Drawing.Size(676, 308);
            this.dgvPaymentView.TabIndex = 10;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaymentId.Location = new System.Drawing.Point(1597, 295);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.ReadOnly = true;
            this.txtPaymentId.Size = new System.Drawing.Size(99, 22);
            this.txtPaymentId.TabIndex = 9;
            this.txtPaymentId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPaymentId_KeyUp);
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(1296, 295);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(198, 30);
            this.lblPayment.TabIndex = 178;
            this.lblPayment.Text = "Payment Id";
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCusName.Location = new System.Drawing.Point(1597, 362);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(244, 22);
            this.txtCusName.TabIndex = 1;
            this.txtCusName.TextChanged += new System.EventHandler(this.txtCusName_TextChanged);
            this.txtCusName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCusName_KeyUp);
            this.txtCusName.Leave += new System.EventHandler(this.txtCusName_Leave);
            // 
            // lblCusName
            // 
            this.lblCusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCusName.BackColor = System.Drawing.Color.Transparent;
            this.lblCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(1296, 362);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(244, 30);
            this.lblCusName.TabIndex = 178;
            this.lblCusName.Text = "Customer Name";
            // 
            // lblCusID
            // 
            this.lblCusID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCusID.BackColor = System.Drawing.Color.Transparent;
            this.lblCusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(1296, 429);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(222, 30);
            this.lblCusID.TabIndex = 178;
            this.lblCusID.Text = "Customer ID";
            // 
            // txtcusId
            // 
            this.txtcusId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcusId.Location = new System.Drawing.Point(1596, 429);
            this.txtcusId.Name = "txtcusId";
            this.txtcusId.ReadOnly = true;
            this.txtcusId.Size = new System.Drawing.Size(100, 22);
            this.txtcusId.TabIndex = 2;
            this.txtcusId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcusId_KeyUp);
            // 
            // lblCreditValue
            // 
            this.lblCreditValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreditValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditValue.Location = new System.Drawing.Point(1296, 514);
            this.lblCreditValue.Name = "lblCreditValue";
            this.lblCreditValue.Size = new System.Drawing.Size(222, 30);
            this.lblCreditValue.TabIndex = 178;
            this.lblCreditValue.Text = "Customer Credit Value";
            // 
            // txtCredit
            // 
            this.txtCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCredit.Location = new System.Drawing.Point(1596, 514);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.ReadOnly = true;
            this.txtCredit.Size = new System.Drawing.Size(100, 22);
            this.txtCredit.TabIndex = 3;
            this.txtCredit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCredit_KeyUp);
            // 
            // lblAmountPaying
            // 
            this.lblAmountPaying.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountPaying.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountPaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaying.Location = new System.Drawing.Point(1296, 596);
            this.lblAmountPaying.Name = "lblAmountPaying";
            this.lblAmountPaying.Size = new System.Drawing.Size(222, 30);
            this.lblAmountPaying.TabIndex = 178;
            this.lblAmountPaying.Text = "Amount Paying";
            // 
            // txtAmountPaying
            // 
            this.txtAmountPaying.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountPaying.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAmountPaying.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAmountPaying.Location = new System.Drawing.Point(1596, 596);
            this.txtAmountPaying.Name = "txtAmountPaying";
            this.txtAmountPaying.Size = new System.Drawing.Size(100, 22);
            this.txtAmountPaying.TabIndex = 4;
            this.txtAmountPaying.TextChanged += new System.EventHandler(this.txtAmountPaying_TextChanged);
            this.txtAmountPaying.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaying_KeyPress);
            this.txtAmountPaying.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountPaying_KeyUp);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1464, 722);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 179;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1734, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 183;
            this.lblDate.Text = "Date";
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtcusId);
            this.Controls.Add(this.txtAmountPaying);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtPaymentId);
            this.Controls.Add(this.lblAmountPaying);
            this.Controls.Add(this.lblCreditValue);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.dgvPaymentView);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.Name = "frmPayments";
            this.ShowIcon = false;
            this.Text = "Payments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaymentView;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtcusId;
        private System.Windows.Forms.Label lblCreditValue;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label lblAmountPaying;
        private System.Windows.Forms.TextBox txtAmountPaying;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDate;
    }
}