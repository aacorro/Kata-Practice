using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class TipCalculator
    {
        public static int CalculateTip(double amount, string rating)
        {
            rating = rating.ToLower();
            if (string.IsNullOrEmpty(rating))
            {
                return -1;
            }
            else
            {
                switch (rating)
                {
                    case "terrible":
                        return 0;
                    case "poor":
                        return (int)(Math.Ceiling(amount * .05));
                    case "good":
                        return (int)(Math.Ceiling(amount * .10));
                    case "great":
                        return (int)(Math.Ceiling(amount * .15));
                    case "excellent":
                        return (int)(Math.Ceiling(amount * .20));
                    default: return -1;
                }
            }
        }
    }
}

/*
 * ALTERNATIVE SOLUTION:
 public static int CalculateTip(double amount, string rating) =>
    rating.ToLower() switch
    {
       "terrible" => 0,
        "poor" => (int)Math.Ceiling(amount * 0.05),
        "good" => (int)Math.Ceiling(amount * 0.1),
        "great" => (int)Math.Ceiling(amount * 0.15),
        "excellent" => (int)Math.Ceiling(amount * 0.2),
        _ => -1,
        };
*/


/*
 DESCRIPTION:
Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.

You need to consider the following ratings:

Terrible: tip 0%
Poor: tip 5%
Good: tip 10%
Great: tip 15%
Excellent: tip 20%
The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:

"Rating not recognised" in Javascript, Python and Ruby...
...or null in Java
...or -1 in C#
Because you're a nice person, you always round up the tip, regardless of the service.
*/