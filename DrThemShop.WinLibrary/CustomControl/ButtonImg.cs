using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DrThemShop.WinLibrary.CustomControl
{
    public partial class ButtonImg : System.Windows.Forms.PictureBox
    {
        public ButtonImg()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public ButtonImg(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            BackColor = Color.White;

        }
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            BackColor = Color.Silver;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.White;
            BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!this.Enabled)
            {
                this.Image = (Image)DrThemShop.WinLibrary.Properties.Resources.block_user_512;
            }
        }
    }
}
