using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeLike
{
    public enum Cell : int
    {
        Empty = 0,
        Food = 1,
        Prey = 2,
        Predator = 3
    }

    public class Board
    {
        private Cell[,] cells;
        private Cell[,] new_cells;
        private int width, height;
        private int pixel_size;
        private List<Point> paintcoordinates;
        private List<Cell> paintbrushes;
        Random rand = new Random();

        public Board(int width, int height, int pixel_size, bool symmetrical)
        {
            paintcoordinates = new List<Point>();
            paintbrushes = new List<Cell>();
            this.width = width / pixel_size;
            this.height = height / pixel_size;
            this.pixel_size = pixel_size;
            cells = new Cell[this.width, this.height];
            new_cells = new Cell[this.width, this.height];
            var max = Enum.GetValues(typeof(Cell)).Cast<Cell>().Max();

            rand = new Random();
            int weight_empty = 4000;
            int weight_food = 100;
            int weight_prey = 40;
            int weight_predator = 5;

            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    int chosen = rand.Next(weight_empty + weight_food + weight_prey + weight_predator);
                    if (chosen < weight_empty)
                        cells[x, y] = Cell.Empty;
                    else if (chosen < weight_empty + weight_food)
                        cells[x, y] = Cell.Food;
                    else if (chosen < weight_empty + weight_food + weight_prey)
                        cells[x, y] = Cell.Prey;
                    else
                        cells[x, y] = Cell.Predator;
                    if (symmetrical)
                    {
                        cells[x, y] = cells[x > (this.width / 2) ? this.width - x : x, y > (this.height / 2) ? this.height - y : y];
                    }
                }
            }

            this.pixel_size = pixel_size;
        }

        private Color GetCol(int x, int y)
        {
            switch (cells[x, y])
            {
                case Cell.Empty:
                    return Color.FromArgb(0, 43, 54);
                case Cell.Food:
                    return Color.FromArgb(133, 153, 0);
                case Cell.Prey:
                    return Color.FromArgb(253, 246, 227);
                case Cell.Predator:
                    return Color.FromArgb(203, 75, 22);
            }

            return Color.Black;
        }

        public void DrawBoard(DirectBitmap drawarea, PictureBox picturebox)
        {
            //for (int x = 0; x < width; x++)
            if (height < width)
            {
                Parallel.For(0, width, x =>
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x_s = 0; x_s < pixel_size; x_s++)
                        {
                            for (int y_s = 0; y_s < pixel_size; y_s++)
                                drawarea.SetPixel((x * pixel_size) + x_s, (y * pixel_size) + y_s, GetCol(x, y));
                        }
                    }
                });
            }
            else
            {
                Parallel.For(0, height, y =>
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int x_s = 0; x_s < pixel_size; x_s++)
                        {
                            for (int y_s = 0; y_s < pixel_size; y_s++)
                                drawarea.SetPixel((x * pixel_size) + x_s, (y * pixel_size) + y_s, GetCol(x, y));
                        }
                    }
                });
            }
            picturebox.Image = drawarea.Bitmap;
        }

        public Bitmap SaveBoard()
        {
            Bitmap newimage = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    newimage.SetPixel(x, y, GetCol(x, y));
                }
            }
            return newimage;
        }

        private int[] CountNeighbors(int x, int y)
        {
            int[] count = new int[4];
            count[(int)cells[CorrectCoord(x - 1, width), CorrectCoord(y - 1, height)]]++;
            count[(int)cells[CorrectCoord(x, width), CorrectCoord(y - 1, height)]]++;
            count[(int)cells[CorrectCoord(x + 1, width), CorrectCoord(y - 1, height)]]++;

            count[(int)cells[CorrectCoord(x - 1, width), CorrectCoord(y, height)]]++;
            count[(int)cells[CorrectCoord(x + 1, width), CorrectCoord(y, height)]]++;

            count[(int)cells[CorrectCoord(x - 1, width), CorrectCoord(y + 1, height)]]++;
            count[(int)cells[CorrectCoord(x, width), CorrectCoord(y + 1, height)]]++;
            count[(int)cells[CorrectCoord(x + 1, width), CorrectCoord(y + 1, height)]]++;
            return count;
        }

        private int CorrectCoord(int c, int max)
        {
            if (c < 0)
                return max - 1;
            if (c >= max)
                return 0;
            return c;
        }

        public void Step()
        {
            new_cells = new Cell[width, height];
            if (height < width)
            {
                Parallel.For(0, width, x =>
                {
                    for (int y = 0; y < height; y++)
                    {
                        new_cells[x, y] = StepInterior(x, y);
                    }
                });
            }
            else
            {
                Parallel.For(0, height, y =>
                {
                    for (int x = 0; x < width; x++)
                    {
                        new_cells[x, y] = StepInterior(x, y);
                    }
                });
            }
            cells = new_cells;

            for (int i = 0; i < paintcoordinates.Count; i++)
            {
                cells[paintcoordinates[i].X, paintcoordinates[i].Y] = paintbrushes[i];
            }
            paintcoordinates = new List<Point>();
            paintbrushes = new List<Cell>();
        }

        public Cell StepInterior(int x, int y)
        {
            Cell new_cell = cells[x, y];
            int[] neighbors = CountNeighbors(x, y);
            int food_count = neighbors[1];
            int prey_count = neighbors[2];
            int predator_count = neighbors[3];

            switch (cells[x, y])
            {
                case Cell.Empty:
                    if (food_count > 1)
                        new_cell = Cell.Food;
                    break;
                case Cell.Food:
                    if (food_count > 5)
                        new_cell = Cell.Empty;
                    if (food_count < 2)
                        new_cell = Cell.Empty;
                    if (prey_count > 0)
                        new_cell = Cell.Prey;
                    break;
                case Cell.Prey:
                    if (prey_count > 3)
                        new_cell = Cell.Empty;
                    if (prey_count < 2)
                        new_cell = Cell.Food;
                    if (predator_count > 0)
                        new_cell = Cell.Predator;
                    break;
                case Cell.Predator:
                    if (predator_count > 1)
                        new_cell = Cell.Prey;
                    if (predator_count > 2)
                        new_cell = Cell.Empty;
                    if (prey_count < 2)
                        new_cell = Cell.Empty;
                    break;
            }
            return new_cell;
        }

        public void Paint(int x, int y, Cell brush)
        {
            paintcoordinates.Add(new Point(x, y));
            paintbrushes.Add(brush);
        }

        public void Clear()
        {
            cells = new Cell[width, height];
        }
    }
}
