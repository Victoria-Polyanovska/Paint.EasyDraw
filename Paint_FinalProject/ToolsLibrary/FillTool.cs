using System.Collections.Generic;
using System.Drawing;

namespace Paint_FinalProject.ToolsLibrary
{
    public class FillTool
    {
        public void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            if (targetColor.ToArgb() == replacementColor.ToArgb()) return;

            Queue<Point> q = new Queue<Point>();
            q.Enqueue(pt);

            while (q.Count > 0)
            {
                Point n = q.Dequeue();
                if (n.X < 0 || n.X >= bmp.Width || n.Y < 0 || n.Y >= bmp.Height) continue;

                if (bmp.GetPixel(n.X, n.Y).ToArgb() == targetColor.ToArgb())
                {
                    bmp.SetPixel(n.X, n.Y, replacementColor);
                    q.Enqueue(new Point(n.X + 1, n.Y));
                    q.Enqueue(new Point(n.X - 1, n.Y));
                    q.Enqueue(new Point(n.X, n.Y + 1));
                    q.Enqueue(new Point(n.Y, n.Y - 1));
                }
            }
        }
    }
}