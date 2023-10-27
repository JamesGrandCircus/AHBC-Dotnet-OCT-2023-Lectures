using System.Text.RegularExpressions;

namespace Unit_3___Regular_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RunExampleOne();
        }

        // Regular Expression
        static void RunExampleOne()
        {
            string zipCode = GetValidZipCode();
            Console.WriteLine(zipCode);
        }

        static string GetValidZipCode()
        {
            while (true)
            {
                Console.Write("Hey user, give me your freaking zip code! ");
                string userInput = Console.ReadLine();
                Regex zipCodePattern = new Regex(@"^[0-9]{5}(-[0-9]{4})?$");
                if (zipCodePattern.IsMatch(userInput))
                {
                    return userInput;
                }
             
               Console.WriteLine("Invalid zipcode try again.");
            }
        }
    }
}