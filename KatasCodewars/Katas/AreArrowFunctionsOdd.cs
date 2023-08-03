using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class AreArrowFunctionsOdd
    {
        public static List<int> Odds(List<int> values) =>
            values.Where(i => i % 2 != 0)
            .ToList();
    }
}

//


/*
 * DESCRIPTION:
Time to test your basic knowledge in functions! Return the odds from a list:

[1, 2, 3, 4, 5]  -->  [1, 3, 5]
[2, 4, 6]        -->  []
*/