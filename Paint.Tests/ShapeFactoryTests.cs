using Paint_FinalProject.ToolsLibrary;
using System.Drawing;

namespace Paint.Tests
{
    public class ShapeFactoryTests
    {
        [Fact]
        public void CreateShape_Rectangle_ReturnsCorrectType()
        {
            int index = 4; 
            Point start = new Point(0, 0);
            Point end = new Point(50, 50);
            Color color = Color.Blue;
            float thickness = 1.5f;

            var shape = ShapeFactory.CreateShape(index, start, end, color, thickness);
            Assert.NotNull(shape); 
            Assert.IsType<RectangleShape>(shape); 
        }

        [Fact]
        public void CreateShape_InvalidIndex_ReturnsNull()
        {
            var shape = ShapeFactory.CreateShape(999, new Point(0, 0), new Point(1, 1), Color.Red, 1f);
            Assert.Null(shape);
        }
    }
}