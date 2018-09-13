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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSalesId = new System.Windows.Forms.Label();
            this.txtSalesId = new System.Windows.Forms.TextBox();
            this.dgvsalesview = new System.Windows.Forms.DataGridView();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesId
            // 
            this.lblSalesId.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesId.Location = new System.Drawing.Point(70, 210);
            this.lblSalesId.Name = "lblSalesId";
            this.lblSalesId.Size = new System.Drawing.Size(103, 30);
            this.lblSalesId.TabIndex = 177;
            this.lblSalesId.Text = "Sales ID             ";
            // 
            // txtSalesId
            // 
            this.txtSalesId.Location = new System.Drawing.Point(224, 214);
            this.txtSalesId.Name = "txtSalesId";
            this.txtSalesId.Size = new System.Drawing.Size(160, 22);
            this.txtSalesId.TabIndex = 178;
            this.txtSalesId.TextChanged += new System.EventHandler(this.txtSalesId_TextChanged);
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
            this.dgvsalesview.Location = new System.Drawing.Point(60, 257);
            this.dgvsalesview.Name = "dgvsalesview";
            this.dgvsalesview.ReadOnly = true;
            this.dgvsalesview.RowHeadersVisible = false;
            this.dgvsalesview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvsalesview.RowTemplate.Height = 24;
            this.dgvsalesview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsalesview.Size = new System.Drawing.Size(963, 499);
            this.dgvsalesview.TabIndex = 180;
            this.dgvsalesview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalesview_CellDoubleClick);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Teal;
            this.lblOrder.Location = new System.Drawing.Point(44, 58);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(574, 96);
            this.lblOrder.TabIndex = 181;
            this.lblOrder.Text = "UPDATE SALES";
            this.lblOrder.Click += new System.EventHandler(this.lblOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 21);
            this.label1.TabIndex = 182;
            this.label1.Text = "i. Double click on relevant sales field to view details";
            // 
            // frmSalesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1070, 784);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.dgvsalesview);
            this.Controls.Add(this.txtSalesId);
            this.Controls.Add(this.lblSalesId);
            this.MaximumSize = new System.Drawing.Size(4000, 4000);
            this.MinimizeBox = false;
            this.Name = "frmSalesUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Update";
            this.Load += new System.EventHandler(this.frmSalesUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesId;
        private System.Windows.Forms.TextBox txtSalesId;
        private System.Windows.Forms.DataGridView dgvsalesview;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
    }
}