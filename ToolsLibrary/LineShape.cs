using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public class LineShape : Shape
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public LineShape(Point start, Point end, Color color, float width)
        {
            Start = start;
            End = end;
            Pen = new Pen(color, width);
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
    }
}
