using System.Drawing;

namespace Paint_FinalProject.ToolsLibrary
{
    public class TextShape : Shape
    {
        public string Text { get; set; }
        public Font TextFont { get; set; }

        public TextShape(Point start, string text, Font font, Color color)
            : base(start, start, color, 1f)
        {
            Text = text;
            TextFont = font;
        }
        public override void Draw(Graphics g)
        {
            if (string.IsNullOrEmpty(Text) || TextFont == null) return;

            using (Brush brush = new SolidBrush(Color))
            {
                g.DrawString(Text, TextFont, brush, StartPoint);
            }
        }
    }
}