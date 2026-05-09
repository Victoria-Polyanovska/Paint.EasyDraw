using System.Collections.Generic;
using System.Drawing;
using System.Linq; 

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
        public void ClearHistory()
        {
            _undoStack.Clear();
            _redoStack.Clear();
        }

        public List<string> GetHistoryNames()
        {
            List<string> displayNames = new List<string>();
            var commands = _undoStack.ToList(); 

            int i = 0;
            while (i < commands.Count)
            {
                string currentName = commands[i].Name;
                int count = 0;

                while (i < commands.Count && commands[i].Name == currentName)
                {
                    count++;
                    i++;
                }

                string displayName = count > 1 ? $"{currentName} ({count})" : currentName;
                displayNames.Add(displayName);
            }

            return displayNames;
        }
    }
}