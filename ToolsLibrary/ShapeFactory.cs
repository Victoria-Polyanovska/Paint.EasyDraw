using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_FinalProject.ToolsLibrary
{
    public static class ShapeFactory
    {
        public static Shape CreateShape(int index, Point start, Point end, Color color, float thickness)
        {
            switch (index)
            {
                case 3: 
                    Rectangle rect = new Rectangle(
                        Math.Min(start.X, end.X), Math.Min(start.Y, end.Y),
                        Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));
                    return new EllipseShape(rect, color, thickness);

                case 4:
                    return new RectangleShape(start, end, color, thickness);

                case 5: 
                    return new LineShape(start, end, color, thickness);

                case 6: 
                    return new TriangleShape(start, end, color, thickness);

                default:
                    return null;
            }
        }
    }
}
