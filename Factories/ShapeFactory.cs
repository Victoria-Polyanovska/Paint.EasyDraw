using System.Drawing;
using Paint.EasyDraw.Tools;

namespace Paint.EasyDraw.Factories;

public static class ShapeFactory
{
    public static Shape CreateShape(
        int index,
        Point startPoint,
        Point endPoint,
        Pen pen)
    {
        if (index == 3)
        {
            Rectangle rectangle = new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(endPoint.X - startPoint.X),
                Math.Abs(endPoint.Y - startPoint.Y)
            );

            return new EllipseShape(
                rectangle,
                pen.Color,
                (int)pen.Width
            );
        }

        if (index == 4)
        {
            return new RectangleShape(
                startPoint,
                endPoint,
                pen.Color,
                (int)pen.Width
            );
        }

        if (index == 5)
        {
            return new LineShape(
                startPoint,
                endPoint,
                pen.Color,
                (int)pen.Width
            );
        }

        if (index == 6)
        {
            return new TriangleShape(
                startPoint,
                endPoint,
                pen.Color,
                (int)pen.Width
            );
        }

        return null;
    }
}