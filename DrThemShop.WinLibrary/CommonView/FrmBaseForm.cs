using DrThemShop.WinLibrary.BusinessObject;
using DrThemShop.WinLibrary.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DrThemShop.WinLibrary
{
    public partial class FrmBaseForm : Form
    {
        [Category("Appearance"), Description("Tên form trên tiêu đề.")]
        public string FormHeader
        {
            get
            {
                return this.lblHeader.Text;
            }
            set
            {
                this.lblHeader.Text = value;
            }
        }
        public FrmBaseForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBaseFormV2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(sender, e);
            }
        }
        protected string GetValueCombobox(MultiColumnComboBox.MultiColumnComboBox cbo)
        {
            if (cbo.SelectedValue != null && !string.IsNullOrEmpty(cbo.Text))
            {
                return cbo.SelectedValue?.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        protected int? GetValueComboboxInt(MultiColumnComboBox.MultiColumnComboBox cboIns)
        {
            if (cboIns.SelectedValue != null && !string.IsNullOrEmpty(cboIns.Text))
            {
                return int.Parse(cboIns.SelectedValue?.ToString());
            }
            else
            {
                return null;
            }
        }

        protected List<SelectDisplayItem<T>> GetListEnum<T>()
        {
            var _list = new List<SelectDisplayItem<T>>();

            foreach (var item in EnumHelper.GetList<T>())
            {
                _list.Add(item);
            }
            return _list;
        }

        /// <summary>
        /// Map source into MultiColumnComboBox via SelectDisplayItem
        /// </summary>
        /// <param name="cbo"></param>

        protected void LoadComboEnum<T>(MultiColumnComboBox.MultiColumnComboBox cbo)
        {
            cbo.ColumnNames = "ID,Name";
            cbo.DropDownWidth = 200;
            cbo.ColumnWidths = "50,150";

            this.LoadComboBoxEnum<T>(cbo);
        }

        /// <summary>
        /// Map source into combobox via SelectDisplayItem
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cbo"></param>
        protected void LoadComboBoxEnum<T>(ComboBox cbo)
        {
            cbo.DataSource = this.GetListEnum<T>();
            cbo.ValueMember = "ID";
            cbo.DisplayMember = "Name";
        }

        /// <summary>
        /// Map source into DataGridViewComboBoxColumn via SelectDisplayItem
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cbo"></param>
        protected void LoadComboEnum<T>(DataGridViewComboBoxColumn cbo)
        {
            cbo.ValueMember = "ID";
            cbo.DisplayMember = "Name";
            cbo.DataSource = this.GetListEnum<T>();
        }
        public static void RefreshDataBinding<T>(DataGridView dgv, BindingList<T> lstData, IEnumerable<T> lst)
        {
            lstData.RaiseListChangedEvents = false;
            lstData.Clear();
            foreach (var item in lst)
            {
                lstData.Add(item);
            }

            lstData.RaiseListChangedEvents = true;
            lstData.ResetBindings();

            dgv.Refresh();
        }
        protected void BindingData<T>(BindingList<T> lstData, BindingSource bindingSource, DataGridView dgv)
        {
            //ControlUtil.DoubleBuffered(dgv, true);

            dgv.AutoGenerateColumns = false;
            bindingSource.DataSource = lstData;
            dgv.DataSource = bindingSource;
        }
        protected void BindingData<T>(BindingList<T> lstData, DataGridView dgv)
        {
            var sourceData = GetBindingSource(dgv.Name);
            BindingData<T>(lstData, sourceData, dgv);
        }

        private Dictionary<string, BindingSource> m_bindingSource = new Dictionary<string, BindingSource>();
        protected BindingSource GetBindingSource(string name)
        {
            var rs = new BindingSource();

            if (m_bindingSource.TryGetValue(name, out rs))
            {
                if (rs == null) rs = new BindingSource();
                return rs;
            }
            else m_bindingSource.Add(name, new BindingSource());
            return GetBindingSource(name);
        }
    }
}