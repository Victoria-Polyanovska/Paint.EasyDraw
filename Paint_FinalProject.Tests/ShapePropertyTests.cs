using NUnit.Framework;
using Paint_FinalProject.Models;
using Paint_FinalProject.ToolsLibrary;
using System.Drawing;
using System; 

namespace Paint_FinalProject.Tests
{
    [TestFixture]
    public class ShapePropertyTests
    {
        [Test]
        public void LineShape_Properties_ShouldBeCorrect()
        {
            var start = new Point(10, 20);
            var end = new Point(100, 200);
            var color = Color.Red;
            float thickness = 5.5f;

            var line = new LineShape(start, end, color, thickness);

            Assert.Multiple(new Action(() =>
            {
                Assert.That(line.StartPoint, Is.EqualTo(start));
                Assert.That(line.EndPoint, Is.EqualTo(end));
                Assert.That(line.Color, Is.EqualTo(color));
                Assert.That(line.Thickness, Is.EqualTo(thickness));
            }));
        }

        [Test]
        public void RectangleShape_Dimensions_Calculation()
        {
            var start = new Point(100, 100);
            var end = new Point(50, 50);

            var rect = new RectangleShape(start, end, Color.Black, 1f);

            Assert.That(rect.StartPoint, Is.EqualTo(start));
            Assert.That(rect.EndPoint, Is.EqualTo(end));
        }

        [Test]
        public void EllipseShape_ColorChange_Works()
        {
            var ellipse = new EllipseShape(new Point(0, 0), new Point(10, 10), Color.Blue, 1f);

            ellipse.Color = Color.Yellow;

            Assert.That(ellipse.Color, Is.EqualTo(Color.Yellow));
        }
    }
}