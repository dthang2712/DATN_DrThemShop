
namespace DrThemShopAdmin
{
    partial class FrmParent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParent));
			this.MnuStrip = new System.Windows.Forms.MenuStrip();
			this.statusStrip2 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.labVersion = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsm_TrangChu = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_Category = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_Product = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_Order = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_Windows = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuStrip.SuspendLayout();
			this.statusStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// MnuStrip
			// 
			this.MnuStrip.BackColor = System.Drawing.Color.White;
			this.MnuStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_TrangChu,
            this.tsm_Category,
            this.tsm_Product,
            this.tsm_Order,
            this.tsm_Windows});
			this.MnuStrip.Location = new System.Drawing.Point(0, 0);
			this.MnuStrip.MdiWindowListItem = this.tsm_Windows;
			this.MnuStrip.Name = "MnuStrip";
			this.MnuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.MnuStrip.Size = new System.Drawing.Size(1145, 24);
			this.MnuStrip.TabIndex = 0;
			this.MnuStrip.Text = "menuStrip1";
			// 
			// statusStrip2
			// 
			this.statusStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.statusStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.statusStrip2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.labVersion});
			this.statusStrip2.Location = new System.Drawing.Point(0, 526);
			this.statusStrip2.Name = "statusStrip2";
			this.statusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStrip2.Size = new System.Drawing.Size(1145, 22);
			this.statusStrip2.TabIndex = 12;
			this.statusStrip2.Text = "statusStrip2";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
			this.toolStripStatusLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripStatusLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.toolStripStatusLabel2.LinkColor = System.Drawing.Color.Black;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(1064, 17);
			this.toolStripStatusLabel2.Spring = true;
			this.toolStripStatusLabel2.Text = "Phần mềm quản lý hệ thống © 2024 - DrThem Shop";
			this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labVersion
			// 
			this.labVersion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labVersion.ForeColor = System.Drawing.Color.Black;
			this.labVersion.Name = "labVersion";
			this.labVersion.Size = new System.Drawing.Size(66, 17);
			this.labVersion.Text = "Phiên bản:";
			// 
			// tsm_TrangChu
			// 
			this.tsm_TrangChu.Image = global::DrThemShopAdmin.Properties.Resources.home_blueStyle;
			this.tsm_TrangChu.Name = "tsm_TrangChu";
			this.tsm_TrangChu.Size = new System.Drawing.Size(102, 20);
			this.tsm_TrangChu.Text = " Trang chủ";
			this.tsm_TrangChu.Click += new System.EventHandler(this.tsm_TrangChu_Click);
			// 
			// tsm_Category
			// 
			this.tsm_Category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsm_Category.Image = global::DrThemShopAdmin.Properties.Resources.detail_blueStyle;
			this.tsm_Category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsm_Category.Name = "tsm_Category";
			this.tsm_Category.Size = new System.Drawing.Size(151, 20);
			this.tsm_Category.Text = "Quản lý danh mục";
			this.tsm_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.tsm_Category.Click += new System.EventHandler(this.tsm_Category_Click);
			// 
			// tsm_Product
			// 
			this.tsm_Product.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsm_Product.Image = global::DrThemShopAdmin.Properties.Resources.detail_blueStyle;
			this.tsm_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsm_Product.Name = "tsm_Product";
			this.tsm_Product.Size = new System.Drawing.Size(150, 20);
			this.tsm_Product.Text = "Quản lý sản phẩm";
			this.tsm_Product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.tsm_Product.Click += new System.EventHandler(this.tsm_Product_Click);
			// 
			// tsm_Order
			// 
			this.tsm_Order.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsm_Order.Image = global::DrThemShopAdmin.Properties.Resources.detail_blueStyle;
			this.tsm_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsm_Order.Name = "tsm_Order";
			this.tsm_Order.Size = new System.Drawing.Size(149, 20);
			this.tsm_Order.Text = "Quản lý đơn hàng";
			this.tsm_Order.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.tsm_Order.Click += new System.EventHandler(this.tsm_Order_Click);
			// 
			// tsm_Windows
			// 
			this.tsm_Windows.Image = global::DrThemShopAdmin.Properties.Resources.icons8_restore_window_20;
			this.tsm_Windows.Name = "tsm_Windows";
			this.tsm_Windows.Size = new System.Drawing.Size(83, 20);
			this.tsm_Windows.Text = " Cửa sổ";
			// 
			// FrmParent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1145, 548);
			this.Controls.Add(this.statusStrip2);
			this.Controls.Add(this.MnuStrip);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MnuStrip;
			this.Name = "FrmParent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý hệ thống - DrThem Shop";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmParent_Load);
			this.MnuStrip.ResumeLayout(false);
			this.MnuStrip.PerformLayout();
			this.statusStrip2.ResumeLayout(false);
			this.statusStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_Windows;
        private System.Windows.Forms.ToolStripMenuItem tsm_TrangChu;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labVersion;
		private System.Windows.Forms.ToolStripMenuItem tsm_Category;
		private System.Windows.Forms.ToolStripMenuItem tsm_Product;
		private System.Windows.Forms.ToolStripMenuItem tsm_Order;
	}
}

