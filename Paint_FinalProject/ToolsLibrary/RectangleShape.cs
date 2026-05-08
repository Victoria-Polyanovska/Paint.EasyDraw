
using Paint_FinalProject.ToolsLibrary;
using System.Drawing.Drawing2D;

public class RectangleShape : Shape
{
    public RectangleShape(Point start, Point end, Color color, float thickness)
        : base(start, end, color, thickness) { }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color, Thickness))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawRectangle(pen, GetNormalizedRectangle());
        }
    }
}

