namespace Unit_3___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays are used sparingly! they most serve as a 9good 
            // TEACHING TOOL!!! in th real world, you will typically use
            // a type called a List<T>.  the ONLY real time you use arrays
            // in code, is IF you know the exact lenght of something you
            // want to loop over.
            //ExampleOne();
            //ExampleTwo();
            //ExampleThree();
            // ExampleFour();
            // ExampleFive();
            // ExampleSix();
            // ExampleSeven();
            ExampleEight();
        }

        // An array is a FIXED SIZED Collection of items of the same type.
        // Arrays can DEFINED of ANY type, the elements just need to be the SAME TYPE
        // for example, an interger array can ONLY contain integers
        // a string array can ONLY contain strings
        // ELements are the "ITEMS" in an array
        static void ExampleOne()
        { //                              these are NOT scoping brackets
          //                              these curly brackets represents
          //       length of array ⬇️   ⬇️ the creation of an object "literal"
            int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 }; // => Length: 6
                                                             //                      index 0  1  2  4  5  5
                                                             // arrays are of SET LENGTH, this array has a LENGTH of 6, 
                                                             // it will NEVER GROW OR SRHINK!!!!

            // this is how you GET an element out of your array.
            // your reference the variable the array live in, and use
            // bracket notation and pass in the INDEX ADDRESS to get the 
            // ELEMENT that lives at that INDEX
            int numAtIndexTwo = numbers[2];


            // this is how you CHANGE or MUTATE an element in an array
            // just like GETTING an element at an index, you can SET
            // a value at a given index ALSO using bracket NOTATION,
            // you provide the index, then you ASSIGN at that index
            // like you would assign a variable
            numbers[0] = 25;

            // other syntax you can use to create arrays memory

            // you do NOT have to explicitly GIVE  the LENGTH of your 
            // ARRAY IF and ONLY IF you are creating an array with an
            // OBJECT LITERAL.. in other words, the lenght is inferred.
            int[] numbersTwo = new int[] { 1, 2, 3, 4, 5, 6 };

            // you do NOT need to provide the type that the Array is 
            // IF Your variable already DELCARES the type for you, in other 
            // words, just the the length in this and the previous example,
            // the type is inferred
            int[] numbersThree = new[] { 1, 2, 3, 4, 5, 6 };

            // you can also make an array by ONLY providing the length
            // WITHOUT an object literal, but you ALSO have to provide the 
            // type. IF you create a new array of a given type without first
            // DEFINING that type! the array will be filled with elements of
            // DEFAULT VALUES.
            int[] numbersFour = new int[7];

            Console.WriteLine(numbersFour);
        }

        //For each looping over arrays
        static void ExampleTwo()
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6 };
            // The most common type of Loop you will use, foreach loops
            // allow you to loop over each element WITHOUT an indexer
            Console.Write('[');
            foreach (int number in numbers)
            {
                Console.Write($"{number}, ");
            }
            Console.Write(']');
        }

        // Reference TYPES VS. Value TYPES and NULLS
        static void ExampleThree()
        {
            // A value type is a variable that CONTAINS IT'S VALUE
            // it WEARS IT ON IT'S SLEEVE, the VARIABLE ITSELF
            // IS!!! the Value.. what does that imply!
            // most number types are VALUE types, in fact, system
            // type that is a struct, is a value type!
            // simply ctrl + left click on the type name like 'int'
            // and you will see that it is a struct
            int x = 5;

            // x is 5, and y is now 5. (y is COPYING x, so x still keeps it's value)
            int y = x;

            // x is 3, and y is STILL 5!!!!!!!!!
            x = 3;

            // Reference types are JUST A REFERENCE TO THAT VALUE IN MEMORY
            // REFERENCE TYPES DO NOT OWN THAT VALUE!!! they are LITERALLY
            // a Pointer -> TO that VALUE in MEMORY
            int[] numbers = new int[] { 1, 2, 3, 4 };
            int[] numbersTwo = numbers; // we are COPYING the POINTER or REFERENCE
            // to that other variable. AGAIN YOU ARE COPYING THE REFERENCE, not 
            // the actual value
            // so anytine a reference type is ASSIGNED to another variable, they 
            // are BOTH containing the SAME!!!!!! reference to that type.

            //   numbers ->   {1, 2, 3, 4, 5}
            //   numbersTwo -------⬆️
            //
            // if you change One variable pointing to your referenced value
            // naturally any other variable containing that SAME reference
            // will also change, why! because they REFERENCING the SAME THING!

            numbersTwo[0] = 6;

            int numberAtIndexZero = numbers[0];

            // Classes == Reference type
            // Structs == Value types
            //
            // how do you know if the type is a value type vs a reference type?
            // ctrl + click on the type name
            // all arrays are reference types.

            // NULLS
            // if a reference is just pointing to your value in memory
            // numbers --> { 1, 2, 3,}
            // we can conclude that IF an actual value thats being POINTED to
            // DOES NOT EXIST, it is null
            // the idea of a reference type having NOTHING to point to or "REFERENCE"
            // introduces the null type, null is just LITERALLY the absence of 
            // a reference type to reference.
            // this means the default value to ALL reference types is NULL.

            // this is simply saying this reference is POINTING to NOTHING!
            int[] nullNumbers = null;
        }

        // how do you protect yourself against nulls! like... what...?
        // how do you even know null can a problem!
        static void ExampleFour()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            bool isEvenLength = IsLenthOfArrayEven(numbers);
            int[] numbers2 = numbers;
            bool isEvenLengthTwo = IsLenthOfArrayEven(numbers2);
            bool isAlsoEvenLength = IsLenthOfArrayEven(null);
            string name = "James";
            string otherName = name; // COPIED LIKE A VALUE TYPE, but IT AINT

            bool isNullOrEmpty = string.IsNullOrEmpty(otherName);
        }

        // most common way of running into a NULL error
        static bool IsLenthOfArrayEven(int[] numbers)
        {
            if (numbers != null)
            {
                return numbers.Length % 2 == 0;
            }
            return false;
        }

        static void ExampleFive()
        {
            // creating a static lenght array with a dynamic integer
            Console.Write("Please provide a positive whole number: ");
            int userLengthInput = int.Parse(Console.ReadLine());

            // if you provide a negative value... the program will crash
            int[] numbers = new int[userLengthInput]; // the elements are still zero


            for (int idx = 0; idx < numbers.Length; idx++)
            {
                numbers[idx] = idx * idx;
            }
        }

        static void ExampleSix()
        {
            int[] numbers = { 1, 2, 6, 15, 96, 13, 420 };
            int sum = 0;
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                sum += numbers[idx];
            }

            // use the Array class (like using Console) and use 
            // the Sort method to sort by Ascending by default
            Array.Sort(numbers);

            // literally reverse the elements in your array
            Array.Reverse(numbers);
            sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
        }

        static void ExampleSeven()
        {
            int length = 10;
            int[] numbers = new int[length];

            // int x = numbers[11];  index out of range exception
        }

        // 2d arrays
        static void ExampleEight()
        {
            // jagged array
            int[][] numbersInNumbers =
            {
                new int []{ 1, 2, 3, 4, 5 },
                new int []{ 1, 2, 3, 4 },
                new int []{ 1, 2 },
                new int []{ 1, 2, 4, 5, 6 },
            };

            foreach (int[] numbers in numbersInNumbers)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine($"{number}");
                }
            }

            // 2d array
            int[,] rectangularArray = new int[4, 5];
            //  {
            //    {1, 0, 0, 0, 0}
            //    {0, 1, 0, 0, 0}
            //    {0, 0, 1, 0, 0}
            //    {0, 0, 0, 1, 0}
            //    {0, 0, 0, 0, 1}
            //  } yes this is a matrix IF you treat like a matrix.
        }

        static void ExampleNine()
        {
            string[] names =  string[]{ "Nathaniel", "Benjamin", "Aimee", "Angela"};
        }
    }
}