namespace _03_Oldest_Family_Member
{
    using System;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int peopleNumber = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < peopleNumber; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ');
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember().ToString());
        }
    }
}
