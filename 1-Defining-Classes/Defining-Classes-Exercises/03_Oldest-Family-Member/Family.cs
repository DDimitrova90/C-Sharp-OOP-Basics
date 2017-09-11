namespace _03_Oldest_Family_Member
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        public List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            if (this.members.Where(m => m.name == member.name).Count() == 0)
            {
                this.members.Add(member);
            }
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(m => m.age).FirstOrDefault();
        }
    }
}
