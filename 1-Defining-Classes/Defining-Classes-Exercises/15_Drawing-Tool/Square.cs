namespace _15_Drawing_Tool
{
    using System;

    public abstract class Square
    {
        public Square(int width, int hength)
        {
            this.Width = width;
            this.Hength = hength;
        }

        public int Width { get; set; }

        public int Hength { get; set; }

        public void Draw()
        {
            Console.WriteLine("|" + new string('-', this.Width) + "|");

            for (int currRow = 0; currRow < this.Hength - 2; currRow++)
            {
                Console.WriteLine("|" + new string(' ', this.Width) + "|");
            }

            Console.WriteLine("|" + new string('-', this.Width) + "|");
        }
    }
}
