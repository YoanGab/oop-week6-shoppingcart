using System;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    public class shoppingCart : ICoupon
    {
        public List<product> Products { get; set; }

        public shoppingCart()
        {
            Products = new List<product>();
        }

        public shoppingCart(List<product> products)
        {
            Products = products;
        }

        public void AddProduct(product prod)
        {
            if(prod.Name == "apple")
            {
                Products.Add(prod);
            }
            Products.Add(prod);
        }

        public void AddProductsArray(product[] prod)
        {
            for(int i = 0; i < prod.Length; i++)
            {
                if (prod[i].Name == "apple")
                {
                    Products.Add(prod[i]);
                }
                Products.Add(prod[i]);
            }
        }

        public double getPrice()
        {
            double price = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                price += Products[i].Price;
            }
            ICoupon coupon = new shoppingCart();
            price -= coupon.calculateDiscount(Products);
            return price;
        }

        public string getContent()
        {
            string content = "";
            for (int i = 0; i < Products.Count; i++)
            {
                content += Products[i].Name + " ";
            }
            return content;
        }

        public void print()
        {
            Console.WriteLine("Your shopping cart contains : " + getContent());
            Console.WriteLine("Its price is : " + getPrice() + "euros");
        }
    }
}
