using System.Drawing;
using Paint_FinalProject.ToolsLibrary;

namespace Paint_FinalProject.Commands
{
    public interface ICommand
    {
        string Name { get; }
        Shape Shape { get; }
        void Execute(Graphics g);
        void Undo(Bitmap bitmap);
    }
}