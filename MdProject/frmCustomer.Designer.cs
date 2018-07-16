namespace MdProject
{
    partial class frmCustomer
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
            this.dgvCustomerlist = new System.Windows.Forms.DataGridView();
            this.cmbCustomerSelect = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerlist
            // 
            this.dgvCustomerlist.AllowUserToAddRows = false;
            this.dgvCustomerlist.AllowUserToDeleteRows = false;
            this.dgvCustomerlist.AllowUserToResizeColumns = false;
            this.dgvCustomerlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerlist.Location = new System.Drawing.Point(417, 266);
            this.dgvCustomerlist.Name = "dgvCustomerlist";
            this.dgvCustomerlist.ReadOnly = true;
            this.dgvCustomerlist.RowHeadersVisible = false;
            this.dgvCustomerlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomerlist.RowTemplate.Height = 24;
            this.dgvCustomerlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerlist.Size = new System.Drawing.Size(673, 270);
            this.dgvCustomerlist.TabIndex = 0;
            this.dgvCustomerlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerlist_CellDoubleClick);
            // 
            // cmbCustomerSelect
            // 
            this.cmbCustomerSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCustomerSelect.FormattingEnabled = true;
            this.cmbCustomerSelect.Location = new System.Drawing.Point(467, 130);
            this.cmbCustomerSelect.Name = "cmbCustomerSelect";
            this.cmbCustomerSelect.Size = new System.Drawing.Size(237, 24);
            this.cmbCustomerSelect.TabIndex = 109;
            this.cmbCustomerSelect.TextChanged += new System.EventHandler(this.cmbCustomerSelect_TextChanged);
            this.cmbCustomerSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomerSelect_KeyPress);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(561, 675);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(194, 72);
            this.btnAddCustomer.TabIndex = 135;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(877, 150);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 136;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cmbCustomerSelect);
            this.Controls.Add(this.dgvCustomerlist);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.Name = "frmCustomer";
            this.ShowIcon = false;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerlist;
        private System.Windows.Forms.ComboBox cmbCustomerSelect;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnRefresh;
    }
}