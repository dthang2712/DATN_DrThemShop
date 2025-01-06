using System.Drawing;
using System.Windows.Forms;

namespace DrThemShop.WinLibrary.CustomControl
{
    public partial class LineBottom : Control
    {
        public LineBottom()
        {
            InitializeComponent();
            BackColor = Color.Gray;
            this.Dock = DockStyle.Bottom;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Size size = new System.Drawing.Size();
            size.Width = this.Width;
            size.Height = 1;
            this.Size = size;
        }
    }
}
