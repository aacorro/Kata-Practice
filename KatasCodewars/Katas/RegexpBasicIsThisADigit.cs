using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public static class RegexpBasicIsThisADigit
    {
        public static bool Digit(this string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length != 1)
            {
                return false;
            }
            char digitChar = s[0];
            return char.IsDigit(digitChar);
        }
    }
}

/* 
 return Regex.IsMatch(s, @"^\d\z");
 */

/*
 DESCRIPTION:
Implement String#digit? (in Java StringUtils.isDigit(String)), which should return true if given object is a digit (0-9), false otherwise.
*/

/*
 Let's go through the steps:

public static bool Digit(this string s): This line defines a static extension method named Digit that extends the string class. The method takes a single parameter of type string, referred to as s, and is expected to return a boolean value.

if (string.IsNullOrEmpty(s) || s.Length != 1): This if statement checks whether the input string s is either null, empty, or has a length other than 1. If any of these conditions are met, the method returns false, indicating that the input is not a valid single digit.

char digitChar = s[0];: This line retrieves the character at the first (and only) index of the input string s and stores it in the digitChar variable.

return char.IsDigit(digitChar);: This line uses the char.IsDigit method to check whether the digitChar is a digit character. If the character is a digit, the method returns true, indicating that the input string contains a valid single digit character.

In summary, this extension method Digit allows you to check whether a given string represents a single digit character. It returns true if the string is a single digit character, and false otherwise. Keep in mind that this method assumes the input string contains only one character and doesn't account for multi-digit numbers.
 */

/*
 Calling the method:
public class Program
{
    public static void Main(string[] args)
    {
        // Test cases
        string digitString = "5";
        string nonDigitString = "abc";
        string emptyString = "";

        // Call the Digit extension method and print the results
        Console.WriteLine($"Is '{digitString}' a digit? {digitString.Digit()}");
        Console.WriteLine($"Is '{nonDigitString}' a digit? {nonDigitString.Digit()}");
        Console.WriteLine($"Is '{emptyString}' a digit? {emptyString.Digit()}");
    }
}

In this example, we've defined the Digit extension method inside the StringExtensions class. Then, in the Program class, we call the Digit method on different strings (digitString, nonDigitString, and emptyString) and print the results to the console. This demonstrates how the extension method works for checking whether a string represents a single digit character.
*/