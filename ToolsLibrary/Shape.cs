using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_FinalProject.ToolsLibrary
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public float Thickness { get; set; }

        public Shape(Color color, float thickness)
        {
            Color = color;
            Thickness = thickness;
        }
        public abstract void Draw(Graphics g);
    }
}