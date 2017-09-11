namespace _04_Random_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class RandomList : ArrayList
    {
        private Random rnd;
        
        public RandomList()
        {
            this.rnd = new Random();
        }

        public object RandomString(IList<string> data)
        {
            int index = rnd.Next(data.Count);
            string removedElement = data[index];
            data.Remove(removedElement);

            return removedElement;
        }
    }
}
