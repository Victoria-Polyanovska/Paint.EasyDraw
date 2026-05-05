using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.ToolsLibrary
{
    public class TextShape : Shape
    {
        public string Text { get; set; }
        public Point Position { get; set; }
        public Font Font { get; set; }
        public Color Color { get; set; }

        public TextShape(string text, Point position, Font font, Color color)
        {
            Text = text;
            Position = position;
            Font = font;
            Color = color;
        }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.DrawString(Text, Font, brush, Position);
            }
        }
    }


}
