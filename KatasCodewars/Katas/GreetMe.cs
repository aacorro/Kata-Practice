using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class GreetMe
    {
        public string Greet(string name)
        {
            string capitalized = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return $"Hello { capitalized}!";
        }
    }
}

/*
 return $"Hello {name.ToUpper()[0] + name.ToLower().Substring(1)}!";
*/


/*DESCRIPTION:
Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

Example:

"riley" --> "Hello Riley!"
"JACK"  --> "Hello Jack!"
*/