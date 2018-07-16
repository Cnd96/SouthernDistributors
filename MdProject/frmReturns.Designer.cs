namespace MdProject
{
    partial class frmReturns
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
            this.components = new System.ComponentModel.Container();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IIDlbl = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblAmountPurchased = new System.Windows.Forms.Label();
            this.lblDiscountItems = new System.Windows.Forms.Label();
            this.txtAmountpurchased = new System.Windows.Forms.TextBox();
            this.txtFreeItems = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtdiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblQuantityReturning = new System.Windows.Forms.Label();
            this.txtQuantityReturn = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.txtReturnId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtCreditValue = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(593, 225);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(82, 20);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 33);
            this.label6.TabIndex = 176;
            this.label6.Text = "Batch ID             ";
            // 
            // IIDlbl
            // 
            this.IIDlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.IIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IIDlbl.Location = new System.Drawing.Point(593, 277);
            this.IIDlbl.Name = "IIDlbl";
            this.IIDlbl.Size = new System.Drawing.Size(170, 28);
            this.IIDlbl.TabIndex = 175;
            this.IIDlbl.Text = "Item ID              ";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderId.Location = new System.Drawing.Point(776, 223);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 22);
            this.txtOrderId.TabIndex = 1;
            // 
            // txtItemId
            // 
            this.txtItemId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemId.Location = new System.Drawing.Point(776, 277);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(100, 22);
            this.txtItemId.TabIndex = 2;
            // 
            // txtBatchID
            // 
            this.txtBatchID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBatchID.Location = new System.Drawing.Point(776, 322);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(100, 22);
            this.txtBatchID.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.Location = new System.Drawing.Point(913, 331);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCustomerId.Location = new System.Drawing.Point(801, 455);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(136, 22);
            this.txtCustomerId.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 180;
            this.label1.Text = "Customer Name         ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 179;
            this.label2.Text = "Customer ID               ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerName.Location = new System.Drawing.Point(801, 525);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(136, 22);
            this.txtCustomerName.TabIndex = 181;
            // 
            // lblAmountPurchased
            // 
            this.lblAmountPurchased.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountPurchased.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPurchased.Location = new System.Drawing.Point(554, 646);
            this.lblAmountPurchased.Name = "lblAmountPurchased";
            this.lblAmountPurchased.Size = new System.Drawing.Size(204, 30);
            this.lblAmountPurchased.TabIndex = 180;
            this.lblAmountPurchased.Text = "Amount Purchased";
            // 
            // lblDiscountItems
            // 
            this.lblDiscountItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscountItems.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountItems.Location = new System.Drawing.Point(554, 718);
            this.lblDiscountItems.Name = "lblDiscountItems";
            this.lblDiscountItems.Size = new System.Drawing.Size(204, 30);
            this.lblDiscountItems.TabIndex = 180;
            this.lblDiscountItems.Text = "Free Items";
            // 
            // txtAmountpurchased
            // 
            this.txtAmountpurchased.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountpurchased.Location = new System.Drawing.Point(801, 646);
            this.txtAmountpurchased.Name = "txtAmountpurchased";
            this.txtAmountpurchased.ReadOnly = true;
            this.txtAmountpurchased.Size = new System.Drawing.Size(136, 22);
            this.txtAmountpurchased.TabIndex = 181;
            // 
            // txtFreeItems
            // 
            this.txtFreeItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFreeItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtFreeItems.Location = new System.Drawing.Point(801, 718);
            this.txtFreeItems.Name = "txtFreeItems";
            this.txtFreeItems.ReadOnly = true;
            this.txtFreeItems.Size = new System.Drawing.Size(136, 22);
            this.txtFreeItems.TabIndex = 181;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(554, 790);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(217, 30);
            this.lblPercentage.TabIndex = 180;
            this.lblPercentage.Text = "Discount Percentage";
            // 
            // txtdiscountPercentage
            // 
            this.txtdiscountPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdiscountPercentage.Location = new System.Drawing.Point(801, 790);
            this.txtdiscountPercentage.Name = "txtdiscountPercentage";
            this.txtdiscountPercentage.ReadOnly = true;
            this.txtdiscountPercentage.Size = new System.Drawing.Size(136, 22);
            this.txtdiscountPercentage.TabIndex = 181;
            // 
            // lblQuantityReturning
            // 
            this.lblQuantityReturning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantityReturning.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityReturning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityReturning.Location = new System.Drawing.Point(554, 863);
            this.lblQuantityReturning.Name = "lblQuantityReturning";
            this.lblQuantityReturning.Size = new System.Drawing.Size(204, 30);
            this.lblQuantityReturning.TabIndex = 180;
            this.lblQuantityReturning.Text = "Quantity Returning";
            // 
            // txtQuantityReturn
            // 
            this.txtQuantityReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantityReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuantityReturn.Location = new System.Drawing.Point(801, 863);
            this.txtQuantityReturn.Name = "txtQuantityReturn";
            this.txtQuantityReturn.Size = new System.Drawing.Size(136, 22);
            this.txtQuantityReturn.TabIndex = 5;
            this.txtQuantityReturn.TextChanged += new System.EventHandler(this.txtAmountReturn_TextChanged);
            this.txtQuantityReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountReturn_KeyPress);
            // 
            // lblReturn
            // 
            this.lblReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(655, 127);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(103, 30);
            this.lblReturn.TabIndex = 176;
            this.lblReturn.Text = "Return ID             ";
            // 
            // txtReturnId
            // 
            this.txtReturnId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnId.Location = new System.Drawing.Point(764, 127);
            this.txtReturnId.Name = "txtReturnId";
            this.txtReturnId.ReadOnly = true;
            this.txtReturnId.Size = new System.Drawing.Size(99, 22);
            this.txtReturnId.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(862, 967);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCredit.BackColor = System.Drawing.Color.Transparent;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(554, 581);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(233, 30);
            this.lblCredit.TabIndex = 180;
            this.lblCredit.Text = "Customer Credit value";
            // 
            // txtCreditValue
            // 
            this.txtCreditValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCreditValue.Location = new System.Drawing.Point(801, 581);
            this.txtCreditValue.Name = "txtCreditValue";
            this.txtCreditValue.ReadOnly = true;
            this.txtCreditValue.Size = new System.Drawing.Size(136, 22);
            this.txtCreditValue.TabIndex = 181;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1174, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 182;
            this.lblDate.Text = "Date";
            // 
            // frmReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtdiscountPercentage);
            this.Controls.Add(this.txtFreeItems);
            this.Controls.Add(this.txtCreditValue);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtAmountpurchased);
            this.Controls.Add(this.txtReturnId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblDiscountItems);
            this.Controls.Add(this.lblQuantityReturning);
            this.Controls.Add(this.lblAmountPurchased);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtQuantityReturn);
            this.Controls.Add(this.txtBatchID);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IIDlbl);
            this.Controls.Add(this.lblOrderId);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.Name = "frmReturns";
            this.ShowIcon = false;
            this.Text = "Returns";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReturns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IIDlbl;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblAmountPurchased;
        private System.Windows.Forms.Label lblDiscountItems;
        private System.Windows.Forms.TextBox txtAmountpurchased;
        private System.Windows.Forms.TextBox txtFreeItems;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtdiscountPercentage;
        private System.Windows.Forms.Label lblQuantityReturning;
        private System.Windows.Forms.TextBox txtQuantityReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.TextBox txtReturnId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtCreditValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}