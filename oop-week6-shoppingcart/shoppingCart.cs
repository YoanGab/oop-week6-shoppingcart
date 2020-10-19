using System;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    public class shoppingCart
    {
        List<product> Products { get; set; }

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
            Products.Add(prod);
        }

        public void AddProductsArray(product[] prod)
        {
            for(int i = 0; i < prod.Length; i++)
            {
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
    }
}
