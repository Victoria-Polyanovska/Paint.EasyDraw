using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_FinalProject.ToolsLibrary
{
    public class RectangleShape : Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public RectangleShape(Point start, Point end, Color color, float thickness)
            : base(color, thickness)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                int x = Math.Min(StartPoint.X, EndPoint.X);
                int y = Math.Min(StartPoint.Y, EndPoint.Y);
                int width = Math.Abs(StartPoint.X - EndPoint.X);
                int height = Math.Abs(StartPoint.Y - EndPoint.Y);

                g.DrawRectangle(pen, x, y, width, height);
            }
        }
    }
}
