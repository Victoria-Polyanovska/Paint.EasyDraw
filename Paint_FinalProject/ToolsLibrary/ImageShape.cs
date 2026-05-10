using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Paint_FinalProject.ToolsLibrary
{
    public class ImageShape : Shape
    {
        [JsonIgnore]
        public Image InsertedImage { get; set; }
        public string ImageData
        {
            get
            {
                if (InsertedImage == null) return null;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (Bitmap tempBmp = new Bitmap(InsertedImage))
                    {
                        tempBmp.Save(ms, ImageFormat.Png);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    InsertedImage = null;
                }
                else
                {
                    byte[] imageBytes = Convert.FromBase64String(value);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        InsertedImage = new Bitmap(ms);
                    }
                }
            }
        }

        public ImageShape() : base(Point.Empty, Point.Empty, Color.Black, 1f) { }

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