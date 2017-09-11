namespace _05_Stack_Of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings
    {
        private List<string> data;

        //public StackOfStrings()
        //{
        //    this.data = new List<string>();
        //}

        public void Push(string element)
        {
            this.data.Add(element);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty. There is not element for popping.");
            }

            string lastElement = this.data.Last();
            this.data.Remove(lastElement);

            return lastElement;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty. There is not element for popping.");
            }

            return this.data.Last();
        }

        public bool IsEmpty()
        {
            if (this.data.Count() == 0)
            {
                return true;
            }

            return false;
        }
    }
}
