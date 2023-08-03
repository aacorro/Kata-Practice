using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class ReverseSequence
    {
        public static int[] ReverseSeq(int n)
        {
            var result = new List<int>();
            for (var i = n; i > 0; i--)
            {
                result.Add(i);
            }
            return result.ToArray();
        }
    }
}

//return Enumerable.Range(1, n).Reverse().ToArray();

/*
 * DESCRIPTION:
Build a function that returns an array of integers from n to 1 where n>0.

Example : n=5 --> [5,4,3,2,1]
*/
