namespace _05_Date_Modifier
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            long result = dateModifier.CalculateDaysDifference(firstDate, secondDate);

            Console.WriteLine(result);
        }
    }
}
