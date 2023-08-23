using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class CombineStrings
    {
        public string CombineNames(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}

/*
 return $"{firstName} {lastName}";
*/

/*
 Combine strings function
Create a function named (Combine_names) that accepts two parameters (first and last name). The function should return the full name.

Example:

CombineNames("James", "Stevens")
returns:

"James Stevens"
*/