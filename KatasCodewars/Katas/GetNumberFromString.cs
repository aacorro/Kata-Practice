using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class GetNumberFromString
    {
        public int getNumberFromString(string s)
        {
            s = Regex.Replace(s, @"\D", "");
            int nums = int.Parse(s);
            return nums;
        }
    }
}
/*
Alternative solution:
return Int32.Parse(Regex.Replace(s, @"[^\d]", ""));
*/

/*
 DESCRIPTION:
Write a function which removes from string all non-digit characters and parse the remaining to number. E.g: "hell5o wor6ld" -> 56

Function:

GetNumberFromString(string s)
*/

/*
 Break down:

1. public int getNumberFromString(string s): This line defines a public method named getNumberFromString that takes a single parameter of type string named s. The method is expected to return an integer.

2. {: The opening curly brace indicates the start of the method's body. Everything inside the curly braces constitutes the method's implementation.

3. s = Regex.Replace(s, @"\D", "");: This line uses the Regex.Replace method to perform a regular expression-based replacement on the input string s. The regular expression pattern \D matches any non-digit character. The replacement is an empty string "", effectively removing all non-digit characters from the input string. The modified string with only digits is stored back in the s variable.

4. int nums = int.Parse(s);: This line attempts to parse the modified string s into an integer. The int.Parse method is used for this purpose. If the modified string contains only digits, the parsing will succeed, and the resulting integer will be stored in the nums variable.

5. return nums;: This line is a return statement. It returns the integer value stored in the nums variable to the caller of the method.

6. }: The closing curly brace marks the end of the method's body.

To summarize, this method takes a string as input, removes all non-digit characters from the string using regular expressions, and then attempts to parse the resulting string into an integer. The parsed integer is then returned as the output of the method. It's important to note that this code assumes the input string contains a sequence of digits and possibly other characters that need to be removed to obtain the desired number. If the input doesn't conform to this pattern, the code might result in errors during runtime. Additionally, this code doesn't handle potential exceptions that might occur during parsing (e.g., if the input string is not a valid integer).*/


/*
 Calling the method:

  public static void Main(string[] args)
    {
        // Create an instance of the GetNumberFromString class
        GetNumberFromString numberExtractor = new GetNumberFromString();

        // Input string containing mixed characters
        string inputString = "abc123def456";

        // Call the getNumberFromString method to extract the number
        int extractedNumber = numberExtractor.getNumberFromString(inputString);

        // Print the extracted number
        Console.WriteLine("Extracted Number: " + extractedNumber);

    }*/