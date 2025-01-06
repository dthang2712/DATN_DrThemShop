using DrThemShop.WinLibrary;
using DrThemShop.WinLibrary.BusinessService;
using DrThemShop.WinLibrary.CustomControl;
using DrThemShop.WinLibrary.Helper;
using DrThemShopAdmin.Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DrThemShopAdmin.View
{
    public partial class FrmProduct : FrmBaseForm
    {
        #region Object Ori

        public class ProductDetail : ProductService.ProductInfo
        {
            public string OriProductName { get; set; }
            public byte[] OriProductImage { get; set; }
            public double OriPrice { get; set; }
            public int OriCategoryID { get; set; }
            public string OriUnit { get; set; }
            public string OriContent { get; set; }

            public bool IsChanged
            {
                get
                {
                    var compare = string.Compare(OriProductName, ProductName);
                    compare = compare == 0 ? (StructuralComparisons.StructuralEqualityComparer.Equals(OriProductImage, ProductImage) ? 0 : 1) : compare;
                    compare = compare == 0 ? OriPrice.CompareTo(Price) : compare;
                    compare = compare == 0 ? OriCategoryID.CompareTo(CategoryID) : compare;
                    compare = compare == 0 ? string.Compare(OriUnit, Unit) : compare;
                    compare = compare == 0 ? string.Compare(OriContent, Content) : compare;

                    return compare != 0;
                }
            }

            public ProductDetail(ProductService.ProductInfo ori)
            {
                this.CopyValue(ori);
                this.ResetOriginal();
            }

            public void ResetOriginal()
            {
                this.OriProductName = this.ProductName;
                this.OriProductImage = this.ProductImage;
                this.OriPrice = this.Price;
                this.OriCategoryID = this.CategoryID;
                this.OriUnit = this.Unit;
                this.OriContent = this.Content;
            }
        }

        #endregion

        #region Define variable

        private BindingList<ProductService.ProductInfo> _listProduct = new BindingList<ProductService.ProductInfo>();
        private BindingList<CategoryService.CategoryInfo> _listComboCategory = new BindingList<CategoryService.CategoryInfo>();
        private BindingList<CategoryService.CategoryInfo> _listComboCategorySearch = new BindingList<CategoryService.CategoryInfo>();

        #endregion

        public FrmProduct()
        {
            InitializeComponent();

            dgvProduct.AutoGenerateColumns = false;
            BindingSource _sourceProduct = new BindingSource();
            _sourceProduct.DataSource = _listProduct;
            dgvProduct.DataSource = _sourceProduct;
            bvProduct.BindingSource = _sourceProduct;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProduct();
                LoadComboBoxCategory();
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void LoadProduct(string search = null, int? categoryID = null)
        {
            _listProduct.RaiseListChangedEvents = false;
            _listProduct.Clear();

            var responseListProduct = ProductService.GetInstance().GetListProduct(search, categoryID);

            if (responseListProduct.IsSuccess)
            {
                foreach (var itemProduct in responseListProduct.Data)
                {
                    _listProduct.Add(new ProductDetail(itemProduct));
                }
            }
            else
            {
                throw new Exception(responseListProduct.Err.MsgString);
            }

            _listProduct.RaiseListChangedEvents = true;
            _listProduct.ResetBindings();
        }

        private void LoadComboBoxCategory()
        {
            _listComboCategory.RaiseListChangedEvents = false;
            _listComboCategorySearch.RaiseListChangedEvents = false;

            _listComboCategory.Clear();
            _listComboCategorySearch.Clear();

            var response = CategoryService.GetInstance().GetListCategory();

            if (response.IsSuccess)
            {
                foreach (var item in response.Data)
                {
                    _listComboCategory.Add(item);
                    _listComboCategorySearch.Add(item);
                }
            }
            else
            {
                throw new Exception(response.Err.MsgString);
            }

            _listComboCategory.RaiseListChangedEvents = true;
            _listComboCategorySearch.RaiseListChangedEvents = true;

            _listComboCategory.ResetBindings();
            _listComboCategorySearch.ResetBindings();

            cbCategory.DataSource = _listComboCategory;
            cbCategory.SelectedIndex = -1;

            cbCategorySearch.DataSource = _listComboCategory;
            cbCategorySearch.SelectedIndex = -1;
        }

        private void ResetDataProduct()
        {
            txtProductName.Text = string.Empty;
            pbProductImage.Image = new Bitmap(Resources.icons8_cloud_cross_80);
            txtPrice.Text = string.Empty;
            cbCategory.SelectedIndex = -1;
            txtUnit.Text = string.Empty;
            txtContent.Text = string.Empty;
            txtSearch.Text = string.Empty;

            LoadProduct();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProduct();
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void SaveProduct()
        {
            var itemCategorySelected = cbCategory.SelectedItem as CategoryService.CategoryInfo;

            if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
            {
                throw new Exception("Chưa nhập tên Sản phẩm (Tên không được là ký tự trống)!");
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                throw new Exception("Chưa nhập Giá!");
            }
            if (!int.TryParse(txtPrice.Text, out int parsedValue))
            {
                throw new Exception("Giá nhập phải là dạng số!");
            }
            if (itemCategorySelected == null)
            {
                throw new Exception("Chưa chọn Danh mục!");
            }
            if (string.IsNullOrEmpty(txtUnit.Text))
            {
                throw new Exception("Chưa nhập Đơn vị!");
            }

            ImageConverter converter = new ImageConverter();
            var imageInsert = (byte[])converter.ConvertTo(pbProductImage.Image, typeof(byte[]));

			imageInsert = CommonUtils.CompressImageToSize(imageInsert, 100);

			var response = ProductService.GetInstance().InsertProduct(new ProductService.ProductInfo
			{
				ProductName = txtProductName.Text,
				ProductImage = imageInsert,
				Price = int.Parse(txtPrice.Text),
				CategoryID = itemCategorySelected.CategoryID,
				Unit = txtUnit.Text,
				Content = txtContent.Text
			});

            if (response.IsSuccess)
            {
                CommonUtils_Win.Alert("Thêm sản phẩm mới thành công!", FrmAlert.enmType.Success);
                ResetDataProduct();
            }
            else
            {
                throw new Exception(response.Err.MsgString);
            }
        }

        private void btnUpAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Height = 24;
            btnUpAdd.Visible = false;
            btnDownAdd.Visible = true;
        }

        private void btnDownAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Height = 135;
            btnUpAdd.Visible = true;
            btnDownAdd.Visible = false;
        }

        private void btnUpSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Height = 24;
            btnUpSearch.Visible = false;
            btnDownSearch.Visible = true;
        }

        private void btnDownSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Height = 65;
            btnUpSearch.Visible = true;
            btnDownSearch.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var itemCategorySearch = cbCategorySearch.SelectedItem as CategoryService.CategoryInfo;

                if (itemCategorySearch != null)
                {
                    LoadProduct(txtSearch.Text.Trim(), itemCategorySearch.CategoryID);
                }
                else
                {
                    LoadProduct(txtSearch.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ResetDataProduct();
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentRow != null)
                {
                    var item = this.dgvProduct.CurrentRow.DataBoundItem as ProductDetail;

                    if (item != null)
                    {
                        if (MessageBox.Show($"Vui lòng xác nhận xóa Sản phẩm mã: [{item.ProductID}], tên: [{item.ProductName}]!",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                        {
                            var response = ProductService.GetInstance().DeleteProduct(item.ProductID);

                            if (response.IsSuccess)
                            {
                                CommonUtils_Win.Alert("Xóa sản phẩm thành công!", FrmAlert.enmType.Success);
                                LoadProduct();
                            }
                            else
                            {
                                throw new Exception(response.Err.MsgString);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void dgvDMNH_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == colProductName.Index)
                {
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        throw new Exception("Giá trị Tên sản phẩm không được trống!");
                    }
                }

                if (e.ColumnIndex == colPrice.Index)
                {
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        throw new Exception("Giá trị Giá sản phẩm không được trống!");
                    }
                    else if (!int.TryParse(e.FormattedValue.ToString(), out var price))
                    {
                        throw new Exception("Giá trị Giá sản phẩm phải là số!");
                    }
                }

                if (e.ColumnIndex == colUnit.Index)
                {
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        throw new Exception("Giá trị Đơn vị không được trống!");
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
                e.Cancel = true;
            }
        }

		private void dgvDMNH_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var item = dgvProduct.Rows[e.RowIndex].DataBoundItem as ProductDetail;
				if (item != null && item.IsChanged)
				{
					if (item.ProductImage != null)
					{
						item.ProductImage = CommonUtils.CompressImageToSize(item.ProductImage, 100);
					}

					var response = ProductService.GetInstance().UpdateProduct(item);

                    if (response.IsSuccess)
                    {
                        CommonUtils_Win.Alert("Cập nhật thông tin sản phẩm thành công!", FrmAlert.enmType.Success);
                    }
                    else
                    {
                        throw new Exception(response.Err.MsgString);
                    }

                    item.ResetOriginal();
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var itemCategorySearch = cbCategorySearch.SelectedItem as CategoryService.CategoryInfo;

                    if (itemCategorySearch != null)
                    {
                        LoadProduct(txtSearch.Text.Trim(), itemCategorySearch.CategoryID);
                    }
                    else
                    {
                        LoadProduct(txtSearch.Text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Chọn hình ảnh";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pbProductImage.Image = new Bitmap(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pbProductImage.Image = new Bitmap(Resources.icons8_cloud_cross_80);
        }

        private void cbCategorySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSearch.Focus();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == colProductImage.Index)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Title = "Chọn hình ảnh";
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            dgvProduct.Rows[e.RowIndex].Cells[colProductImage.Index].Value = new Bitmap(openFileDialog.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void cbCategorySearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var itemCategorySearch = cbCategorySearch.SelectedItem as CategoryService.CategoryInfo;

                if (itemCategorySearch != null)
                {
                    LoadProduct(txtSearch.Text.Trim(), itemCategorySearch.CategoryID);
                }
                else
                {
                    LoadProduct(txtSearch.Text.Trim());
                }

            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }
    }
}
