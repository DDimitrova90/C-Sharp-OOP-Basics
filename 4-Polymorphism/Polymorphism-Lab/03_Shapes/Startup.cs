namespace _03_Shapes
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Shape rectangle = new Rectangle(2, 3);
            Shape circle = new Circle(3);

            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.Draw());

            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.Draw());
        }
    }
}
