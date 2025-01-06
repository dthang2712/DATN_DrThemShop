using System.Drawing;
using System.Windows.Forms;

namespace DrThemShop.WinLibrary.CustomControl
{
    public partial class LineLeft : Panel
    {
        public LineLeft()
        {
            InitializeComponent();
            BackColor = Color.Gray;
            this.Dock = DockStyle.Left;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Size size = new System.Drawing.Size();
            size.Height = this.Height;
            size.Width = 1;
            this.Size = size;
        }
    }
}
