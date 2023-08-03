﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class StopGninnipsMySdroW
    {
        public string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (var i = 0; i < words.Count(); i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                }
            }

            return string.Join(" ", words);
        }
    }
}


/*
 * DESCRIPTION:
Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

Examples:

spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test" 
spinWords( "This is another test" )=> returns "This is rehtona test"
 */