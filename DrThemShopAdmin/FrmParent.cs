using DrThemShop.WinLibrary.CustomControl;
using DrThemShop.WinLibrary.Helper;
using DrThemShopAdmin.View;
using System;
using System.Windows.Forms;

namespace DrThemShopAdmin
{
    public partial class FrmParent : Form
    {
        public static string PathRoot { get; set; }

        public FrmParent()
        {
            InitializeComponent();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
            try
            {
                PathRoot = Application.StartupPath;

                labVersion.Text = $"Phiên bản: {Application.ProductVersion}";

                FrmStartUp f = new FrmStartUp();
                this.ShowForm(f);
            }
            catch (Exception ex)
            {
                CommonUtils_Win.Alert(ex.Message, FrmAlert.enmType.Error);
            }
        }

        public void ShowForm(Form frm)
        {
            if (frm.Name != "FrmParent")
            {
                foreach (Form f in MdiChildren)
                {
                    if (f.Name.Equals(frm.Name))
                    {
                        f.Visible = false;
                        f.Activate();
                        f.WindowState = FormWindowState.Maximized;
                        f.Visible = true;
                        return;
                    }
                }
                frm.MdiParent = this;
                frm.Show();

                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void tsm_TrangChu_Click(object sender, EventArgs e)
        {
            FrmStartUp f = new FrmStartUp();
            this.ShowForm(f);
        }

        private void tsm_Category_Click(object sender, EventArgs e)
        {
            FrmCategory f = new FrmCategory();
            this.ShowForm(f);
        }

        private void tsm_Product_Click(object sender, EventArgs e)
        {
            FrmProduct f = new FrmProduct();
            this.ShowForm(f);
        }

        private void tsm_Order_Click(object sender, EventArgs e)
        {
            FrmOrder f = new FrmOrder();
            this.ShowForm(f);
        }
    }
}
