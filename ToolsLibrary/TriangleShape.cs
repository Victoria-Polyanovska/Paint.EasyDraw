using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_FinalProject.ToolsLibrary
{
    public class TriangleShape : Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public TriangleShape(Point start, Point end, Color color, float thickness)
            : base(color, thickness)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                int left = Math.Min(StartPoint.X, EndPoint.X);
                int right = Math.Max(StartPoint.X, EndPoint.X);
                int top = Math.Min(StartPoint.Y, EndPoint.Y);
                int bottom = Math.Max(StartPoint.Y, EndPoint.Y);

                Point[] points = {
                    new Point(left + (right - left) / 2, top), 
                    new Point(left, bottom),                   
                    new Point(right, bottom)                
                };

                g.DrawPolygon(pen, points);
            }
        }
    }
}
