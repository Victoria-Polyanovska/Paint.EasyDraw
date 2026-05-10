using NUnit.Framework;
using Paint_FinalProject.Commands;
using Paint_FinalProject.Models;
using Paint_FinalProject.ToolsLibrary;
using System;
using System.Drawing;

namespace Paint_FinalProject.Tests
{
    [TestFixture]
    public class DetailedHistoryTests
    {
        private HistoryManager _history;
        private Bitmap _canvas;
        private Graphics _graphics;

        [SetUp]
        public void SetUp()
        {
            _canvas = new Bitmap(400, 400);
            _graphics = Graphics.FromImage(_canvas);
            _history = new HistoryManager(_canvas);
        }

        [TearDown]
        public void TearDown()
        {
            _graphics?.Dispose();
            _canvas?.Dispose();
        }

        [Test]
        public void History_ShouldHandleComplexSequenceOfActions()
        {
            for (int i = 1; i <= 5; i++)
            {
                var shape = new LineShape(new Point(i, i), new Point(i * 10, i * 10), Color.Blue, 1f);
                var cmd = new DrawCommand(shape, _canvas, $"Фігура {i}");
                _history.ExecuteCommand(cmd, _graphics);
            }

            Assert.That(_history.GetHistoryNames().Count, Is.EqualTo(5));

            _history.Undo();
            _history.Undo();
            _history.Undo();

            Assert.That(_history.GetHistoryNames().Count, Is.EqualTo(2));
            Assert.That(_history.GetHistoryNames()[1], Is.EqualTo("Фігура 2"));
        }

        [Test]
        public void RedoStack_ShouldClear_WhenNewCommandExecuted()
        {
            var shape1 = new LineShape(new Point(0, 0), new Point(10, 10), Color.Red, 1f);
            _history.ExecuteCommand(new DrawCommand(shape1, _canvas, "Перша"), _graphics);

            _history.Undo();

            var shape2 = new LineShape(new Point(5, 5), new Point(15, 15), Color.Green, 1f);
            _history.ExecuteCommand(new DrawCommand(shape2, _canvas, "Друга"), _graphics);

            // Виправляємо неоднозначність через new TestDelegate
            Assert.DoesNotThrow(new TestDelegate(() => _history.Redo(_graphics)));
            Assert.That(_history.GetHistoryNames().Count, Is.EqualTo(1));
        }

        [Test]
        public void GetHistoryNames_ShouldMaintainCorrectVisualOrder()
        {
            var dummyPoint = new Point(0, 0);
            _history.ExecuteCommand(new DrawCommand(new LineShape(dummyPoint, dummyPoint, Color.Black, 1f), _canvas, "Нижній шар"), _graphics);
            _history.ExecuteCommand(new DrawCommand(new LineShape(dummyPoint, dummyPoint, Color.Black, 1f), _canvas, "Середній шар"), _graphics);
            _history.ExecuteCommand(new DrawCommand(new LineShape(dummyPoint, dummyPoint, Color.Black, 1f), _canvas, "Верхній шар"), _graphics);

            var names = _history.GetHistoryNames();

            Assert.Multiple(new Action(() =>
            {
                Assert.That(names[0], Is.EqualTo("Нижній шар"));
                Assert.That(names[1], Is.EqualTo("Середній шар"));
                Assert.That(names[2], Is.EqualTo("Верхній шар"));
            }));
        }

        [Test]
        public void FullCycle_UndoRedo_DoesNotCorruptCanvas()
        {
            var shape = new RectangleShape(new Point(0, 0), new Point(50, 50), Color.Red, 1f);
            var cmd = new DrawCommand(shape, _canvas, "Rect");

            _history.ExecuteCommand(cmd, _graphics);
            Color pixelColor = _canvas.GetPixel(25, 25);

            _history.Undo();
            _history.Redo(_graphics);

            Color restoredColor = _canvas.GetPixel(25, 25);
            Assert.That(restoredColor.ToArgb(), Is.EqualTo(pixelColor.ToArgb()));
        }
    }
}