namespace MdProject
{
    partial class frmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStockView = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.txtFreeItems = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQtyAvailable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.checkboxItem = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBatchId = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IIDlbl = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtaAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtTobePaid = new System.Windows.Forms.TextBox();
            this.Amnttobepaidlbl = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.discountlbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.txttotalAmount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.CusIdLbl = new System.Windows.Forms.Label();
            this.OrdIdLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCusName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockView
            // 
            this.dgvStockView.AllowUserToAddRows = false;
            this.dgvStockView.AllowUserToDeleteRows = false;
            this.dgvStockView.AllowUserToResizeColumns = false;
            this.dgvStockView.AllowUserToResizeRows = false;
            this.dgvStockView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvStockView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockView.Location = new System.Drawing.Point(0, 343);
            this.dgvStockView.Name = "dgvStockView";
            this.dgvStockView.ReadOnly = true;
            this.dgvStockView.RowHeadersVisible = false;
            this.dgvStockView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStockView.RowTemplate.Height = 24;
            this.dgvStockView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockView.Size = new System.Drawing.Size(545, 330);
            this.dgvStockView.TabIndex = 14;
            this.dgvStockView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockView_CellDoubleClick);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(41, 252);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(173, 20);
            this.lblSearch.TabIndex = 139;
            this.lblSearch.Text = "Search By Item Name";
            // 
            // cmbItemName
            // 
            this.cmbItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(250, 252);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(237, 24);
            this.cmbItemName.TabIndex = 138;
            this.cmbItemName.TextChanged += new System.EventHandler(this.cmbItemName_TextChanged);
            // 
            // txtFreeItems
            // 
            this.txtFreeItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFreeItems.Location = new System.Drawing.Point(701, 745);
            this.txtFreeItems.Name = "txtFreeItems";
            this.txtFreeItems.ReadOnly = true;
            this.txtFreeItems.Size = new System.Drawing.Size(135, 22);
            this.txtFreeItems.TabIndex = 158;
            this.txtFreeItems.TextChanged += new System.EventHandler(this.txtFreeItems_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(522, 745);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 33);
            this.label9.TabIndex = 157;
            this.label9.Text = "Free Items         :";
            // 
            // lblQtyAvailable
            // 
            this.lblQtyAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtyAvailable.BackColor = System.Drawing.Color.Silver;
            this.lblQtyAvailable.Location = new System.Drawing.Point(698, 629);
            this.lblQtyAvailable.Name = "lblQtyAvailable";
            this.lblQtyAvailable.Size = new System.Drawing.Size(138, 23);
            this.lblQtyAvailable.TabIndex = 156;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 33);
            this.label8.TabIndex = 155;
            this.label8.Text = "Quantity available      :";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitbtn.Location = new System.Drawing.Point(761, 836);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 154;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // checkboxItem
            // 
            this.checkboxItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkboxItem.AutoSize = true;
            this.checkboxItem.Location = new System.Drawing.Point(806, 798);
            this.checkboxItem.Name = "checkboxItem";
            this.checkboxItem.Size = new System.Drawing.Size(18, 17);
            this.checkboxItem.TabIndex = 153;
            this.checkboxItem.UseVisualStyleBackColor = true;
            this.checkboxItem.CheckedChanged += new System.EventHandler(this.checkboxItem_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 798);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 33);
            this.label5.TabIndex = 152;
            this.label5.Text = "Item Discount";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Location = new System.Drawing.Point(701, 684);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(135, 22);
            this.txtQuantity.TabIndex = 151;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 33);
            this.label3.TabIndex = 150;
            this.label3.Text = "Quantity             :";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSellingPrice.BackColor = System.Drawing.Color.Silver;
            this.lblSellingPrice.Location = new System.Drawing.Point(698, 574);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(138, 23);
            this.lblSellingPrice.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 33);
            this.label4.TabIndex = 148;
            this.label4.Text = "Selling Price      :";
            // 
            // lblBatchId
            // 
            this.lblBatchId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBatchId.BackColor = System.Drawing.Color.Silver;
            this.lblBatchId.Location = new System.Drawing.Point(698, 519);
            this.lblBatchId.Name = "lblBatchId";
            this.lblBatchId.Size = new System.Drawing.Size(138, 23);
            this.lblBatchId.TabIndex = 147;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpireDate.BackColor = System.Drawing.Color.Silver;
            this.lblExpireDate.Location = new System.Drawing.Point(698, 464);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(138, 23);
            this.lblExpireDate.TabIndex = 146;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemDesc.BackColor = System.Drawing.Color.Silver;
            this.lblItemDesc.Location = new System.Drawing.Point(698, 409);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(138, 23);
            this.lblItemDesc.TabIndex = 145;
            // 
            // lblItemID
            // 
            this.lblItemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemID.BackColor = System.Drawing.Color.Silver;
            this.lblItemID.Location = new System.Drawing.Point(698, 354);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(138, 23);
            this.lblItemID.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 33);
            this.label6.TabIndex = 143;
            this.label6.Text = "Batch ID             :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 33);
            this.label2.TabIndex = 142;
            this.label2.Text = "Item Name        :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 141;
            this.label1.Text = "Expire Date       :";
            // 
            // IIDlbl
            // 
            this.IIDlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.IIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IIDlbl.Location = new System.Drawing.Point(522, 354);
            this.IIDlbl.Name = "IIDlbl";
            this.IIDlbl.Size = new System.Drawing.Size(170, 28);
            this.IIDlbl.TabIndex = 140;
            this.IIDlbl.Text = "Item ID               :";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(835, 343);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(1073, 295);
            this.dgvBill.TabIndex = 159;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmit.Location = new System.Drawing.Point(1426, 962);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtaAmount
            // 
            this.txtaAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtaAmount.Location = new System.Drawing.Point(1386, 774);
            this.txtaAmount.Name = "txtaAmount";
            this.txtaAmount.ReadOnly = true;
            this.txtaAmount.Size = new System.Drawing.Size(100, 22);
            this.txtaAmount.TabIndex = 1;
            this.txtaAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtaAmount_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1192, 920);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 169;
            this.label7.Text = "Amount paid";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDiscount.Location = new System.Drawing.Point(1515, 826);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.Text = "Enter";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            this.btnDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnDiscount_KeyUp);
            // 
            // txtTobePaid
            // 
            this.txtTobePaid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTobePaid.Location = new System.Drawing.Point(1386, 871);
            this.txtTobePaid.Name = "txtTobePaid";
            this.txtTobePaid.ReadOnly = true;
            this.txtTobePaid.Size = new System.Drawing.Size(100, 22);
            this.txtTobePaid.TabIndex = 4;
            this.txtTobePaid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTobePaid_KeyUp);
            // 
            // Amnttobepaidlbl
            // 
            this.Amnttobepaidlbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Amnttobepaidlbl.AutoSize = true;
            this.Amnttobepaidlbl.Location = new System.Drawing.Point(1192, 877);
            this.Amnttobepaidlbl.Name = "Amnttobepaidlbl";
            this.Amnttobepaidlbl.Size = new System.Drawing.Size(123, 17);
            this.Amnttobepaidlbl.TabIndex = 166;
            this.Amnttobepaidlbl.Text = "Amount to be paid";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDiscount.Location = new System.Drawing.Point(1386, 826);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // discountlbl
            // 
            this.discountlbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.discountlbl.AutoSize = true;
            this.discountlbl.Location = new System.Drawing.Point(1192, 826);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(140, 17);
            this.discountlbl.TabIndex = 164;
            this.discountlbl.Text = "Discount Percentage";
            // 
            // totallbl
            // 
            this.totallbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(1192, 779);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(40, 17);
            this.totallbl.TabIndex = 163;
            this.totallbl.Text = "Total";
            // 
            // txttotalAmount
            // 
            this.txttotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttotalAmount.Location = new System.Drawing.Point(1386, 917);
            this.txttotalAmount.Name = "txttotalAmount";
            this.txttotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txttotalAmount.TabIndex = 5;
            this.txttotalAmount.Text = "0";
            this.txttotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotalAmount_KeyPress);
            this.txttotalAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttotalAmount_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Location = new System.Drawing.Point(850, 833);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 161;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Location = new System.Drawing.Point(850, 775);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 160;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCustomerId.Location = new System.Drawing.Point(1165, 257);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerId.TabIndex = 176;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            this.txtCustomerId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerId_KeyUp);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtOrderId.Location = new System.Drawing.Point(966, 257);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 22);
            this.txtOrderId.TabIndex = 175;
            // 
            // DateLbl
            // 
            this.DateLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(1783, 224);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(38, 17);
            this.DateLbl.TabIndex = 174;
            this.DateLbl.Text = "Date";
            // 
            // CusIdLbl
            // 
            this.CusIdLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CusIdLbl.AutoSize = true;
            this.CusIdLbl.Location = new System.Drawing.Point(1165, 224);
            this.CusIdLbl.Name = "CusIdLbl";
            this.CusIdLbl.Size = new System.Drawing.Size(79, 17);
            this.CusIdLbl.TabIndex = 173;
            this.CusIdLbl.Text = "CustomerId";
            // 
            // OrdIdLbl
            // 
            this.OrdIdLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OrdIdLbl.AutoSize = true;
            this.OrdIdLbl.Location = new System.Drawing.Point(966, 224);
            this.OrdIdLbl.Name = "OrdIdLbl";
            this.OrdIdLbl.Size = new System.Drawing.Size(60, 17);
            this.OrdIdLbl.TabIndex = 172;
            this.OrdIdLbl.Text = "Order Id";
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCusName.Location = new System.Drawing.Point(1443, 219);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(244, 22);
            this.txtCusName.TabIndex = 0;
            this.txtCusName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCusName_KeyUp);
            this.txtCusName.Leave += new System.EventHandler(this.txtCusName_Leave);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.CusIdLbl);
            this.Controls.Add(this.OrdIdLbl);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtaAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.txtTobePaid);
            this.Controls.Add(this.Amnttobepaidlbl);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.discountlbl);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.txttotalAmount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.txtFreeItems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblQtyAvailable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.checkboxItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBatchId);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IIDlbl);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.dgvStockView);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.Name = "frmSales";
            this.ShowIcon = false;
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockView;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.TextBox txtFreeItems;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQtyAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.CheckBox checkboxItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBatchId;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IIDlbl;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtaAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txtTobePaid;
        private System.Windows.Forms.Label Amnttobepaidlbl;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label discountlbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox txttotalAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label CusIdLbl;
        private System.Windows.Forms.Label OrdIdLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCusName;
    }
}