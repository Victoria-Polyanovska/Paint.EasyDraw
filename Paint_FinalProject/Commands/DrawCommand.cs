using System.Drawing;
using Paint_FinalProject.ToolsLibrary;

namespace Paint_FinalProject.Commands
{
    public class DrawCommand : ICommand
    {
        private readonly Shape _shape;
        private readonly Bitmap _previousState;

        public string Name { get; }

        public Shape Shape => _shape;

        public DrawCommand(Shape shape, Bitmap currentBitmap, string actionName = "Малювання")
        {
            _shape = shape;
            _previousState = new Bitmap(currentBitmap);
            Name = actionName;
        }

        public void Execute(Graphics g)
        {
            _shape.Draw(g);
        }

        public void Undo(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(_previousState, 0, 0);
            }
        }
    }
}