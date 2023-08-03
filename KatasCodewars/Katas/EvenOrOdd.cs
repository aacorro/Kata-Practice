using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class EvenOrOdd
    {
        public  string EvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                return ("Even");
            }
            else
            {
                return ("Odd");
            }
        }
        
    }
}

//=> number % 2 == 0 ? "Even" : "Odd"; 


/*
 Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
*/