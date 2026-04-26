using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public class EllipseShape : Shape
    {
        public Rectangle Rect { get; set; }

        public EllipseShape(Rectangle rect, Color color, float width)
        {
            Rect = rect;
            Pen = new Pen(color, width);
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pen, Rect);
        }
    }
}
