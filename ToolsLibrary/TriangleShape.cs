using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public class TriangleShape : Shape
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }

        public TriangleShape(Point start, Point end, Color color, float width)
        {
            P1 = new Point(start.X + (end.X - start.X) / 2, start.Y);
            P2 = new Point(start.X, end.Y);
            P3 = new Point(end.X, end.Y);
            Pen = new Pen(color, width);
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(Pen, new[] { P1, P2, P3 });
        }
    }
}
