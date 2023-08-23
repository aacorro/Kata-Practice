using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class BuildASquare
    {
        public string GenerateShape(int n)
        {
            double squared = Math.Pow(2, n);
            string art = "";
            for (int i = 0; i < squared; i++)
            {
                art += "+";
                if((i + 1) % n == 0 && i != squared - 1)
                {
                    art += "\n";
                }
            }
            return art;
        }
    }
}/*
    public static string GenerateShape(int n)
    => string.Join("\n", Enumerable.Repeat(new string('+', n), n));
*/

/*
 DESCRIPTION:
I will give you an integer. Give me back a shape that is as long and wide as the integer. The integer will be a whole number between 1 and 50.

Example
n = 3, so I expect a 3x3 square back just like below as a string:

+++
+++
+++
*/