using DrThemShop.WinLibrary;
using DrThemShop.WinLibrary.BusinessService;
using DrThemShop.WinLibrary.CustomControl;
using DrThemShop.WinLibrary.Helper;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrThemShopAdmin.View
{
    public partial class FrmOrder : FrmBaseForm
    {
        private BindingList<OrderService.OrderInfo> _listOrder = new BindingList<OrderService.OrderInfo>();
        private BindingList<OrderDetailService.OrderDetailInfo> _listOrderDetail = new BindingList<OrderDetailService.OrderDetailInfo>();

        private OrderService.OrderInfo _selectedOrderInfo = new OrderService.OrderInfo();


        public FrmOrder()
        {
            InitializeComponent();

            dgvOrder.AutoGenerateColumns = false;
            BindingSource _sourceOrder = new BindingSource();
            _sourceOrder.DataSource = _listOrder;
            dgvOrder.DataSource = _sourceOrder;
            bvOrder.BindingSource = _sourceOrder;

            dgvOrderDetail.AutoGenerateColumns = false;
            BindingSource _sourceOrderDetail = new BindingSource();
            _sourceOrderDetail.DataSource = _listOrderDetail;
            dgvOrderDetail.DataSource = _sourceOrderDetail;
            bvOrderDetail.BindingSource = _sourceOrderDetail;
        }

		private void FrmOrder_Load(object sender, EventArgs e)
		{
			try
			{
				dtDateFrom.Value = DateTime.Now.Date.AddDays(-1);
				dtDateTo.Value = DateTime.Now.Date.AddDays(1);
				cbStatus.SelectedIndex = 4;

                LoadOrder();
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void LoadOrder()
        {
            _listOrder.RaiseListChangedEvents = false;
            _listOrder.Clear();

            var response = OrderService.GetInstance().GetListOrder(new OrderService.OrderFilterInfo
            {
                DateFrom = dtDateFrom.Value.Date,
                DateTo = dtDateTo.Value.Date,
                Status = cbStatus.SelectedIndex,
                Search = txtSearch.Text
            });

            if (response.IsSuccess)
            {
                foreach (var item in response.Data)
                {
                    _listOrder.Add(item);
                }
            }
            else
            {
                throw new Exception(response.Err.MsgString);
            }

			if (_listOrder.Count > 0)
			{
				if (_selectedOrderInfo != null && _selectedOrderInfo.OrderID > 0)
				{
					int _Index = 0;
					for (int i = 0; i < dgvOrder.Rows.Count; i++)
					{
						var item = dgvOrder.Rows[i].DataBoundItem as OrderService.OrderInfo;

                        if (item.OrderID == _selectedOrderInfo.OrderID)
                        {
                            _Index = i;
                        }
                    }

                    dgvOrder.CurrentCell = dgvOrder.Rows[_Index].Cells[colOrderID.Index];
                }
                else if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    int _Index = 0;
                    for (int i = 0; i < dgvOrder.Rows.Count; i++)
                    {
                        var item = dgvOrder.Rows[i].DataBoundItem as OrderService.OrderInfo;

                        if (item.OrderID.ToString().Contains(txtSearch.Text))
                        {
                            _Index = i;
                        }
                    }

                    dgvOrder.CurrentCell = dgvOrder.Rows[_Index].Cells[colOrderID.Index];
                    txtSearch.Focus();
                }
            }



            _listOrder.RaiseListChangedEvents = true;
            _listOrder.ResetBindings();
        }

        private void LoadOrderDetail()
        {
            _listOrderDetail.RaiseListChangedEvents = false;
            _listOrderDetail.Clear();

            var response = OrderDetailService.GetInstance().GetListOrderDetail(_selectedOrderInfo.OrderID);

            if (response.IsSuccess)
            {
                foreach (var item in response.Data)
                {
                    _listOrderDetail.Add(item);
                }
            }
            else
            {
                throw new Exception(response.Err.MsgString);
            }

            _listOrderDetail.RaiseListChangedEvents = true;
            _listOrderDetail.ResetBindings();
        }

        private void dgvOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrder.CurrentRow != null)
                {
                    _selectedOrderInfo = dgvOrder.CurrentRow.DataBoundItem as OrderService.OrderInfo;
                    DisplayOrderInfo();
                }
                else
                {
                    _selectedOrderInfo = null;
                }

            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

		private void DisplayOrderInfo()
		{
			if (_selectedOrderInfo != null)
			{
				txtOrderID.Text = _selectedOrderInfo.OrderID.ToString();
				txtCustomerName.Text = _selectedOrderInfo.CustomerName;
				txtRecipientName.Text = _selectedOrderInfo.RecipientName;
				txtRecipientPhoneNumber.Text = _selectedOrderInfo.RecipientPhoneNumber;
				txtRecipientAddress.Text = _selectedOrderInfo.RecipientAddress;
				txtRecipientNote.Text = _selectedOrderInfo.RecipientNote;
				txtOrderDate.Text = _selectedOrderInfo.OrderDate.HasValue ? _selectedOrderInfo.OrderDate.GetValueOrDefault().ToString("dd/MM/yyyy") : string.Empty;
				txtConfirmDate.Text = _selectedOrderInfo.ConfirmDate.HasValue ? _selectedOrderInfo.ConfirmDate.GetValueOrDefault().ToString("dd/MM/yyyy") : string.Empty;
				txtDeliveryDate.Text = _selectedOrderInfo.DeliveryDate.HasValue ? _selectedOrderInfo.DeliveryDate.GetValueOrDefault().ToString("dd/MM/yyyy") : string.Empty;
				txtCancelDate.Text = _selectedOrderInfo.CancelDate.HasValue ? _selectedOrderInfo.CancelDate.GetValueOrDefault().ToString("dd/MM/yyyy") : string.Empty;
				txtReasonCancel.Text = _selectedOrderInfo.ReasonCancel;

				switch (_selectedOrderInfo.Status)
				{
					case 0:
						btnConfirm.Enabled = true;
						btnSuccess.Enabled = false;
						btnCancel.Enabled = true;
						break;
					case 1:
						btnConfirm.Enabled = false;
						btnSuccess.Enabled = true;
						btnCancel.Enabled = true;
						break;
					case 2:
						btnConfirm.Enabled = false;
						btnSuccess.Enabled = false;
						btnCancel.Enabled = false;
						break;
					case 3:
						btnConfirm.Enabled = false;
						btnSuccess.Enabled = false;
						btnCancel.Enabled = false;
						break;
				}

				LoadOrderDetail();
			}
			else
			{
				txtOrderID.Text = string.Empty;
				txtCustomerName.Text = string.Empty;
				txtRecipientName.Text = string.Empty;
				txtRecipientPhoneNumber.Text = string.Empty;
				txtRecipientAddress.Text = string.Empty;
				txtRecipientNote.Text = string.Empty;
				txtOrderDate.Text = string.Empty;
				txtConfirmDate.Text = string.Empty;
				txtDeliveryDate.Text = string.Empty;
				txtCancelDate.Text = string.Empty;
				txtReasonCancel.Text = string.Empty;

				btnConfirm.Enabled = false;
				btnSuccess.Enabled = false;
				btnCancel.Enabled = false;

                _listOrderDetail.Clear();
            }
        }

        private void dgvOrderDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (_listOrderDetail.Any())
                {
                    double totalPrice = 0;

                    foreach (var item in _listOrderDetail)
                    {
                        totalPrice += item.Price * item.Amount;
                    }

                    txtTotalMoney.Text = totalPrice.ToString("N0");
                }
                else
                {
                    txtTotalMoney.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedOrderInfo = null;
                LoadOrder();
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void dgvOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvOrder.RowCount > 0)
                {
                    for (int i = 0; i < dgvOrder.RowCount; i++)
                    {
                        var selectedPatient = dgvOrder.Rows[i].DataBoundItem as OrderService.OrderInfo;
                        if (selectedPatient != null)
                        {
                            switch (selectedPatient.Status)
                            {
                                case 0:
                                    dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                                    dgvOrder.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightGoldenrodYellow;
                                    break;
                                case 1:
                                    dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                                    dgvOrder.Rows[i].DefaultCellStyle.SelectionForeColor = Color.SkyBlue;
                                    break;
                                case 2:
                                    dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
                                    dgvOrder.Rows[i].DefaultCellStyle.SelectionForeColor = Color.SpringGreen;
                                    break;
                                case 3:
                                    dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                                    dgvOrder.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Tomato;
                                    break;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedOrderInfo != null)
                {
                    if (MessageBox.Show($"Bạn chắc chắn Xác nhận đơn hàng mã: [{_selectedOrderInfo.OrderID}] ?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _selectedOrderInfo.Status = 1;
                        _selectedOrderInfo.ConfirmDate = DateTime.Now;

                        var response = OrderService.GetInstance().UpdateOrder(_selectedOrderInfo);

                        if (response.IsSuccess)
                        {
                            CommonUtils_Win.Alert("Xác nhận đơn hàng thành công!", FrmAlert.enmType.Success);
                            LoadOrder();
                        }
                        else
                        {
                            throw new Exception(response.Err.MsgString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedOrderInfo != null)
                {
                    if (MessageBox.Show($"Bạn chắc chắn Hoàn thành đơn hàng mã: [{_selectedOrderInfo.OrderID}] ?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _selectedOrderInfo.Status = 2;
                        _selectedOrderInfo.DeliveryDate = DateTime.Now;

                        var response = OrderService.GetInstance().UpdateOrder(_selectedOrderInfo);

                        if (response.IsSuccess)
                        {
                            CommonUtils_Win.Alert("Xác nhận Hoàn thành đơn hàng thành công!", FrmAlert.enmType.Success);
                            LoadOrder();
                        }
                        else
                        {
                            throw new Exception(response.Err.MsgString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

		private void btnCancel_Click(object sender, EventArgs e)
		{
			try
			{
				if (_selectedOrderInfo != null)
				{
					if (MessageBox.Show($"Bạn chắc chắn Hủy đơn hàng mã: [{_selectedOrderInfo.OrderID}] ?",
						"Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						FrmReasonCancel frmReasonCancel = new FrmReasonCancel();

						if (frmReasonCancel.ShowDialog() == DialogResult.OK)
						{
							_selectedOrderInfo.Status = 3;
							_selectedOrderInfo.CancelDate = DateTime.Now;
							_selectedOrderInfo.ReasonCancel = frmReasonCancel.ReasonCancel;

                            var response = OrderService.GetInstance().UpdateOrder(_selectedOrderInfo);

                            if (response.IsSuccess)
                            {
                                CommonUtils_Win.Alert("Xác nhận Hủy đơn hàng thành công!", FrmAlert.enmType.Success);
                                LoadOrder();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
