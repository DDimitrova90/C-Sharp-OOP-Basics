namespace _01_Define_A_Class_Person
{
    using System;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person firstPerson = new Person
            {
                name = "Pesho",
                age = 20
            };

            Person secondPerson = new Person
            {
                name = "Gosho",
                age = 18
            };

            Person thirdPerson = new Person();
            thirdPerson.name = "Stamat";
            thirdPerson.age = 43;
        }
    }
}
