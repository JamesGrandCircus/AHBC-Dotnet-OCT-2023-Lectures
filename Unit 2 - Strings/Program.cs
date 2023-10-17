using System.Runtime.InteropServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Text;

namespace Unit_2___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Although we are covering STring METHODS, OTHER types
            // will ALSO have helper Methods / Properties tied to them
            // to help you solve your problems.  we are only covering strings
            // because it's more relatable and they happen to have a bunch
            // of helper methods.  but AGAIN.  consider MOST types to have
            // some sort of Method you can call on.
            Console.WriteLine("Hello, World!");

            //RunStringExampleOne();
            //RunStringExampleTwo();
            //RunStringExampleThree();
            //RunStringExampleFour();
            RunStringExampleFive();
            //RunStringExampleSix();
        }


        // STRINGS ARE IMMUTABLE
        static void RunStringExampleOne()
        {
            // strings are immutable, once a string exist, the values inside of 
            // that string, CANNOT BE CHANGED.
            //             01234
            string name = "James";
            // name[2] = 'b'; // CANNOT BE DONE, UN COMMENT AND TRY YOURSELF!!

            // anytime you COMBINE strings together, you are 100% making a NEW string
            // in memory EVERY TIME.
            string fullName = $"{name} Jackson";

            // Strings are REFERENCE TYPES (more on that once we get to collections)
            // HOWEVER, because of the immutable nature of strings, you are COPYING
            // this string as if it was a Value type, like an int, or a double
            string otherName = fullName;

            // strings are READ ONLY, but you can COPY the chars in the string
            // and contain them into memory
            char secondLetter = fullName[1];
        }

        // CREATING STRINGS
        static void RunStringExampleTwo()
        {
            // assigning a string literal into a variable
            string name = "James";
            string lastName = "Jackson";

            // string concatenation, using the '+' operator to combine strings together
            string fullName = name + " " + lastName;  // "James Jackson"

            // string Interpolation, using a Dollar sign at the begenning of your string and 
            // 'injecting' variables into your string like madlibs
            fullName = $"{name} {lastName}"; // ➡️ "James Jackson"

            // creating a string with a single character of a certain length, useful
            // if you want to repeat your code.
            string rowSeperator = new string('=', 32); // ➡️ "================================"

            // strings are just "Collections" of characters, and we can create a new string
            // with a collection of characters

            // more on this syntax in arrays lesson, creating an Array of characters into memory
            // the "new" keyword creates a 'new' object of THAT type into memory
            char[] letters = new char[]{ 'J', 'a', 'm', 'e', 's' };
            // I would only do this if I "NEED" the Methods built into the String type.
            name = new string(letters); // ➡️ "James"

            // as a quick aside, behind the scenes... string interpolation and string concatenation
            // is USING the string.Concat() method

            fullName = string.Concat(name, " ", "some words here"); // ➡️ "James Jackson"
        }

        // comparing string equality
        static void RunStringExampleThree()
        {
            string valueOne = "hello";
            string valueTwo = "HeLLo";

            if (valueOne == valueTwo) // ➡️ false, casing is NOT the same
            {

            }

            //  valueOne.ToLower() == valueTwo.ToLower() , the ideas to make the casing match
            if (valueOne.ToUpper() == valueTwo.ToUpper()) // ➡️ true, casing is the same
            {

            }

            // most types of an Overwitten version of the Equals Method
            if (valueOne.Equals(valueTwo, StringComparison.OrdinalIgnoreCase)) // ➡️ true, ignoring case
            {

            }
        }

        // some example string methods
        static void RunStringExampleFour()
        {
            //                 0123456789
            string fullName = "James B. Jackson";
            int index = fullName.IndexOf(".");

            int lastInde = fullName.LastIndexOf("J"); // ➡️ 9, the Last instance of 'J' in fullName lives at index 9

            bool endsWithLastName = fullName.EndsWith("Jackson"); // ➡️ True, fullName does end with "Jackson"

            string kInsteadOfJName = fullName.Replace("Ja", "Ku"); // ➡️ { "Kumes B", " Kuckson" }

            string[] namesInCollection = fullName.Split('.'); // ➡️ { "James B", " Jackson" }

            string[] phoneNumberParts = "123-456-4565".Split('-'); // ➡️ { "123", "456", "4565"}

            string[] otherSplitExample = "James-.-B-.-Jackson".Split("-.-"); // ➡️ { "James", "B", "Jackson"} , we are removing the "-.-"

            int indexOfMiddleInitial = fullName.IndexOf('.') - 1; // ➡️ 6, the period lives at index 7 - 1 is 6
            string hopefullyMiddleInitialOnly = fullName.Substring(indexOfMiddleInitial, 2); // ➡️ "B."
            string copiedFullName = fullName.Substring(0, fullName.Length - 1); // ➡️ "James Jackso", omitting the last character

            //                012
            string example = "Ace"; // Length is 3, we can literally count the characters
            char lastLetter = example[example.Length - 1]; // ➡️ 'n', the last character of fullName is 'n'
        }

        // Lets clean those strings up!
        static void RunStringExampleFive()
        {
            string userInput = "       James Jackson              ";
            string trimmedInput = userInput.Trim(); // ➡️ "James Jackson"

            string startTrimmedInput = userInput.TrimStart(); // "       James Jackson"
            string endTrimmedInput = userInput.TrimEnd(); // "James Jackson              "

            string otherUserInput = "     James            Jackson    ".Trim();
            string[] betweenOrOther = otherUserInput.Split(' ');

            // removing the in between whitespace from otherUserInput
            int startingIndexSpace = otherUserInput.IndexOf(' '); // ➡️ 6, the first white space is at index 6
            int endingIndexSpace = otherUserInput.LastIndexOf(' '); // ➡️ 18, the last white space is at index 18
            string startingWord = otherUserInput.Substring(0, startingIndexSpace); // ➡️ "James" starting at index zero, get characters all the way to the first whitespace 6
            string endingWord = otherUserInput.Substring(endingIndexSpace); // ➡️ "Jackson", starting at index 18, go all the way to the rest of the string
            string hopefullyCleanString = $"{startingWord} {endingWord}"; // ➡️ "James Jackson", combine starting word with ending word and put a white space in between

            // more on Regex later!
            Regex pattern = new Regex(@"\s"); // white space regular expression
            string replacedNamed = pattern.Replace(otherUserInput, string.Empty); // replace all white spaces with nothing, more on Regex later
        }

        // String Building
        // think of string builders as a MUTABLE string, a means to 
        // change your string before it is actually a string!
        static void RunStringExampleSix()
        {
            string otherUserInput = "     James            Jackson    ".Trim();

            StringBuilder builder = new StringBuilder();
            foreach (string word in otherUserInput.Split(" "))
            {
                if (!string.IsNullOrEmpty(word))
                {
                    builder.Append(word);
                }
            }
            
            string wordWithoutWhiteSpace = builder.ToString();
        }
    }
}