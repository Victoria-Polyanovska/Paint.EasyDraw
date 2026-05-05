using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public abstract class Shape
    {
        public Pen Pen { get; set; }
        public abstract void Draw(Graphics g);
        public bool Visible { get; set; } = true;

    }
}
