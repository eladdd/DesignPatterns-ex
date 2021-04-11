﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FaceBookApp.UI
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using (GraphicsPath obj = new GraphicsPath())
            {
                obj.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                Region = new Region(obj);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
