
using System;
namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            product Apple = new product("apple", 0.60);
            product Orange = new product("orange", 0.25);
            product Banana = new product("banana", 0.15);
            product Chair = new product("chair", 25);
            shoppingCart shoppingCart1 = new shoppingCart();
            int choice = 0;
            do
            {
                Console.WriteLine("Press 1 to add an Apple");
                Console.WriteLine("Press 2 to add an Orange");
                Console.WriteLine("Press 3 to add a Banana");
                Console.WriteLine("Press 4 to add a Chair");
                Console.WriteLine("Press 5 to check your shoppingCart");
                Console.WriteLine("Press -1 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        shoppingCart1.AddProduct(Apple);
                        break;
                    case 2:
                        shoppingCart1.AddProduct(Orange);
                        break;
                    case 3:
                        shoppingCart1.AddProduct(Banana);
                        break;
                    case 4:
                        shoppingCart1.AddProduct(Chair);
                        break;
                    case 5:
                        shoppingCart1.print();
                        break;
                }
                    
            } while (choice != -1);
        }
    }
}
