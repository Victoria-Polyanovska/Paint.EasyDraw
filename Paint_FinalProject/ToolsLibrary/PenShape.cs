using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_FinalProject.ToolsLibrary
{
    public class PenShape : Shape
    {
        // Список для зберігання всіх точок лінії
        public List<Point> Points { get; set; } = new List<Point>();

        public PenShape(Point start, Point end, Color color, float thickness)
            : base(start, end, color, thickness)
        {
            Points.Add(start);
        }

        public void AddPoint(Point pt)
        {
            Points.Add(pt);
        }

        public override void Draw(Graphics g)
        {
            if (Points.Count < 2) return;

            using (Pen pen = new Pen(Color, Thickness))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round; 

                g.SmoothingMode = SmoothingMode.AntiAlias;

                g.DrawLines(pen, Points.ToArray());
            }
        }
    }
}