﻿namespace _02_Book_Shop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        {
        }

        public override decimal Price
        {
            get
            {
                return base.Price * 1.3M;
                // OR:
                //return base.Price;
            }
            //protected set
            //{
            //    base.Price = value * 1.3M;
            //}
        }
    }
}
