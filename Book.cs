using System;

namespace BookLib
{
    public class Book : AbstractItem
    {
        public string ISBN { get; set; }

        public Book() : base("Default")
        {
            ISBN = Guid.NewGuid().ToString();
        }

        public Book(string title) : base(title)
        {
            ISBN = Guid.NewGuid().ToString();
        }

        public override double GetPrice() => 0.9 * base.GetPrice();
    }
}