using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class CapitalizationAndMutability
    {
        public string CapitalizeWord(string word)
        {
            string capitalized = char.ToUpper(word[0]) + word.Substring(1).ToString();
            return capitalized;
        }
    }
}

//return word.Substring(0, 1).ToUpper() + word.Substring(1);

/*
 DESCRIPTION:
Your coworker was supposed to write a simple helper function to capitalize a string (that contains a single word) before they went on vacation.

Unfortunately, they have now left and the code they gave you doesn't work. Fix the helper function they wrote so that it works as intended (i.e. make the first character in the string "word" upper case).

Don't worry about numbers, special characters, or non-string types being passed to the function. The string lengths will be from 1 character up to 10 characters, but will never be empty.

*/