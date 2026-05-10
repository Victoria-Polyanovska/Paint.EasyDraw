using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_FinalProject.ToolsLibrary
{
    public class EllipseShape : Shape
    {
        public EllipseShape(Point start, Point end, Color color, float thickness)
            : base(start, end, color, thickness) { }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawEllipse(pen, GetNormalizedRectangle());
            }
        }
    }

}
