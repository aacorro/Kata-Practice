using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class CalculateAverage
    {
        public double Average(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            } else
            {
                double result = Average(array);
                return result;
            }
          
        }
    }
}
//Shorest:
//return array.Length == 0 ? 0 : array.Average();

/*
 Kata:
Write a function which calculates the average of the numbers in a given list.

Note: Empty arrays should return 0.
*/