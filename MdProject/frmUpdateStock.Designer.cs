namespace MdProject
{
    partial class frmUpdateStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStock));
            this.closebtn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtItemcategory = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IIDlbl = new System.Windows.Forms.Label();
            this.lblBatchid = new System.Windows.Forms.Label();
            this.txtBatchId = new System.Windows.Forms.TextBox();
            this.lblSelling = new System.Windows.Forms.Label();
            this.txtselling = new System.Windows.Forms.TextBox();
            this.lblExpire = new System.Windows.Forms.Label();
            this.txtExpire = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Maroon;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(577, 1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(42, 42);
            this.closebtn.TabIndex = 27;
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(351, 542);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(189, 542);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 27);
            this.btnChange.TabIndex = 47;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtItemcategory
            // 
            this.txtItemcategory.Location = new System.Drawing.Point(376, 233);
            this.txtItemcategory.Name = "txtItemcategory";
            this.txtItemcategory.Size = new System.Drawing.Size(88, 22);
            this.txtItemcategory.TabIndex = 45;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(376, 355);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(88, 22);
            this.txtQuantity.TabIndex = 43;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(376, 294);
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(88, 22);
            this.txtItemDesc.TabIndex = 44;
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(376, 111);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(88, 22);
            this.txtItemId.TabIndex = 42;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(119, 354);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(189, 33);
            this.lblQuantity.TabIndex = 39;
            this.lblQuantity.Text = "Quantiy         ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "Item Name        ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Item Category  ";
            // 
            // IIDlbl
            // 
            this.IIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.IIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IIDlbl.Location = new System.Drawing.Point(119, 111);
            this.IIDlbl.Name = "IIDlbl";
            this.IIDlbl.Size = new System.Drawing.Size(189, 28);
            this.IIDlbl.TabIndex = 37;
            this.IIDlbl.Text = "Item ID              ";
            // 
            // lblBatchid
            // 
            this.lblBatchid.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchid.Location = new System.Drawing.Point(119, 170);
            this.lblBatchid.Name = "lblBatchid";
            this.lblBatchid.Size = new System.Drawing.Size(189, 28);
            this.lblBatchid.TabIndex = 37;
            this.lblBatchid.Text = "Batch ID           ";
            // 
            // txtBatchId
            // 
            this.txtBatchId.Location = new System.Drawing.Point(376, 172);
            this.txtBatchId.Name = "txtBatchId";
            this.txtBatchId.ReadOnly = true;
            this.txtBatchId.Size = new System.Drawing.Size(88, 22);
            this.txtBatchId.TabIndex = 42;
            // 
            // lblSelling
            // 
            this.lblSelling.BackColor = System.Drawing.Color.Transparent;
            this.lblSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelling.Location = new System.Drawing.Point(119, 418);
            this.lblSelling.Name = "lblSelling";
            this.lblSelling.Size = new System.Drawing.Size(189, 33);
            this.lblSelling.TabIndex = 39;
            this.lblSelling.Text = "Selling Price";
            // 
            // txtselling
            // 
            this.txtselling.Location = new System.Drawing.Point(376, 416);
            this.txtselling.Name = "txtselling";
            this.txtselling.Size = new System.Drawing.Size(88, 22);
            this.txtselling.TabIndex = 43;
            // 
            // lblExpire
            // 
            this.lblExpire.BackColor = System.Drawing.Color.Transparent;
            this.lblExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpire.Location = new System.Drawing.Point(119, 482);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(189, 33);
            this.lblExpire.TabIndex = 39;
            this.lblExpire.Text = "Expire Date         ";
            // 
            // txtExpire
            // 
            this.txtExpire.Location = new System.Drawing.Point(376, 477);
            this.txtExpire.Name = "txtExpire";
            this.txtExpire.Size = new System.Drawing.Size(88, 22);
            this.txtExpire.TabIndex = 43;
            // 
            // frmUpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(621, 644);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtItemcategory);
            this.Controls.Add(this.txtExpire);
            this.Controls.Add(this.txtselling);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.txtBatchId);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.lblExpire);
            this.Controls.Add(this.lblSelling);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBatchid);
            this.Controls.Add(this.IIDlbl);
            this.Controls.Add(this.closebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.frmUpdateStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtItemcategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IIDlbl;
        private System.Windows.Forms.Label lblBatchid;
        private System.Windows.Forms.TextBox txtBatchId;
        private System.Windows.Forms.Label lblSelling;
        private System.Windows.Forms.TextBox txtselling;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.TextBox txtExpire;
    }
}