using System.Drawing;
using System.Windows.Forms;

namespace DrThemShop.WinLibrary.CustomControl
{
    public partial class LineRight : Control
    {
        public LineRight()
        {
            InitializeComponent();
            BackColor = Color.Gray;
            this.Dock = DockStyle.Right;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Size size = new System.Drawing.Size();
            size.Height = this.Size.Height;
            size.Width = 1;
            this.Size = size;
        }
    }
}
