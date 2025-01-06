using DrThemShop.WinLibrary;
using System;
using System.Windows.Forms;

namespace DrThemShopAdmin.View
{
	public partial class FrmReasonCancel : FrmBaseForm
	{
		public string ReasonCancel { get; set; }

		public FrmReasonCancel()
		{
			InitializeComponent();
		}

		private void FrmReasonCancel_Load(object sender, EventArgs e)
		{
			txtReasonCancel.Text = string.Empty;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txtReasonCancel.Text))
			{
				MessageBox.Show("Vui lòng nhập lý do", "Cảnh báo");
				txtReasonCancel.Focus();
				return;
			}
			ReasonCancel = txtReasonCancel.Text;
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
