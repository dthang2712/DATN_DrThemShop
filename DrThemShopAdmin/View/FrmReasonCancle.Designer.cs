namespace DrThemShopAdmin.View
{
	partial class FrmReasonCancel
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
			this.txtReasonCancel = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.btnOK);
			this.pnlMain.Controls.Add(this.btnCancel);
			this.pnlMain.Controls.Add(this.txtReasonCancel);
			this.pnlMain.Size = new System.Drawing.Size(610, 163);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(519, 3);
			this.btnClose.Visible = false;
			// 
			// lblHeader
			// 
			this.lblHeader.Size = new System.Drawing.Size(604, 33);
			this.lblHeader.Text = "NHẬP LÝ DO HỦY ĐƠN";
			// 
			// txtReasonCancel
			// 
			this.txtReasonCancel.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtReasonCancel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReasonCancel.Location = new System.Drawing.Point(0, 0);
			this.txtReasonCancel.Multiline = true;
			this.txtReasonCancel.Name = "txtReasonCancel";
			this.txtReasonCancel.Size = new System.Drawing.Size(610, 119);
			this.txtReasonCancel.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCancel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(508, 119);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(102, 44);
			this.btnCancel.TabIndex = 304;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnOK.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(406, 119);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(102, 44);
			this.btnOK.TabIndex = 305;
			this.btnOK.Text = "Xác nhận";
			this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FrmReasonCancel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 205);
			this.FormHeader = "NHẬP LÝ DO HỦY ĐƠN";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmReasonCancel";
			this.ShowInTaskbar = true;
			this.Text = "Lý do hủy đơn";
			this.Load += new System.EventHandler(this.FrmReasonCancel_Load);
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtReasonCancel;
		public System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.Button btnOK;
	}
}