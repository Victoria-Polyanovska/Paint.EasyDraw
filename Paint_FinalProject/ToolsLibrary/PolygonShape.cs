using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_FinalProject.ToolsLibrary
{
    public class PolygonShape : Shape
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public PolygonShape(Point start, Color color, float thickness)
            : base(start, start, color, thickness)
        {
            Points.Add(start);
        }

        public override void Draw(Graphics g)
        {
            if (Points.Count < 2) return;

            using (Pen pen = new Pen(Color, Thickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPolygon(pen, Points.ToArray());
            }
        }

        public void AddPoint(Point pt) => Points.Add(pt);
    }
}