using System.Collections.Generic;
using System.Drawing;

namespace Paint_FinalProject.Commands
{
    public class HistoryManager
    {
        private readonly Stack<ICommand> _undoStack = new Stack<ICommand>();
        private readonly Stack<ICommand> _redoStack = new Stack<ICommand>();
        private readonly Bitmap _mainBitmap;

        public HistoryManager(Bitmap bitmap)
        {
            _mainBitmap = bitmap;
        }

        public void ExecuteCommand(ICommand command, Graphics g)
        {
            command.Execute(g);
            _undoStack.Push(command);
            _redoStack.Clear(); 
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                ICommand command = _undoStack.Pop();
                command.Undo(_mainBitmap);
                _redoStack.Push(command);
            }
        }

        public void Redo(Graphics g)
        {
            if (_redoStack.Count > 0)
            {
                ICommand command = _redoStack.Pop();
                command.Execute(g);
                _undoStack.Push(command);
            }
        }

        public bool CanUndo => _undoStack.Count > 0;
        public bool CanRedo => _redoStack.Count > 0;
    }
}