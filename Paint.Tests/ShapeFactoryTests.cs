using Paint_FinalProject.ToolsLibrary;
using System.Drawing;
using Xunit;
using System;

namespace Paint.Tests
{
    public class ShapeFactoryTests
    {
        private readonly Point _start = new Point(10, 10);
        private readonly Point _end = new Point(60, 60);
        private readonly Color _color = Color.Red;
        private readonly float _thickness = 2.0f;

        [Theory]
        [InlineData(1, typeof(LineShape))]    
        [InlineData(2, typeof(EllipseShape))]  
        [InlineData(3, typeof(TriangleShape))]  
        [InlineData(4, typeof(RectangleShape))] 
        public void CreateShape_ValidIndex_ReturnsCorrectType(int index, Type expectedType)
        {
            var shape = ShapeFactory.CreateShape(index, _start, _end, _color, _thickness);

            Assert.NotNull(shape);
            Assert.IsType(expectedType, shape);
        }

        [Fact]
        public void CreateShape_CheckProperties_ShouldBeCorrect()
        {
            int index = 4; 

            var shape = ShapeFactory.CreateShape(index, _start, _end, _color, _thickness);

            Assert.NotNull(shape);
            Assert.IsType<RectangleShape>(shape);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(999)]
        public void CreateShape_InvalidIndex_ReturnsNull(int invalidIndex)
        {
            var shape = ShapeFactory.CreateShape(invalidIndex, _start, _end, _color, _thickness);

            Assert.Null(shape);
        }
    }
}