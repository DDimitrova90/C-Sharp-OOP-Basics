namespace _01_MathOperation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            MathOperations mo = new MathOperations();

            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2M, 3.3M, 4.4M));
        }
    }
}
