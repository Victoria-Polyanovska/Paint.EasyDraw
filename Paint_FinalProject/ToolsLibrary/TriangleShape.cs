using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_FinalProject.ToolsLibrary
{
    public class TriangleShape : Shape
    {
        public TriangleShape(Point start, Point end, Color color, float thickness)
            : base(start, end, color, thickness) { }

        public override void Draw(Graphics g)
        {
            if (StartPoint == EndPoint) return;

            using (Pen pen = new Pen(Color, Thickness))
            {
                pen.LineJoin = LineJoin.Round;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Point[] points = {
                    new Point(StartPoint.X + (EndPoint.X - StartPoint.X) / 2, StartPoint.Y),
                    new Point(StartPoint.X, EndPoint.Y),
                    new Point(EndPoint.X, EndPoint.Y)
                };

                g.DrawPolygon(pen, points);
            }
        }
    }
}
