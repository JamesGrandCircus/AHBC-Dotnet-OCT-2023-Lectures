namespace Unit_2___Fundamental_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STATEMENTS
            // a statement is a complete line of code that is CAPPED and ENDED with a semicolon.
            // your compiler will read each statement sequentially.
            string name = "James";

            // Identifiers
            // things "you the developer" will name YOURSELF to help IDENTIFY your .... stuff (varialbes)
            // Keywords
            // reserved words that your programming language will NOT let you use as identifiers
            //
            // Variables!
            // a variable is a box that contains "data"
            //
            // a) variable type
            // b) variable identifier
            // c) assignment operator 
            // d) the actual DATA that you want to store, using the correct type
            string lastName = "Jackson";


            // Data types and Variables and such!
            // strongly typed language, which means if a variable is of type A, it CANNOT change to
            // type B
            string middleName = "Brian";
            // int age = middleName; CANNOT BE DONE, age is an int, and middlName is a string!

            // TYPES
            // value types
            // VALUE TYPES ALWAYS HAVE A DEFAULT VALUE;
            // number types
            // integer type numbers
            byte w = 2;
            short z = 4;
            int x = 1; // you will be using THIS GUY ALMOST EXCLUSIVELY
            long y = 3;

            int unassigned; // creating an UNASSGINED VARIABLE

            // decimal types - floating point types.
            // Literals is just "RAw data in your code"
            // floating point numbers are NOT perfectly accurate.
            float  zDecimal = 0.1F; // I never use this ... a float is a smaller double
            double xDouble = 0.2; // I use this, float fast
            decimal yDecimal = 0.3M;//  I use this -> NOT A FLOAT, PERFECTLY ACCURATE, these are "slower"

            // booleans
            // booleans by themselves are either going to be true of false!
            bool isTrue = true;
            bool isFalse = false;

            // the char
            char letter = 'A';// the default value for a char is the first ASCII code... what is that? google it

            // not so value type
            // the string
            string fullName = "James Brian Jackson"; // NOT a value type, a string is a "collection" of characters
            // STRUNG together.


            // Pre excorsize 
            // ReadLine() returns of type "string" therefore it needs to store it's "RESULT" or "VALUE" in 
            // a variable ALSO of type string.
            // this is how you get user input from the console.
            Console.WriteLine("Hey, give me your first name please!");
            string nameUserInput = Console.ReadLine();

            // grab the user input of type string, and combine it with another string literal
            // string interpolation allows you to "ad lib" your variable IN another string.
            string nameOutput = $"Hello {nameUserInput}, nice to meet you, welcome to GC!";
            Console.WriteLine(nameOutput);


            Console.WriteLine("Hey, how old are you...?");
            string userInputAge = Console.ReadLine();
            int userAge = int.Parse(userInputAge);

            double doubleUserAge = double.Parse(userInputAge);
            float flatUsage = float.Parse(userInputAge);
            decimal decimalUserAge = decimal.Parse(userInputAge);


            string ageOutput = $"Oh, so you are {userAge} years old, great!.... I think...";
            Console.WriteLine(ageOutput);

            Console.WriteLine("Hello, World!");
        }
    }
}