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
    public partial class FrmCategory : FrmBaseForm
    {
        #region Object Ori

        public class CategoryDetail : CategoryService.CategoryInfo
        {
            public string OriCategoryName { get; set; }
            public string OriDescription { get; set; }
            public byte[] OriImage { get; set; }

            public bool IsChanged
            {
                get
                {
                    var compare = string.Compare(OriCategoryName, CategoryName);
                    compare = compare == 0 ? string.Compare(OriDescription, Description) : compare;
                    compare = compare == 0 ? (StructuralComparisons.StructuralEqualityComparer.Equals(OriImage, Image) ? 0 : 1) : compare;

                    return compare != 0;
                }
            }

            public CategoryDetail(CategoryService.CategoryInfo ori)
            {
                this.CopyValue(ori);
                this.ResetOriginal();
            }

            public void ResetOriginal()
            {
                this.OriCategoryName = this.CategoryName;
                this.OriDescription = this.Description;
                this.OriImage = this.Image;
            }
        }

        #endregion

        #region Define variable

        private BindingList<CategoryService.CategoryInfo> _listCategory = new BindingList<CategoryService.CategoryInfo>();
        #endregion

        public FrmCategory()
        {
            InitializeComponent();

            dgvCategory.AutoGenerateColumns = false;
            BindingSource _sourceCategory = new BindingSource();
            _sourceCategory.DataSource = _listCategory;
            dgvCategory.DataSource = _sourceCategory;
            bvCategory.BindingSource = _sourceCategory;
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategory();
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void LoadCategory(string search = null)
        {
            _listCategory.RaiseListChangedEvents = false;
            _listCategory.Clear();

            var responseListCategory = CategoryService.GetInstance().GetListCategory(search);

            if (responseListCategory.IsSuccess)
            {
                foreach (var itemCategory in responseListCategory.Data)
                {
                    _listCategory.Add(new CategoryDetail(itemCategory));
                }
            }
            else
            {
                throw new Exception(responseListCategory.Err.MsgString);
            }

            _listCategory.RaiseListChangedEvents = true;
            _listCategory.ResetBindings();
        }

        private void ResetDataCategory()
        {
            txtCategoryName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            pbImage.Image = new Bitmap(Resources.icons8_cloud_cross_80);
            txtSearch.Text = string.Empty;

            LoadCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCategory();
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void SaveCategory()
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                throw new Exception("Chưa nhập tên Danh mục (Tên không được là ký tự trống)!");
            }

            ImageConverter converter = new ImageConverter();
            var imageInsert = (byte[])converter.ConvertTo(pbImage.Image, typeof(byte[]));

			imageInsert = CommonUtils.CompressImageToSize(imageInsert, 100);

			var response = CategoryService.GetInstance().InsertCategory(new CategoryService.CategoryInfo
			{
				CategoryName = txtCategoryName.Text,
				Description = txtDescription.Text,
				Image = imageInsert,
			});

            if (response.IsSuccess)
            {
                CommonUtils_Win.Alert("Thêm danh mục mới thành công!", FrmAlert.enmType.Success);
                ResetDataCategory();
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
            pnlAdd.Height = 200;
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
                LoadCategory(txtSearch.Text.Trim());
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
                ResetDataCategory();
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
                if (dgvCategory.CurrentRow != null)
                {
                    var item = this.dgvCategory.CurrentRow.DataBoundItem as CategoryDetail;

                    if (item != null)
                    {
                        if (MessageBox.Show($"Vui lòng xác nhận xóa danh mục mã: [{item.CategoryID}], tên: [{item.CategoryName}]!",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                        {
                            var response = CategoryService.GetInstance().DeleteCategory(item.CategoryID);

                            if (response.IsSuccess)
                            {
                                CommonUtils_Win.Alert("Xóa danh mục thành công!", FrmAlert.enmType.Success);
                                LoadCategory();
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
                if (e.ColumnIndex == colCategoryName.Index)
                {
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        throw new Exception("Giá trị tên danh mục không được trống!");
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
				var item = dgvCategory.Rows[e.RowIndex].DataBoundItem as CategoryDetail;
				if (item != null && item.IsChanged)
				{
					if (item.Image != null)
					{
						item.Image = CommonUtils.CompressImageToSize(item.Image, 100);
					}

					var response = CategoryService.GetInstance().UpdateCategory(item);

                    if (response.IsSuccess)
                    {
                        CommonUtils_Win.Alert("Cập nhật thông tin danh mục thành công!", FrmAlert.enmType.Success);
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
                    LoadCategory(txtSearch.Text.Trim());
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
                        pbImage.Image = new Bitmap(openFileDialog.FileName);
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
            pbImage.Image = new Bitmap(Resources.icons8_cloud_cross_80);
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == colImage.Index)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Title = "Chọn hình ảnh";
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            dgvCategory.Rows[e.RowIndex].Cells[colImage.Index].Value = new Bitmap(openFileDialog.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }
    }
}
