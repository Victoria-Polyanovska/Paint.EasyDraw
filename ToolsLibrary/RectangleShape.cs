using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public class RectangleShape : Shape
    {
        public Rectangle Rect { get; set; }

        public RectangleShape(Point startPoint, Point endPoint, Color color, float width)
        {
            Rect = new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(endPoint.X - startPoint.X),
                Math.Abs(endPoint.Y - startPoint.Y)
            );
            Pen = new Pen(color, width);
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Rect);
        }
    }
}
