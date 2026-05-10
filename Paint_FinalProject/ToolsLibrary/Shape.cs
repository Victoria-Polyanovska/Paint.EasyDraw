using System.Drawing;

namespace Paint_FinalProject.ToolsLibrary
{
    public abstract class Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public float Thickness { get; set; }

        protected Shape(Point start, Point end, Color color, float thickness)
        {
            StartPoint = start;
            EndPoint = end;
            Color = color;
            Thickness = thickness < 0.1f ? 1.0f : thickness;
        }

        public abstract void Draw(Graphics g);

        protected Rectangle GetNormalizedRectangle()
        {
            return new Rectangle(
                Math.Min(StartPoint.X, EndPoint.X),
                Math.Min(StartPoint.Y, EndPoint.Y),
                Math.Abs(StartPoint.X - EndPoint.X),
                Math.Abs(StartPoint.Y - EndPoint.Y)
            );
        }
    }
}