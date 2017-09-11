namespace _02_Class_Box_Data_Validation
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            Box figure;

            try
            {
                figure = new Box(length, width, height);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return;
            }

            Console.WriteLine($"Surface Area - {figure.GetSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {figure.GetLateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {figure.GetVolume():F2}");
        }
    }
}
