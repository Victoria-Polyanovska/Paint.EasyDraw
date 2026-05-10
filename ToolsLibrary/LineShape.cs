using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_FinalProject.ToolsLibrary
{
    public class LineShape : Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public LineShape(Point start, Point end, Color color, float thickness)
            : base(color, thickness)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                g.DrawLine(pen, StartPoint, EndPoint);
            }
        }
    }
}
