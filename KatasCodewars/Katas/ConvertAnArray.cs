using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class ConvertAnArray
    {
        public string Contamination(string text, string character)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(character))
            {
                return string.Empty;
            }
            return new string(character[0], text.Length);
        }
    }
}

/*
 DESCRIPTION:
An AI has infected a text with a character!!

This text is now fully mutated to this character.

If the text or the character are empty, return an empty string.
There will never be a case when both are empty as nothing is going on!!

Note: The character is a string of length 1 or an empty string.

Example
text before = "abc"
character   = "z"
text after  = "zzz"
*/