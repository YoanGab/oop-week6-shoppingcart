using System;
namespace oop_week6_shoppingcart
{
    public class product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
