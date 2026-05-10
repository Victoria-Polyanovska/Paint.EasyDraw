using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_FinalProject.ToolsLibrary
{
    public class EllipseShape : Shape
    {
        public Rectangle BoundingBox { get; set; }

        public EllipseShape(Rectangle rect, Color color, float thickness)
            : base(color, thickness)
        {
            BoundingBox = rect;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                g.DrawEllipse(pen, BoundingBox);
            }
        }
    }
}
