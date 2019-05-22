namespace MdProject
{
    partial class frmOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStockView = new System.Windows.Forms.DataGridView();
            this.cmbItemDesc = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostPerUnit = new System.Windows.Forms.MaskedTextBox();
            this.txtSellingPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.txtBatchId = new System.Windows.Forms.MaskedTextBox();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Costlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IIDlbl = new System.Windows.Forms.Label();
            this.dgvBillView = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.totallbl = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblPurchaseId = new System.Windows.Forms.Label();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockView
            // 
            this.dgvStockView.AllowUserToAddRows = false;
            this.dgvStockView.AllowUserToResizeColumns = false;
            this.dgvStockView.AllowUserToResizeRows = false;
            this.dgvStockView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvStockView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockView.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStockView.Location = new System.Drawing.Point(96, 331);
            this.dgvStockView.Name = "dgvStockView";
            this.dgvStockView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockView.RowHeadersVisible = false;
            this.dgvStockView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStockView.RowTemplate.Height = 24;
            this.dgvStockView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockView.Size = new System.Drawing.Size(549, 487);
            this.dgvStockView.TabIndex = 6;
            this.dgvStockView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockView_CellDoubleClick);
            // 
            // cmbItemDesc
            // 
            this.cmbItemDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbItemDesc.FormattingEnabled = true;
            this.cmbItemDesc.Location = new System.Drawing.Point(297, 260);
            this.cmbItemDesc.Name = "cmbItemDesc";
            this.cmbItemDesc.Size = new System.Drawing.Size(237, 24);
            this.cmbItemDesc.TabIndex = 0;
            this.cmbItemDesc.SelectedIndexChanged += new System.EventHandler(this.cmbItemDesc_SelectedIndexChanged);
            this.cmbItemDesc.TextChanged += new System.EventHandler(this.cmbItemDesc_TextChanged);
            this.cmbItemDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbItemDesc_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(789, 735);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(676, 865);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 60);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 732);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 126;
            this.label4.Text = "Expire Date       ";
            // 
            // txtCostPerUnit
            // 
            this.txtCostPerUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCostPerUnit.Location = new System.Drawing.Point(801, 674);
            this.txtCostPerUnit.Name = "txtCostPerUnit";
            this.txtCostPerUnit.Size = new System.Drawing.Size(149, 22);
            this.txtCostPerUnit.TabIndex = 3;
            this.txtCostPerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostPerUnit_KeyPress);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSellingPrice.Location = new System.Drawing.Point(801, 613);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(149, 22);
            this.txtSellingPrice.TabIndex = 2;
            this.txtSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingPrice_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Location = new System.Drawing.Point(801, 552);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(149, 22);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtBatchId
            // 
            this.txtBatchId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBatchId.Location = new System.Drawing.Point(801, 491);
            this.txtBatchId.Name = "txtBatchId";
            this.txtBatchId.Size = new System.Drawing.Size(149, 22);
            this.txtBatchId.TabIndex = 122;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemDesc.BackColor = System.Drawing.SystemColors.Window;
            this.lblItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemDesc.Location = new System.Drawing.Point(801, 429);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(149, 23);
            this.lblItemDesc.TabIndex = 121;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.BackColor = System.Drawing.SystemColors.Window;
            this.lblItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemName.Location = new System.Drawing.Point(801, 367);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(149, 23);
            this.lblItemName.TabIndex = 120;
            // 
            // lblItemId
            // 
            this.lblItemId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemId.BackColor = System.Drawing.SystemColors.Window;
            this.lblItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemId.Location = new System.Drawing.Point(801, 305);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(149, 23);
            this.lblItemId.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(613, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 28);
            this.label6.TabIndex = 118;
            this.label6.Text = "Batch ID            ";
            // 
            // Costlbl
            // 
            this.Costlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Costlbl.BackColor = System.Drawing.Color.Transparent;
            this.Costlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costlbl.Location = new System.Drawing.Point(613, 671);
            this.Costlbl.Name = "Costlbl";
            this.Costlbl.Size = new System.Drawing.Size(196, 28);
            this.Costlbl.TabIndex = 117;
            this.Costlbl.Text = "Cost per unit      Rs:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 28);
            this.label5.TabIndex = 116;
            this.label5.Text = "Selling Price      Rs:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(613, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 28);
            this.label3.TabIndex = 115;
            this.label3.Text = "Quantity Received ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 114;
            this.label2.Text = "Item Description";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 113;
            this.label1.Text = "Item Name       ";
            // 
            // IIDlbl
            // 
            this.IIDlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.IIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IIDlbl.Location = new System.Drawing.Point(613, 305);
            this.IIDlbl.Name = "IIDlbl";
            this.IIDlbl.Size = new System.Drawing.Size(170, 28);
            this.IIDlbl.TabIndex = 112;
            this.IIDlbl.Text = "Item ID               ";
            // 
            // dgvBillView
            // 
            this.dgvBillView.AllowUserToAddRows = false;
            this.dgvBillView.AllowUserToDeleteRows = false;
            this.dgvBillView.AllowUserToResizeColumns = false;
            this.dgvBillView.AllowUserToResizeRows = false;
            this.dgvBillView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvBillView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillView.Location = new System.Drawing.Point(944, 331);
            this.dgvBillView.Name = "dgvBillView";
            this.dgvBillView.ReadOnly = true;
            this.dgvBillView.RowHeadersVisible = false;
            this.dgvBillView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBillView.RowTemplate.Height = 24;
            this.dgvBillView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillView.Size = new System.Drawing.Size(940, 487);
            this.dgvBillView.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(1026, 835);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(116, 22);
            this.txtAmount.TabIndex = 129;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrder.Location = new System.Drawing.Point(1253, 865);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 60);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Update Stocks";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // totallbl
            // 
            this.totallbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(940, 835);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(56, 25);
            this.totallbl.TabIndex = 132;
            this.totallbl.Text = "Total";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(1691, 865);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 60);
            this.btnClear.TabIndex = 131;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1472, 865);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 60);
            this.btnDelete.TabIndex = 130;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItem.Location = new System.Drawing.Point(53, 865);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(197, 60);
            this.btnAddItem.TabIndex = 134;
            this.btnAddItem.Text = "New Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1779, 63);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 135;
            this.lblDate.Text = "Date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(297, 865);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 60);
            this.btnRefresh.TabIndex = 136;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(64, 260);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(202, 25);
            this.lblSearch.TabIndex = 137;
            this.lblSearch.Text = "Search By Item Name";
            // 
            // lblPurchaseId
            // 
            this.lblPurchaseId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPurchaseId.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseId.Location = new System.Drawing.Point(925, 260);
            this.lblPurchaseId.Name = "lblPurchaseId";
            this.lblPurchaseId.Size = new System.Drawing.Size(170, 28);
            this.lblPurchaseId.TabIndex = 112;
            this.lblPurchaseId.Text = "Purchase ID               ";
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPurchaseId.BackColor = System.Drawing.SystemColors.Window;
            this.txtPurchaseId.Location = new System.Drawing.Point(1120, 260);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.ReadOnly = true;
            this.txtPurchaseId.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseId.TabIndex = 176;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Teal;
            this.lblOrder.Location = new System.Drawing.Point(66, 40);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(590, 96);
            this.lblOrder.TabIndex = 177;
            this.lblOrder.Text = "STOCK ORDER";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.txtPurchaseId);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dgvBillView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCostPerUnit);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBatchId);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Costlbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPurchaseId);
            this.Controls.Add(this.IIDlbl);
            this.Controls.Add(this.cmbItemDesc);
            this.Controls.Add(this.dgvStockView);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.Name = "frmOrder";
            this.ShowIcon = false;
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockView;
        private System.Windows.Forms.ComboBox cmbItemDesc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCostPerUnit;
        private System.Windows.Forms.MaskedTextBox txtSellingPrice;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.MaskedTextBox txtBatchId;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Costlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IIDlbl;
        private System.Windows.Forms.DataGridView dgvBillView;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblPurchaseId;
        private System.Windows.Forms.TextBox txtPurchaseId;
        private System.Windows.Forms.Label lblOrder;
    }
}