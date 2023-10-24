namespace Unit_3___LINQ // Language Integrated Queries
{                       // the name is supposed relate to SQL
                        // SQL == Strutered Query Language
                        // the Operaters in LINQ are "supposed" be simillar 
                        // to the Operators in SQL
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // RunExampleTwo();
            // RunExampleThree();
            RunExmapleFour();
        }

        static void RunExampleOne()
        {
            // IEnumerables are 'Types" that allow your PROGRAM
            // to loop over using foreach or linq
            //
            // the idea of "Enumerating" is kind of like saying
            // "Hey, I can be looped over"

            // all collections in "C#" can be treated as an
            // IEnumerable
            // this variable is STILL a list, we are just looking at it as 
            // an IEnumerable to SHOW that IEmuerables is whats LETTING 
            // the LIST be LOOPED OVER.
            IEnumerable<string> names = new List<string>()
            {
                "James",
                "Jay",
                "Nathaniel"
            };

            // IEnumerables allow foreach loops to "loop" over 
            // your collection (list in this case)
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // LINQ is a library full of "Extension methods, or just functions" that WORKS
        // on IEnumerables
        static void RunExampleTwo()
        {
            IEnumerable<string> names = new List<string>()
            {
                "James", // JAMES
                "Jay",
                "Nathaniel"
            };

            // loop over EVERY name in this list, return a NEW list
            // with each name to uppercase
            // first WITHOUT linq
            // 1. create a new list
            // 2. loop over the names list
            // 3. add uppercase name to new list
            List<string> namesUppercased = new List<string>(); // totally empty list
            foreach (string name in names)
            {
                // strings are IMMUTABLE, therefore, when calling ToUpper() we are 
                // GETTING a BRAND NEW STRING!
                namesUppercased.Add( name.ToUpper()); // 
            }

            // we are Looping over List A, and Transfering the Data in List A
            // to List B TRANFORMED
            // A -> B, B is a TRansformed or different value from A
            // this commonly called MAPPING, where we get all Data from 
            // A and transform it to B, where B is your NEW value
            // A -> B


            //                                              A   ->        B
            List<string> namesUpperCasedTwo = names.Select(MapToUpperCase).ToList();
            // Select takes in a "Lambda Expression" or "Function" as an argument
            //        
            //     parameter    return statement
            //       ⬇️               ⬇️
            //      name =>  name.ToUpper()
            //
            // Select UpperCase(*) from Table
        }

        // linq using WHERE
        static void RunExampleThree()
        {
            IEnumerable<string> namesA = new List<string>()
            {
                "James", // JAMES
                "Angela",
                "Jay",
                "Nathaniel",
                "Lauren"
            };


            // We are ONLY going to ADD A - if true -> A
            // Unlike SELECT, the DDATA does not Transform here
            // this is commonly called a FILTERING function
            List<string> namesAFiltered = new List<string>();
            foreach (var name in namesA)
            {
                char firstLetter = name[0];
                if (firstLetter == 'J') // our filter states we ONLY want NAMES that start
                {                       // START with the LETTER 'j'
                    namesAFiltered.Add(name);
                }
            }
            //                          parameter      return statement
            //                             ⬇️              ⬇️
            namesAFiltered = namesA.Where(name => name[0] == 'J').ToList();
            // Where is a Filtering Linq function that takes in a lambda expression
            //  that returns a Boolean or Boolean Expression.  IF the boolean
            //  expression evaluates to TRUE, THAN the ELEMENT will be ADDEd
            // to your NEW collection
        }

        static void RunExmapleFour()
        {
            IEnumerable<string> namesA = new List<string>()
            {
                "James", // JAMES
                "Angela",
                "Jay",
                "Nathaniel",
                "Lauren"
            };

            List<string> namesThatStartWithJUppered = namesA
                .Where(name => name[0] == 'J')
                .Select(name => name.ToUpper())
                .ToList();
        }

        // same exact FUnction as the lambda expression name => name.ToUpper()
        static string MapToUpperCase(string name)
        {
            return name.ToUpper();
        }

        static bool DoesNameStartWithJ(string name)
        {
            return name[0] == 'J';
        }
    }
}