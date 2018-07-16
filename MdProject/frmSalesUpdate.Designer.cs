namespace MdProject
{
    partial class frmSalesUpdate
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
            this.lblSalesId = new System.Windows.Forms.Label();
            this.txtSalesId = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.dgvsalesview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesId
            // 
            this.lblSalesId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalesId.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesId.Location = new System.Drawing.Point(291, 125);
            this.lblSalesId.Name = "lblSalesId";
            this.lblSalesId.Size = new System.Drawing.Size(103, 30);
            this.lblSalesId.TabIndex = 177;
            this.lblSalesId.Text = "Sales ID             ";
            // 
            // txtSalesId
            // 
            this.txtSalesId.Location = new System.Drawing.Point(434, 125);
            this.txtSalesId.Name = "txtSalesId";
            this.txtSalesId.Size = new System.Drawing.Size(100, 22);
            this.txtSalesId.TabIndex = 178;
            this.txtSalesId.TextChanged += new System.EventHandler(this.txtSalesId_TextChanged);
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(606, 125);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 179;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            // 
            // dgvsalesview
            // 
            this.dgvsalesview.AllowUserToAddRows = false;
            this.dgvsalesview.AllowUserToDeleteRows = false;
            this.dgvsalesview.AllowUserToResizeColumns = false;
            this.dgvsalesview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsalesview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsalesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesview.Location = new System.Drawing.Point(359, 285);
            this.dgvsalesview.Name = "dgvsalesview";
            this.dgvsalesview.ReadOnly = true;
            this.dgvsalesview.RowHeadersVisible = false;
            this.dgvsalesview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvsalesview.RowTemplate.Height = 24;
            this.dgvsalesview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsalesview.Size = new System.Drawing.Size(963, 259);
            this.dgvsalesview.TabIndex = 180;
            this.dgvsalesview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalesview_CellDoubleClick);
            // 
            // frmSalesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.dgvsalesview);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtSalesId);
            this.Controls.Add(this.lblSalesId);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.Name = "frmSalesUpdate";
            this.ShowIcon = false;
            this.Text = "Sales Update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalesUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesId;
        private System.Windows.Forms.TextBox txtSalesId;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.DataGridView dgvsalesview;
    }
}