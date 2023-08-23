using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class NameOnBillboard
    {
        public double Billboard(string name, double price = 30)
        {
            double cost = 0;
            foreach (char character in name)
            {
                cost += price;
            }
            return cost;
        }
    }
}

//return name.Length / (1/price);

/*
 You can print your name on a billboard ad. Find out how much it will cost you. Each character has a default price of £30, but that can be different if you are given 2 parameters instead of 1.

You can not use multiplier "*" operator.

If your name would be Jeong-Ho Aristotelis, ad would cost £600. 20 leters * 30 = 600 (Space counts as a character).
*/