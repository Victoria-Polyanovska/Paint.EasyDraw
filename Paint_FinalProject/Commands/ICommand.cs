using System.Drawing;

namespace Paint_FinalProject.Commands
{
    public interface ICommand
    {
        string Name { get; } 
        void Execute(Graphics g);
        void Undo(Bitmap bitmap);
    }
}