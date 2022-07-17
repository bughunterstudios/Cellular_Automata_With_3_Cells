using System.Diagnostics;
using System.Drawing.Imaging;

namespace GameOfLifeLike
{
    public partial class Form1 : Form
    {
        DirectBitmap drawarea;
        Board board;
        int pixelsize = 1;
        bool symmetrical = false;
        Cell brush = Cell.Food;
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;

            Setup();

            timer.Start();
        }

        private void Setup()
        {
            drawarea = new DirectBitmap(picturebox.Size.Width, picturebox.Size.Height);
            picturebox.Image = drawarea.Bitmap;

            board = new Board(picturebox.Size.Width, picturebox.Size.Height, pixelsize, symmetrical);
            board.DrawBoard(drawarea, picturebox);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            board.Step();
            board.DrawBoard(drawarea, picturebox);
        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            /*if (timer.Enabled)
                timer.Stop();
            else
                timer.Start();*/
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                board.Step();
                board.DrawBoard(drawarea, picturebox);
            }

            if (e.KeyChar == 's')
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    board.SaveBoard().Save(dialog.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Setup();
        }

        private void speed_numeric_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)speed_numeric.Value;
        }

        private void pixelsize_numeric_ValueChanged(object sender, EventArgs e)
        {
            pixelsize = (int)pixelsize_numeric.Value;
            Setup();
        }

        private void symmetrical_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            symmetrical = symmetrical_checkbox.Checked;
            Setup();
        }

        private void picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            board.Clear();
        }

        private void picturebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;

                board.Paint(coordinates.X / pixelsize, coordinates.Y / pixelsize, brush);
            }
        }

        private void picturebox_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void empty_btn_Click(object sender, EventArgs e)
        {
            brush = Cell.Empty;
        }

        private void food_btn_Click(object sender, EventArgs e)
        {
            brush = Cell.Food;
        }

        private void prey_btn_Click(object sender, EventArgs e)
        {
            brush = Cell.Prey;
        }

        private void predator_btn_Click(object sender, EventArgs e)
        {
            brush = Cell.Predator;
        }
    }
}