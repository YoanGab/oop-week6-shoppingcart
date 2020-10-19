using System;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            product Apple = new product("apple", 0.60);
            product Orange = new product("orange", 0.25);

            shoppingCart shoppingCart1 = new shoppingCart();
            shoppingCart1.AddProduct(Apple);
            shoppingCart1.AddProductsArray(new product[]{Orange, Apple});
            Console.WriteLine(shoppingCart1.getContent());
            Console.WriteLine(shoppingCart1.getPrice());
        }
    }
}
