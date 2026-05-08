using Paint_FinalProject.Commands;
using Paint_FinalProject.ToolsLibrary;
using System.Windows.Forms;

namespace Paint_FinalProject
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Bitmap _tempBitmap;
        private Graphics _graphics;

        private int _currentToolIndex = 1;
        private Color _currentColor = Color.Black;
        private float _currentThickness = 2f;

        private Point _startPoint;
        private bool _isDrawing = false;

        private HistoryManager _historyManager;
        public Form1()
        {
            InitializeComponent();
            SetupCanvas();
        }
        private void SetupCanvas()
        {
            _mainBitmap = new Bitmap(picture.Width, picture.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            picture.Image = _mainBitmap;

            _historyManager = new HistoryManager(_mainBitmap);

            if (color_picker != null && color_picker.Image != null)
            {
                if (!(color_picker.Image is Bitmap))
                {
                    color_picker.Image = new Bitmap(color_picker.Image);
                }
            }

            UpdateDrawingColor(Color.Black);
        }
        private void UpdateDrawingColor(Color newColor)
        {
            _currentColor = newColor;

            if (button_color != null)
            {
                button_color.BackColor = newColor;
            }
        }
        private void button_pen_Click(object sender, EventArgs e) => _currentToolIndex = 1;

        private void button_eraser_Click(object sender, EventArgs e) => _currentToolIndex = 2;

        private void button_ellipse_Click(object sender, EventArgs e) => _currentToolIndex = 3;

        private void button_rct_Click(object sender, EventArgs e) => _currentToolIndex = 4;

        private void button_line_Click(object sender, EventArgs e) => _currentToolIndex = 5;

        private void button_trg_Click(object sender, EventArgs e) => _currentToolIndex = 6;

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;
            _isDrawing = false;

            var shape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, e.Location, _currentColor, _currentThickness);

            if (shape != null)
            {
                var command = new DrawCommand(shape, _mainBitmap);
                _historyManager.ExecuteCommand(command, _graphics);
            }

            picture.Image = _mainBitmap;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPoint = e.Location;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            _tempBitmap = new Bitmap(_mainBitmap);

            using (Graphics g = Graphics.FromImage(_tempBitmap))
            {
                var shape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, e.Location, _currentColor, _currentThickness);

                shape?.Draw(g);
            }

            picture.Image = _tempBitmap;
        }

        private void color_picker_MouseDown(object sender, MouseEventArgs e)
        {
            if (color_picker.Image == null) return;

            try
            {
                Bitmap paletteBitmap = (Bitmap)color_picker.Image;
                if (e.X >= 0 && e.X < paletteBitmap.Width && e.Y >= 0 && e.Y < paletteBitmap.Height)
                {
                    Color pickedColor = paletteBitmap.GetPixel(e.X, e.Y);
                    UpdateDrawingColor(pickedColor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка вибору кольору: {ex.Message}", "Помилка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _currentThickness = trackBar1.Value;
        }
    }
}
