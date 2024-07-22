using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Demo.Controls
{
    public class TextBox_Botron : TextBox
    {
        private int cornerRadius = 25;

        public TextBox_Botron()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            base.OnPaint(e);
        }
    }
}
