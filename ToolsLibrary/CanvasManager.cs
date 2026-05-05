using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public class CanvasManager
    {
        public List<Layer> Layers { get; set; } = new List<Layer>();
        public Layer ActiveLayer { get; set; }

        public void DrawAll(Graphics g)
        {
            foreach (var layer in Layers)
            {
                layer.Draw(g);
            }
        }
    }

}
