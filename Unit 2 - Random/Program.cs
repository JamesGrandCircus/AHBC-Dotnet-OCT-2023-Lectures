namespace Unit_2___Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleOne();

            // What is the difference betwee a Function and a Method?
            // a METHOLD is SIMPLY a Function that BELONGS to a TYPE
        }

        // Creating a Random into memory!
        static void ExampleOne()
        {
            // We use a Radom Number Generator to get a number between an
            // Lower Bound and an UpperBound
            // for example, a number between 1 - 6... kind of like a 
            // die (dice)

            // creating a new Random Object (more on objects later) into memory
            // which allows us to acces its METHODS.
            Random randomNumberGenerator = new Random();

            // we are accesing the Next() method that belongs to the Random type.
            int randomNumber = randomNumberGenerator.Next(0, 10);
            Console.WriteLine(randomNumber);

            int count = 0;
            while (randomNumber != 5)
            {
                count++;
                randomNumber = randomNumberGenerator.Next(0, 10);
            }
            Console.WriteLine($"we are finally free!, we guessed {count} times!");
        }

        static void ExampleTwoMethods()
        {
            // Console is the "Type", "WriteLine" is it's METHOD (aka, a function)
            Console.WriteLine();

            // "int" is the type, Parse is the Method
            int.Parse("42");

            // in order to access a "Public Member" or a method in this case,
            // from a type, you simply use DOT NOTATION, 
            //  type.Method()
            //      ⬆️      
            // the "dot"  in dot notation 
        }
    }
}