using System.Drawing;
using System.Windows.Forms;

namespace DrThemShop.WinLibrary.CustomControl
{
    public partial class LineTop : Control
    {
        public LineTop()
        {
            InitializeComponent();
            BackColor = Color.Gray;
            this.Dock = DockStyle.Top;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Size size = new System.Drawing.Size();
            size.Width = this.Size.Width;
            size.Height = 1;
            this.Size = size;
        }
    }
}
