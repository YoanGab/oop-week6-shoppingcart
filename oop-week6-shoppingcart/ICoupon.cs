using System;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    public interface ICoupon
    {
        public double calculateDiscount(List<product> products)
        {
            double discount = 0;
            int appleCount = 0;
            int orangeCount = 0;
            foreach (product prod in products)
            {

                if (prod.Name == "apple") {
                    appleCount++;
                    if(appleCount % 2 == 0)
                    {
                        discount += prod.Price;
                    }
                }
                if (prod.Name == "orange")
                {
                    orangeCount++;
                    if (orangeCount % 3 == 0)
                    {
                        discount += prod.Price;
                    }
                }
            }
            return discount;
        }
    }
}
