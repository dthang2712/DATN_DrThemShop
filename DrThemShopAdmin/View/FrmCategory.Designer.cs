namespace DrThemShopAdmin.View
{
	partial class FrmCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
			this.pnlAdd = new System.Windows.Forms.Panel();
			this.btnImage = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnUpAdd = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.btnDownAdd = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblSequenceDetailHeader = new System.Windows.Forms.Label();
			this.btnDownSearch = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.pnlSequenceList = new System.Windows.Forms.Panel();
			this.pnMainLeft = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dgvCategory = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.btnUpSearch = new DrThemShop.WinLibrary.CustomControl.ButtonImg(this.components);
			this.lineBottom2 = new DrThemShop.WinLibrary.CustomControl.LineBottom();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lineBottom1 = new DrThemShop.WinLibrary.CustomControl.LineBottom();
			this.lineTop1 = new DrThemShop.WinLibrary.CustomControl.LineTop();
			this.bvCategory = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.btnClearImage = new System.Windows.Forms.Button();
			this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
			lblSequenceListHeader = new System.Windows.Forms.Label();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.pnlAdd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownSearch)).BeginInit();
			this.pnlSequenceList.SuspendLayout();
			this.pnMainLeft.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnUpSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bvCategory)).BeginInit();
			this.bvCategory.SuspendLayout();
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
			this.lblHeader.Text = "QUẢN LÝ DANH MỤC";
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
			lblSequenceListHeader.Text = "         Danh sách Danh mục";
			lblSequenceListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlAdd
			// 
			this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
			this.pnlAdd.Controls.Add(this.btnClearImage);
			this.pnlAdd.Controls.Add(this.btnImage);
			this.pnlAdd.Controls.Add(this.label2);
			this.pnlAdd.Controls.Add(this.pbImage);
			this.pnlAdd.Controls.Add(this.txtDescription);
			this.pnlAdd.Controls.Add(this.label4);
			this.pnlAdd.Controls.Add(this.btnUpAdd);
			this.pnlAdd.Controls.Add(this.btnDownAdd);
			this.pnlAdd.Controls.Add(this.txtCategoryName);
			this.pnlAdd.Controls.Add(this.label1);
			this.pnlAdd.Controls.Add(this.btnSave);
			this.pnlAdd.Controls.Add(this.lblSequenceDetailHeader);
			this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlAdd.Location = new System.Drawing.Point(0, 0);
			this.pnlAdd.Margin = new System.Windows.Forms.Padding(0);
			this.pnlAdd.Name = "pnlAdd";
			this.pnlAdd.Size = new System.Drawing.Size(1200, 200);
			this.pnlAdd.TabIndex = 2;
			// 
			// btnImage
			// 
			this.btnImage.Location = new System.Drawing.Point(276, 119);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(29, 74);
			this.btnImage.TabIndex = 21;
			this.btnImage.Text = "...";
			this.btnImage.UseVisualStyleBackColor = true;
			this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Hình ảnh:";
			// 
			// pbImage
			// 
			this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbImage.Image = global::DrThemShopAdmin.Properties.Resources.icons8_cloud_cross_80;
			this.pbImage.Location = new System.Drawing.Point(113, 119);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(158, 74);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImage.TabIndex = 19;
			this.pbImage.TabStop = false;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(113, 62);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(224, 51);
			this.txtDescription.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 79);
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
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(113, 34);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(224, 22);
			this.txtCategoryName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Tên danh mục:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(343, 34);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(131, 159);
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
			this.lblSequenceDetailHeader.Text = "         Thêm Danh mục";
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
			this.pnMainLeft.Controls.Add(this.bvCategory);
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
			this.panel3.Location = new System.Drawing.Point(0, 266);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1200, 300);
			this.panel3.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dgvCategory);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 24);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1200, 276);
			this.panel4.TabIndex = 4;
			// 
			// dgvCategory
			// 
			this.dgvCategory.AllowUserToAddRows = false;
			this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
			this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCategory.ColumnHeadersHeight = 25;
			this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colDescription,
            this.colImage});
			this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCategory.GridColor = System.Drawing.Color.DeepSkyBlue;
			this.dgvCategory.Location = new System.Drawing.Point(0, 0);
			this.dgvCategory.Name = "dgvCategory";
			this.dgvCategory.RowHeadersWidth = 25;
			this.dgvCategory.RowTemplate.Height = 25;
			this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCategory.Size = new System.Drawing.Size(1200, 276);
			this.dgvCategory.TabIndex = 2;
			this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
			this.dgvCategory.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMNH_CellValidated);
			this.dgvCategory.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDMNH_CellValidating);
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
			this.pnlSearch.Controls.Add(this.btnUpSearch);
			this.pnlSearch.Controls.Add(this.btnDownSearch);
			this.pnlSearch.Controls.Add(this.lineBottom2);
			this.pnlSearch.Controls.Add(this.txtSearch);
			this.pnlSearch.Controls.Add(this.label3);
			this.pnlSearch.Controls.Add(this.btnSearch);
			this.pnlSearch.Controls.Add(this.label5);
			this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlSearch.Location = new System.Drawing.Point(0, 201);
			this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(1200, 65);
			this.pnlSearch.TabIndex = 13;
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
			this.txtSearch.Location = new System.Drawing.Point(91, 32);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(195, 22);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tìm kiếm:";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(292, 30);
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
			this.label5.Text = "         Tìm kiếm Danh mục";
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
			this.lineTop1.Location = new System.Drawing.Point(0, 200);
			this.lineTop1.Name = "lineTop1";
			this.lineTop1.Size = new System.Drawing.Size(1200, 1);
			this.lineTop1.TabIndex = 8;
			this.lineTop1.Text = "lineTop1";
			// 
			// bvCategory
			// 
			this.bvCategory.AddNewItem = null;
			this.bvCategory.CountItem = this.bindingNavigatorCountItem2;
			this.bvCategory.CountItemFormat = "/ {0}";
			this.bvCategory.DeleteItem = null;
			this.bvCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bvCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bvCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.bvCategory.Location = new System.Drawing.Point(0, 567);
			this.bvCategory.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
			this.bvCategory.MoveLastItem = this.bindingNavigatorMoveLastItem2;
			this.bvCategory.MoveNextItem = this.bindingNavigatorMoveNextItem2;
			this.bvCategory.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
			this.bvCategory.Name = "bvCategory";
			this.bvCategory.PositionItem = this.bindingNavigatorPositionItem2;
			this.bvCategory.Size = new System.Drawing.Size(1200, 25);
			this.bvCategory.TabIndex = 7;
			this.bvCategory.Text = "bindingNavigator3";
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
			// btnClearImage
			// 
			this.btnClearImage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearImage.Location = new System.Drawing.Point(308, 119);
			this.btnClearImage.Name = "btnClearImage";
			this.btnClearImage.Size = new System.Drawing.Size(29, 74);
			this.btnClearImage.TabIndex = 22;
			this.btnClearImage.Text = "X";
			this.btnClearImage.UseVisualStyleBackColor = true;
			this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
			// 
			// colCategoryID
			// 
			this.colCategoryID.DataPropertyName = "CategoryID";
			this.colCategoryID.FillWeight = 50F;
			this.colCategoryID.HeaderText = "Mã danh mục";
			this.colCategoryID.Name = "colCategoryID";
			this.colCategoryID.ReadOnly = true;
			// 
			// colCategoryName
			// 
			this.colCategoryName.DataPropertyName = "CategoryName";
			this.colCategoryName.FillWeight = 200F;
			this.colCategoryName.HeaderText = "Tên danh mục";
			this.colCategoryName.Name = "colCategoryName";
			// 
			// colDescription
			// 
			this.colDescription.DataPropertyName = "Description";
			this.colDescription.FillWeight = 150F;
			this.colDescription.HeaderText = "Mô tả";
			this.colDescription.Name = "colDescription";
			// 
			// colImage
			// 
			this.colImage.DataPropertyName = "Image";
			this.colImage.FillWeight = 120F;
			this.colImage.HeaderText = "Hình ảnh";
			this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.colImage.Name = "colImage";
			// 
			// FrmCategory
			// 
			this.ClientSize = new System.Drawing.Size(1202, 634);
			this.FormHeader = "QUẢN LÝ DANH MỤC";
			this.Name = "FrmCategory";
			this.Text = "Quản lý Danh mục";
			this.Load += new System.EventHandler(this.FrmCategory_Load);
			this.pnlMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.pnlAdd.ResumeLayout(false);
			this.pnlAdd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDownSearch)).EndInit();
			this.pnlSequenceList.ResumeLayout(false);
			this.pnMainLeft.ResumeLayout(false);
			this.pnMainLeft.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnUpSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bvCategory)).EndInit();
			this.bvCategory.ResumeLayout(false);
			this.bvCategory.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAdd;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblSequenceDetailHeader;
		private System.Windows.Forms.Panel pnlSequenceList;
		private System.Windows.Forms.DataGridView dgvCategory;
		private System.Windows.Forms.BindingNavigator bvCategory;
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
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Button btnClearImage;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewImageColumn colImage;
	}
}
