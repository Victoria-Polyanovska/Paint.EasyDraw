using System.Drawing;

namespace Paint_FinalProject.ToolsLibrary
{
    public class EraserTool : Shape
    {
        public EraserTool(Point start, Point end, float thickness)
            : base(start, end, Color.White, thickness) { }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color.White, Thickness))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(pen, StartPoint, EndPoint);
            }
        }
    }
}
