using System;
using System.Collections.Generic;
using Paint_FinalProject.ToolsLibrary;

namespace Paint_FinalProject.Models
{
    public class DrawingProject
    {
        public string Name { get; set; }
        public DateTime LastModified { get; set; }
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public int CanvasWidth { get; set; }
        public int CanvasHeight { get; set; }
    }
}
