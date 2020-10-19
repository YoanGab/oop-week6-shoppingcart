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
            int appleCount = 0;
            int orangeCount = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                if(Products[i].Name == "apple")
                {
                    if(appleCount % 2 == 0)
                    {
                        price += Products[i].Price;
                        appleCount++;
                    }
                    else
                    {
                        appleCount++;
                    }
                }
                else if (Products[i].Name == "orange")
                {
                    orangeCount++;
                    if(orangeCount % 3 != 0)
                    {
                        price += Products[i].Price;
                    }
                }
                else
                {
                    price += Products[i].Price;
                }
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
