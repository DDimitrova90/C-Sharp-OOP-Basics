namespace _09_Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] inputArgs = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rectanglesNumber = inputArgs[0];
            int intersectionChecksNumber = inputArgs[1];

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesNumber; i++)
            {
                string[] rectangleInfo = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                string id = rectangleInfo[0];
                double width = double.Parse(rectangleInfo[1]);
                double height = double.Parse(rectangleInfo[2]);
                double topLeftX = double.Parse(rectangleInfo[3]);
                double topLeftY = double.Parse(rectangleInfo[4]);

                Rectangle rectangle = new Rectangle(id, width, height, topLeftX, topLeftY);
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectionChecksNumber; i++)
            {
                string[] ids = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                string firstID = ids[0];
                string secondID = ids[1];

                Rectangle firstRectangle = rectangles.FirstOrDefault(r => r.ID == firstID);
                Rectangle secondRectangle = rectangles.FirstOrDefault(r => r.ID == secondID);

                if (firstRectangle != null && secondRectangle != null)
                {
                    bool hasIntersection = firstRectangle.CheckIfIntersect(secondRectangle);

                    if (hasIntersection)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
        }
    }
}
