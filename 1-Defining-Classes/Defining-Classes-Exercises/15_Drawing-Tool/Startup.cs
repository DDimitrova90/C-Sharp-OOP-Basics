namespace _15_Drawing_Tool
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();
            int width = 0;
            int height = 0;

            if (figureType == "Square")
            {
                width = int.Parse(Console.ReadLine());
                height = width;
            }
            else if (figureType == "Rectangle")
            {
                width = int.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
            }

            Square square = new CorDraw(width, height);
            square.Draw();
        }
    }
}
