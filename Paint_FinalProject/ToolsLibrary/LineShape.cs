using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_FinalProject.ToolsLibrary
{
    public class LineShape : Shape
    {
        public LineShape(Point start, Point end, Color color, float thickness)
            : base(start, end, color, thickness) { }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.Alignment = PenAlignment.Center;

                g.SmoothingMode = SmoothingMode.AntiAlias; 
                g.DrawLine(pen, StartPoint, EndPoint);
            }
        }
    }
}
