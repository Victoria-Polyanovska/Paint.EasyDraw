using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_FinalProject.ToolsLibrary
{
    public class EraserTool : Shape
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public EraserTool(Point start, Point end, float thickness)
            : base(start, end, Color.White, thickness)
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

            using (Pen pen = new Pen(Color.White, Thickness))
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