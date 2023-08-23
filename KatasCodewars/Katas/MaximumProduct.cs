using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class MaximumProduct
    {
        public static int AdjacentElementsProduct(int[] array)
        {
            int maxProduct = int.MinValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int product = array[i] * array[i + 1];
                maxProduct = Math.Max(maxProduct, product);
            }
            return maxProduct;
        }
    }
}

/*
  return array.Skip(1).Select((x,i) => x * array[i]).Max();
*/

/*
 DESCRIPTION:
Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.

Notes
Array/list size is at least 2.
Array/list numbers could be a mixture of positives, negatives also zeroes .

Input >> Output Examples
adjacentElementsProduct([1, 2, 3]); ==> return 6
*/