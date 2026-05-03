using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public class Layer
    {
        public string Name { get; set; }
        public bool Visible { get; set; } = true;
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public void Draw(Graphics g)
        {
            if (!Visible) return;
            foreach (var shape in Shapes)
            {
                shape.Draw(g);
            }
        }
    }
}
