namespace _06_Animals
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                string[] animalArgs = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (animalType)
                    {
                        case "Cat":
                            Cat cat = new Cat(animalArgs[0], int.Parse(animalArgs[1]), animalArgs[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Dog":
                            Dog dog = new Dog(animalArgs[0], int.Parse(animalArgs[1]), animalArgs[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(animalArgs[0], int.Parse(animalArgs[1]), animalArgs[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(animalArgs[0], int.Parse(animalArgs[1]), animalArgs[2]);
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(animalArgs[0], int.Parse(animalArgs[1]), animalArgs[2]);
                            Console.WriteLine(tomcat);
                            break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                animalType = Console.ReadLine();
            }
        }
    }
}
