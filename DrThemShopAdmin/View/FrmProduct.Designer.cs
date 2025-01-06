namespace DrThemShopAdmin.View
{
	partial class FrmProduct
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
			System.Windows.Forms.Label lblSequenceListHeader;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
			this.pnlAdd = new System.Windows.Forms.Panel();
			this.btnClearImage = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.cbCategory = new MultiColumnComboBox.MultiColumnComboBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnImage = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pbProductImage = new System.Windows.Forms.PictureBox();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnUpAdd = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.btnDownAdd = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblSequenceDetailHeader = new System.Windows.Forms.Label();
			this.btnDownSearch = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.pnlSequenceList = new System.Windows.Forms.Panel();
			this.pnMainLeft = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.cbCategorySearch = new MultiColumnComboBox.MultiColumnComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnUpSearch = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.lineBottom2 = new DrThemShop.WinLibrary.CustomControl.LineBottom();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lineBottom1 = new DrThemShop.WinLibrary.CustomControl.LineBottom();
			this.lineTop1 = new DrThemShop.WinLibrary.CustomControl.LineTop();
			this.bvProduct = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProductImage = new System.Windows.Forms.DataGridViewImageColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			lblSequenceListHeader = new System.Windows.Forms.Label();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.pnlAdd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownSearch)).BeginInit();
			this.pnlSequenceList.SuspendLayout();
			this.pnMainLeft.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnUpSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bvProduct)).BeginInit();
			this.bvProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.pnlSequenceList);
			this.pnlMain.Size = new System.Drawing.Size(1200, 592);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(1109, 3);
			// 
			// lblHeader
			// 
			this.lblHeader.Size = new System.Drawing.Size(1194, 33);
			this.lblHeader.Text = "QUẢN LÝ SẢN PHẨM";
			// 
			// lblSequenceListHeader
			// 
			lblSequenceListHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			lblSequenceListHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			lblSequenceListHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			lblSequenceListHeader.ForeColor = System.Drawing.Color.Black;
			lblSequenceListHeader.Location = new System.Drawing.Point(0, 0);
			lblSequenceListHeader.Name = "lblSequenceListHeader";
			lblSequenceListHeader.Size = new System.Drawing.Size(1200, 24);
			lblSequenceListHeader.TabIndex = 0;
			lblSequenceListHeader.Text = "         Danh sách Sản phẩm";
			lblSequenceListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlAdd
			// 
			this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
			this.pnlAdd.Controls.Add(this.btnClearImage);
			this.pnlAdd.Controls.Add(this.label9);
			this.pnlAdd.Controls.Add(this.cbCategory);
			this.pnlAdd.Controls.Add(this.txtUnit);
			this.pnlAdd.Controls.Add(this.label8);
			this.pnlAdd.Controls.Add(this.label7);
			this.pnlAdd.Controls.Add(this.txtPrice);
			this.pnlAdd.Controls.Add(this.label6);
			this.pnlAdd.Controls.Add(this.btnImage);
			this.pnlAdd.Controls.Add(this.label2);
			this.pnlAdd.Controls.Add(this.pbProductImage);
			this.pnlAdd.Controls.Add(this.txtContent);
			this.pnlAdd.Controls.Add(this.label4);
			this.pnlAdd.Controls.Add(this.btnUpAdd);
			this.pnlAdd.Controls.Add(this.btnDownAdd);
			this.pnlAdd.Controls.Add(this.txtProductName);
			this.pnlAdd.Controls.Add(this.label1);
			this.pnlAdd.Controls.Add(this.btnSave);
			this.pnlAdd.Controls.Add(this.lblSequenceDetailHeader);
			this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlAdd.Location = new System.Drawing.Point(0, 0);
			this.pnlAdd.Margin = new System.Windows.Forms.Padding(0);
			this.pnlAdd.Name = "pnlAdd";
			this.pnlAdd.Size = new System.Drawing.Size(1200, 135);
			this.pnlAdd.TabIndex = 2;
			// 
			// btnClearImage
			// 
			this.btnClearImage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearImage.Location = new System.Drawing.Point(308, 62);
			this.btnClearImage.Name = "btnClearImage";
			this.btnClearImage.Size = new System.Drawing.Size(29, 64);
			this.btnClearImage.TabIndex = 30;
			this.btnClearImage.Text = "X";
			this.btnClearImage.UseVisualStyleBackColor = true;
			this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(594, 37);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 16);
			this.label9.TabIndex = 29;
			this.label9.Text = "VNĐ";
			// 
			// cbCategory
			// 
			this.cbCategory.AutoComplete = false;
			this.cbCategory.AutoDropdown = false;
			this.cbCategory.BackColorEven = System.Drawing.Color.White;
			this.cbCategory.BackColorOdd = System.Drawing.Color.LightBlue;
			this.cbCategory.ColumnNames = "CategoryID,CategoryName";
			this.cbCategory.ColumnWidthDefault = 75;
			this.cbCategory.ColumnWidths = "50,200";
			this.cbCategory.DisplayMember = "CategoryName";
			this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.LinkedColumnIndex = 0;
			this.cbCategory.LinkedTextBox = null;
			this.cbCategory.Location = new System.Drawing.Point(433, 69);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(195, 23);
			this.cbCategory.TabIndex = 28;
			this.cbCategory.ValueMember = "CategoryID";
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(433, 104);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(195, 22);
			this.txtUnit.TabIndex = 26;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(357, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 27;
			this.label8.Text = "Đơn vị:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(357, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 16);
			this.label7.TabIndex = 25;
			this.label7.Text = "Danh mục:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(433, 34);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(155, 22);
			this.txtPrice.TabIndex = 22;
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(357, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 16);
			this.label6.TabIndex = 23;
			this.label6.Text = "Giá:";
			// 
			// btnImage
			// 
			this.btnImage.Location = new System.Drawing.Point(275, 62);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(29, 64);
			this.btnImage.TabIndex = 21;
			this.btnImage.Text = "...";
			this.btnImage.UseVisualStyleBackColor = true;
			this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Hình ảnh:";
			// 
			// pbProductImage
			// 
			this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbProductImage.Image = global::DrThemShopAdmin.Properties.Resources.icons8_cloud_cross_80;
			this.pbProductImage.Location = new System.Drawing.Point(113, 62);
			this.pbProductImage.Name = "pbProductImage";
			this.pbProductImage.Size = new System.Drawing.Size(156, 64);
			this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbProductImage.TabIndex = 19;
			this.pbProductImage.TabStop = false;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(721, 34);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(224, 92);
			this.txtContent.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(671, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 18;
			this.label4.Text = "Mô tả:";
			// 
			// btnUpAdd
			// 
			this.btnUpAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnUpAdd.BackgroundImage = global::DrThemShopAdmin.Properties.Resources.icons8_up_20;
			this.btnUpAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUpAdd.Location = new System.Drawing.Point(11, 2);
			this.btnUpAdd.Name = "btnUpAdd";
			this.btnUpAdd.Size = new System.Drawing.Size(20, 20);
			this.btnUpAdd.TabIndex = 13;
			this.btnUpAdd.TabStop = false;
			this.btnUpAdd.Click += new System.EventHandler(this.btnUpAdd_Click);
			// 
			// btnDownAdd
			// 
			this.btnDownAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnDownAdd.BackgroundImage = global::DrThemShopAdmin.Properties.Resources.down_blueStyle;
			this.btnDownAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnDownAdd.Location = new System.Drawing.Point(11, 2);
			this.btnDownAdd.Name = "btnDownAdd";
			this.btnDownAdd.Size = new System.Drawing.Size(20, 20);
			this.btnDownAdd.TabIndex = 14;
			this.btnDownAdd.TabStop = false;
			this.btnDownAdd.Click += new System.EventHandler(this.btnDownAdd_Click);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(113, 34);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(224, 22);
			this.txtProductName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Tên sản phẩm:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(969, 34);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(148, 92);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Thêm mới";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblSequenceDetailHeader
			// 
			this.lblSequenceDetailHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblSequenceDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblSequenceDetailHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblSequenceDetailHeader.ForeColor = System.Drawing.Color.Black;
			this.lblSequenceDetailHeader.Location = new System.Drawing.Point(0, 0);
			this.lblSequenceDetailHeader.Name = "lblSequenceDetailHeader";
			this.lblSequenceDetailHeader.Size = new System.Drawing.Size(1200, 24);
			this.lblSequenceDetailHeader.TabIndex = 0;
			this.lblSequenceDetailHeader.Text = "         Thêm Sản phẩm";
			this.lblSequenceDetailHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnDownSearch
			// 
			this.btnDownSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnDownSearch.BackgroundImage = global::DrThemShopAdmin.Properties.Resources.down_blueStyle;
			this.btnDownSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnDownSearch.Location = new System.Drawing.Point(11, 2);
			this.btnDownSearch.Name = "btnDownSearch";
			this.btnDownSearch.Size = new System.Drawing.Size(20, 20);
			this.btnDownSearch.TabIndex = 15;
			this.btnDownSearch.TabStop = false;
			this.btnDownSearch.Click += new System.EventHandler(this.btnDownSearch_Click);
			// 
			// pnlSequenceList
			// 
			this.pnlSequenceList.Controls.Add(this.pnMainLeft);
			this.pnlSequenceList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSequenceList.Location = new System.Drawing.Point(0, 0);
			this.pnlSequenceList.Name = "pnlSequenceList";
			this.pnlSequenceList.Size = new System.Drawing.Size(1200, 592);
			this.pnlSequenceList.TabIndex = 305;
			// 
			// pnMainLeft
			// 
			this.pnMainLeft.Controls.Add(this.panel3);
			this.pnMainLeft.Controls.Add(this.pnlSearch);
			this.pnMainLeft.Controls.Add(this.lineBottom1);
			this.pnMainLeft.Controls.Add(this.lineTop1);
			this.pnMainLeft.Controls.Add(this.bvProduct);
			this.pnMainLeft.Controls.Add(this.pnlAdd);
			this.pnMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMainLeft.Location = new System.Drawing.Point(0, 0);
			this.pnMainLeft.Name = "pnMainLeft";
			this.pnMainLeft.Size = new System.Drawing.Size(1200, 592);
			this.pnMainLeft.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel3.Location = new System.Drawing.Point(0, 201);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1200, 365);
			this.panel3.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dgvProduct);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 24);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1200, 341);
			this.panel4.TabIndex = 4;
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
			this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProduct.ColumnHeadersHeight = 25;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colProductImage,
            this.colPrice,
            this.colCategoryName,
            this.colUnit,
            this.colContent});
			this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProduct.GridColor = System.Drawing.Color.DeepSkyBlue;
			this.dgvProduct.Location = new System.Drawing.Point(0, 0);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowHeadersWidth = 25;
			this.dgvProduct.RowTemplate.Height = 25;
			this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProduct.Size = new System.Drawing.Size(1200, 341);
			this.dgvProduct.TabIndex = 2;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			this.dgvProduct.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMNH_CellValidated);
			this.dgvProduct.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDMNH_CellValidating);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(lblSequenceListHeader);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1200, 24);
			this.panel2.TabIndex = 3;
			// 
			// pnlSearch
			// 
			this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
			this.pnlSearch.Controls.Add(this.cbCategorySearch);
			this.pnlSearch.Controls.Add(this.label10);
			this.pnlSearch.Controls.Add(this.btnUpSearch);
			this.pnlSearch.Controls.Add(this.btnDownSearch);
			this.pnlSearch.Controls.Add(this.lineBottom2);
			this.pnlSearch.Controls.Add(this.txtSearch);
			this.pnlSearch.Controls.Add(this.label3);
			this.pnlSearch.Controls.Add(this.btnSearch);
			this.pnlSearch.Controls.Add(this.label5);
			this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlSearch.Location = new System.Drawing.Point(0, 136);
			this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(1200, 65);
			this.pnlSearch.TabIndex = 13;
			// 
			// cbCategorySearch
			// 
			this.cbCategorySearch.AutoComplete = false;
			this.cbCategorySearch.AutoDropdown = false;
			this.cbCategorySearch.BackColorEven = System.Drawing.Color.White;
			this.cbCategorySearch.BackColorOdd = System.Drawing.Color.LightBlue;
			this.cbCategorySearch.ColumnNames = "CategoryID,CategoryName";
			this.cbCategorySearch.ColumnWidthDefault = 75;
			this.cbCategorySearch.ColumnWidths = "50,200";
			this.cbCategorySearch.DisplayMember = "CategoryName";
			this.cbCategorySearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cbCategorySearch.FormattingEnabled = true;
			this.cbCategorySearch.LinkedColumnIndex = 0;
			this.cbCategorySearch.LinkedTextBox = null;
			this.cbCategorySearch.Location = new System.Drawing.Point(87, 33);
			this.cbCategorySearch.Name = "cbCategorySearch";
			this.cbCategorySearch.Size = new System.Drawing.Size(182, 23);
			this.cbCategorySearch.TabIndex = 30;
			this.cbCategorySearch.ValueMember = "CategoryID";
			this.cbCategorySearch.SelectionChangeCommitted += new System.EventHandler(this.cbCategorySearch_SelectionChangeCommitted);
			this.cbCategorySearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCategorySearch_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(11, 36);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 16);
			this.label10.TabIndex = 29;
			this.label10.Text = "Danh mục:";
			// 
			// btnUpSearch
			// 
			this.btnUpSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnUpSearch.BackgroundImage = global::DrThemShopAdmin.Properties.Resources.icons8_up_20;
			this.btnUpSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUpSearch.Location = new System.Drawing.Point(11, 2);
			this.btnUpSearch.Name = "btnUpSearch";
			this.btnUpSearch.Size = new System.Drawing.Size(20, 20);
			this.btnUpSearch.TabIndex = 14;
			this.btnUpSearch.TabStop = false;
			this.btnUpSearch.Click += new System.EventHandler(this.btnUpSearch_Click);
			// 
			// lineBottom2
			// 
			this.lineBottom2.BackColor = System.Drawing.Color.Gray;
			this.lineBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lineBottom2.Location = new System.Drawing.Point(0, 64);
			this.lineBottom2.Name = "lineBottom2";
			this.lineBottom2.Size = new System.Drawing.Size(1200, 1);
			this.lineBottom2.TabIndex = 13;
			this.lineBottom2.Text = "lineBottom2";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(360, 33);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(195, 22);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(286, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tìm kiếm:";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(561, 31);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(108, 26);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1200, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "         Tìm kiếm Sản phẩm";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lineBottom1
			// 
			this.lineBottom1.BackColor = System.Drawing.Color.Gray;
			this.lineBottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lineBottom1.Location = new System.Drawing.Point(0, 566);
			this.lineBottom1.Name = "lineBottom1";
			this.lineBottom1.Size = new System.Drawing.Size(1200, 1);
			this.lineBottom1.TabIndex = 9;
			this.lineBottom1.Text = "lineBottom1";
			// 
			// lineTop1
			// 
			this.lineTop1.BackColor = System.Drawing.Color.Gray;
			this.lineTop1.Dock = System.Windows.Forms.DockStyle.Top;
			this.lineTop1.Location = new System.Drawing.Point(0, 135);
			this.lineTop1.Name = "lineTop1";
			this.lineTop1.Size = new System.Drawing.Size(1200, 1);
			this.lineTop1.TabIndex = 8;
			this.lineTop1.Text = "lineTop1";
			// 
			// bvProduct
			// 
			this.bvProduct.AddNewItem = null;
			this.bvProduct.CountItem = this.bindingNavigatorCountItem2;
			this.bvProduct.CountItemFormat = "/ {0}";
			this.bvProduct.DeleteItem = null;
			this.bvProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bvProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bvProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator14,
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.tsbRefresh,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.toolStripSeparator1});
			this.bvProduct.Location = new System.Drawing.Point(0, 567);
			this.bvProduct.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
			this.bvProduct.MoveLastItem = this.bindingNavigatorMoveLastItem2;
			this.bvProduct.MoveNextItem = this.bindingNavigatorMoveNextItem2;
			this.bvProduct.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
			this.bvProduct.Name = "bvProduct";
			this.bvProduct.PositionItem = this.bindingNavigatorPositionItem2;
			this.bvProduct.Size = new System.Drawing.Size(1200, 25);
			this.bvProduct.TabIndex = 7;
			this.bvProduct.Text = "bindingNavigator3";
			// 
			// bindingNavigatorCountItem2
			// 
			this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
			this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(30, 22);
			this.bindingNavigatorCountItem2.Text = "/ {0}";
			this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
			// 
			// toolStripSeparator14
			// 
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveFirstItem2
			// 
			this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
			this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
			this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem2.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem2
			// 
			this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
			this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
			this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
			// 
			// bindingNavigatorSeparator6
			// 
			this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
			this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem2
			// 
			this.bindingNavigatorPositionItem2.AccessibleName = "Position";
			this.bindingNavigatorPositionItem2.AutoSize = false;
			this.bindingNavigatorPositionItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
			this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(30, 22);
			this.bindingNavigatorPositionItem2.Text = "0";
			this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator7
			// 
			this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
			this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem2
			// 
			this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
			this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
			this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem2.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem2
			// 
			this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
			this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
			this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem2.Text = "Move last";
			// 
			// bindingNavigatorSeparator8
			// 
			this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
			this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbRefresh
			// 
			this.tsbRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsbRefresh.ForeColor = System.Drawing.Color.Green;
			this.tsbRefresh.Image = global::DrThemShopAdmin.Properties.Resources.icons8_refresh_20;
			this.tsbRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRefresh.Name = "tsbRefresh";
			this.tsbRefresh.Size = new System.Drawing.Size(84, 22);
			this.tsbRefresh.Text = "Làm mới";
			this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbDelete
			// 
			this.tsbDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsbDelete.ForeColor = System.Drawing.Color.Red;
			this.tsbDelete.Image = global::DrThemShopAdmin.Properties.Resources.delete_blueStyle;
			this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDelete.Name = "tsbDelete";
			this.tsbDelete.Size = new System.Drawing.Size(60, 22);
			this.tsbDelete.Text = "  Xóa";
			this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// colProductID
			// 
			this.colProductID.DataPropertyName = "ProductID";
			this.colProductID.HeaderText = "Mã sản phẩm";
			this.colProductID.Name = "colProductID";
			this.colProductID.ReadOnly = true;
			// 
			// colProductName
			// 
			this.colProductName.DataPropertyName = "ProductName";
			this.colProductName.FillWeight = 200F;
			this.colProductName.HeaderText = "Tên sản phẩm";
			this.colProductName.Name = "colProductName";
			// 
			// colProductImage
			// 
			this.colProductImage.DataPropertyName = "ProductImage";
			this.colProductImage.HeaderText = "Hình ảnh";
			this.colProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.colProductImage.Name = "colProductImage";
			// 
			// colPrice
			// 
			this.colPrice.DataPropertyName = "Price";
			this.colPrice.HeaderText = "Giá";
			this.colPrice.Name = "colPrice";
			// 
			// colCategoryName
			// 
			this.colCategoryName.DataPropertyName = "CategoryName";
			this.colCategoryName.FillWeight = 150F;
			this.colCategoryName.HeaderText = "Danh mục";
			this.colCategoryName.Name = "colCategoryName";
			this.colCategoryName.ReadOnly = true;
			// 
			// colUnit
			// 
			this.colUnit.DataPropertyName = "Unit";
			this.colUnit.HeaderText = "Đơn vị";
			this.colUnit.Name = "colUnit";
			// 
			// colContent
			// 
			this.colContent.DataPropertyName = "Content";
			this.colContent.HeaderText = "Mô tả";
			this.colContent.Name = "colContent";
			// 
			// FrmProduct
			// 
			this.ClientSize = new System.Drawing.Size(1202, 634);
			this.FormHeader = "QUẢN LÝ SẢN PHẨM";
			this.Name = "FrmProduct";
			this.Text = "Quản lý Sản phẩm";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			this.pnlMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.pnlAdd.ResumeLayout(false);
			this.pnlAdd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownSearch)).EndInit();
			this.pnlSequenceList.ResumeLayout(false);
			this.pnMainLeft.ResumeLayout(false);
			this.pnMainLeft.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnUpSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bvProduct)).EndInit();
			this.bvProduct.ResumeLayout(false);
			this.bvProduct.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAdd;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblSequenceDetailHeader;
		private System.Windows.Forms.Panel pnlSequenceList;
		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.BindingNavigator bvProduct;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
		private System.Windows.Forms.ToolStripButton tsbDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Panel pnMainLeft;
		private DrThemShop.WinLibrary.CustomControl.LineBottom lineBottom1;
		private DrThemShop.WinLibrary.CustomControl.LineTop lineTop1;
        private System.Windows.Forms.Panel panel3;
        private DrThemShop.WinLibrary.CustomControl.ButtonImg btnUpAdd;
        private System.Windows.Forms.Panel pnlSearch;
        private DrThemShop.WinLibrary.CustomControl.LineBottom lineBottom2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private DrThemShop.WinLibrary.CustomControl.ButtonImg btnUpSearch;
        private DrThemShop.WinLibrary.CustomControl.ButtonImg btnDownSearch;
        private DrThemShop.WinLibrary.CustomControl.ButtonImg btnDownAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbProductImage;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label6;
		private MultiColumnComboBox.MultiColumnComboBox cbCategory;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnClearImage;
		private MultiColumnComboBox.MultiColumnComboBox cbCategorySearch;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
		private System.Windows.Forms.DataGridViewImageColumn colProductImage;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
	}
}
