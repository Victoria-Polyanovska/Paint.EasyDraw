using Microsoft.VisualBasic;
using System;
using System.Drawing;

namespace Paint_FinalProject.ToolsLibrary
{
    public static class ShapeFactory
    {

        public static Shape CreateShape(int index, Point start, Point end, Color color, float thickness)
        {
            try
            {
                return index switch
                {
                    1 => new PenShape(start, end, color, thickness),    
                    2 => new EraserTool(start, end, thickness),           
                    3 => new EllipseShape(start, end, color, thickness),   
                    4 => new RectangleShape(start, end, color, thickness), 
                    5 => new LineShape(start, end, color, thickness),      
                    6 => new TriangleShape(start, end, color, thickness),  
                    7 => new PolygonShape(start, color, thickness),      

                    _ => throw new ArgumentException($"Інструмент з індексом {index} не підтримується.")
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка створення фігури: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Критична помилка у фабриці: {ex.Message}");
                return null;
            }
        }
    }
}