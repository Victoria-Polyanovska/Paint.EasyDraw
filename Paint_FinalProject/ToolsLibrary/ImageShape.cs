using System.Drawing;

namespace Paint_FinalProject.ToolsLibrary
{
    public class ImageShape : Shape
    {
        public Image InsertedImage { get; set; }

        public ImageShape(Point start, Image image)
            : base(start, start, Color.Black, 1f)
        {
            InsertedImage = image;
        }

        public override void Draw(Graphics g)
        {
            if (InsertedImage != null)
            {
                g.DrawImage(InsertedImage, StartPoint);
            }
        }
    }
}