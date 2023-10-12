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


            // Operators!
            // Assignment Operators.
            string exampleOperator = "I'm an assignment operator!";

            int numberExample = 5;
            numberExample = numberExample + 3;
            numberExample += 3;

            numberExample = numberExample - 3;
            numberExample -= 3;

            numberExample /= 3;
            numberExample *= 3;

            numberExample = numberExample % 3;
            numberExample %= 3;

            // Arithmetic Operators
            // 3 * (x + 2) - 2 * (x - 2)

            int numberExample2 = 3 + 3;
            numberExample2 = 3 - 3;
            numberExample2 = 3 * 3;
            numberExample2 = 5 / 3; // if you divide with an integer type,
            // you LOSE the remainder value. because there IS no 
            // decimals in this context

            numberExample2 = 5 % 3;

            // mod even number example
            int modExample = 2 % 2; // remainder 0... divides evenly
            modExample = 13 % 2; // remainder 1 .. NOT even

            // incrementor decrementor, assignment operators
            int i = 0;
            i = i + 1;
            i += 1;
            i++; // incrementor is adding 1 to i.

            int j = 0;
            j = j - 1;
            j -= 1;
            j--; // decrementor is subtracting 1 to j.

            // --j, and j-- are different operations,
            // --j will subtract AFTER asignment
            // j-- will subtract BEFORE assignemnt,
            // this is only relevant if you want to store the results
            // if that assignment in a DIFFERENT variable.
            // if j = 2
            int jReallyNew = j--; //  1
            int jReallyOld = --j; //  2


            Console.WriteLine("Hello, World!");
        }
    }
}