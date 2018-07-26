namespace MdProject
{
    partial class frmMain
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btncustomers = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnStocksview = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSalesUpdate = new System.Windows.Forms.Button();
            this.btnSidePannelView = new System.Windows.Forms.Button();
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnStocksReport = new System.Windows.Forms.Button();
            this.btnSalesReports = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOrder.BackgroundImage = global::MdProject.Properties.Resources.Order;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(550, 393);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(133, 123);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseEnter += new System.EventHandler(this.btnOrder_MouseEnter);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            // 
            // btnsales
            // 
            this.btnsales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsales.BackgroundImage = global::MdProject.Properties.Resources.Sales;
            this.btnsales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsales.FlatAppearance.BorderSize = 0;
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.Location = new System.Drawing.Point(731, 518);
            this.btnsales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(133, 123);
            this.btnsales.TabIndex = 1;
            this.btnsales.UseVisualStyleBackColor = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            this.btnsales.MouseEnter += new System.EventHandler(this.btnsales_MouseEnter);
            this.btnsales.MouseLeave += new System.EventHandler(this.btnsales_MouseLeave);
            // 
            // btncustomers
            // 
            this.btncustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncustomers.BackgroundImage = global::MdProject.Properties.Resources.Customer;
            this.btncustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncustomers.FlatAppearance.BorderSize = 0;
            this.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomers.Location = new System.Drawing.Point(1247, 516);
            this.btncustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(133, 123);
            this.btncustomers.TabIndex = 0;
            this.btncustomers.UseVisualStyleBackColor = true;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            this.btncustomers.MouseEnter += new System.EventHandler(this.btncustomers_MouseEnter);
            this.btncustomers.MouseLeave += new System.EventHandler(this.btncustomers_MouseLeave);
            // 
            // btnReturns
            // 
            this.btnReturns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturns.BackgroundImage = global::MdProject.Properties.Resources.Return;
            this.btnReturns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturns.FlatAppearance.BorderSize = 0;
            this.btnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturns.Location = new System.Drawing.Point(987, 387);
            this.btnReturns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(133, 123);
            this.btnReturns.TabIndex = 0;
            this.btnReturns.UseVisualStyleBackColor = true;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            this.btnReturns.MouseEnter += new System.EventHandler(this.btnReturns_MouseEnter);
            this.btnReturns.MouseLeave += new System.EventHandler(this.btnReturns_MouseLeave);
            // 
            // btnStocksview
            // 
            this.btnStocksview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStocksview.FlatAppearance.BorderSize = 0;
            this.btnStocksview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnStocksview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStocksview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocksview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocksview.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStocksview.Location = new System.Drawing.Point(648, 914);
            this.btnStocksview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStocksview.Name = "btnStocksview";
            this.btnStocksview.Size = new System.Drawing.Size(220, 60);
            this.btnStocksview.TabIndex = 2;
            this.btnStocksview.Text = "Stock Update";
            this.btnStocksview.UseVisualStyleBackColor = false;
            this.btnStocksview.Click += new System.EventHandler(this.btnStocksview_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayment.Location = new System.Drawing.Point(927, 914);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(220, 60);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Credit Payments";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnSalesUpdate
            // 
            this.btnSalesUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalesUpdate.FlatAppearance.BorderSize = 0;
            this.btnSalesUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSalesUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesUpdate.Location = new System.Drawing.Point(1214, 914);
            this.btnSalesUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalesUpdate.Name = "btnSalesUpdate";
            this.btnSalesUpdate.Size = new System.Drawing.Size(220, 60);
            this.btnSalesUpdate.TabIndex = 4;
            this.btnSalesUpdate.Text = "Sales Update";
            this.btnSalesUpdate.UseVisualStyleBackColor = false;
            this.btnSalesUpdate.Click += new System.EventHandler(this.btnSalesUpdate_Click);
            // 
            // btnSidePannelView
            // 
            this.btnSidePannelView.BackColor = System.Drawing.Color.Transparent;
            this.btnSidePannelView.BackgroundImage = global::MdProject.Properties.Resources.listView1;
            this.btnSidePannelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSidePannelView.FlatAppearance.BorderSize = 0;
            this.btnSidePannelView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSidePannelView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSidePannelView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidePannelView.Location = new System.Drawing.Point(53, 103);
            this.btnSidePannelView.Margin = new System.Windows.Forms.Padding(4);
            this.btnSidePannelView.Name = "btnSidePannelView";
            this.btnSidePannelView.Size = new System.Drawing.Size(53, 49);
            this.btnSidePannelView.TabIndex = 5;
            this.btnSidePannelView.UseVisualStyleBackColor = false;
            this.btnSidePannelView.Click += new System.EventHandler(this.btnSidePannelView_Click);
            this.btnSidePannelView.MouseEnter += new System.EventHandler(this.btnSidePannelView_MouseEnter);
            this.btnSidePannelView.MouseLeave += new System.EventHandler(this.btnSidePannelView_MouseLeave);
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackgroundImage = global::MdProject.Properties.Resources.SidePanel_new;
            this.pnlSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSidePanel.Controls.Add(this.btnCustomer);
            this.pnlSidePanel.Controls.Add(this.btnStocksReport);
            this.pnlSidePanel.Controls.Add(this.btnSalesReports);
            this.pnlSidePanel.Location = new System.Drawing.Point(-2, 44);
            this.pnlSidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(377, 1062);
            this.pnlSidePanel.TabIndex = 6;
            this.pnlSidePanel.Visible = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomer.Location = new System.Drawing.Point(73, 430);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(240, 60);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnStocksReport
            // 
            this.btnStocksReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.btnStocksReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocksReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocksReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStocksReport.Location = new System.Drawing.Point(73, 331);
            this.btnStocksReport.Name = "btnStocksReport";
            this.btnStocksReport.Size = new System.Drawing.Size(240, 60);
            this.btnStocksReport.TabIndex = 1;
            this.btnStocksReport.Text = "Stock";
            this.btnStocksReport.UseVisualStyleBackColor = false;
            this.btnStocksReport.Click += new System.EventHandler(this.btnStocksReport_Click);
            // 
            // btnSalesReports
            // 
            this.btnSalesReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.btnSalesReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesReports.Location = new System.Drawing.Point(73, 225);
            this.btnSalesReports.Name = "btnSalesReports";
            this.btnSalesReports.Size = new System.Drawing.Size(240, 60);
            this.btnSalesReports.TabIndex = 0;
            this.btnSalesReports.Text = "Sales";
            this.btnSalesReports.UseVisualStyleBackColor = false;
            this.btnSalesReports.Click += new System.EventHandler(this.btnSalesReports_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(1883, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.Location = new System.Drawing.Point(1847, -2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 50);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MdProject.Properties.Resources.home_new;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.btnSidePannelView);
            this.Controls.Add(this.btnSalesUpdate);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnStocksview);
            this.Controls.Add(this.btnsales);
            this.Controls.Add(this.btnReturns);
            this.Controls.Add(this.btncustomers);
            this.Controls.Add(this.btnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD Agency";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.pnlSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btncustomers;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.Button btnStocksview;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSalesUpdate;
        private System.Windows.Forms.Button btnSidePannelView;
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnStocksReport;
        private System.Windows.Forms.Button btnSalesReports;
        private System.Windows.Forms.Button btnCustomer;
    }
}

