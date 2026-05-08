using System.Drawing;

namespace Paint_FinalProject.Commands
{
    public interface ICommand
    {
        void Execute(Graphics g);
        void Undo(Bitmap bitmap);
    }
}