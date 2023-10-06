using Microsoft.VisualBasic.FileIO;

namespace Unit_2___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops
            //
            // While Loops
            int i = 0;
            while (i < 4)
            {
                int j = i * i; // this 'j' variable will be created
                                // with every loop
                Console.WriteLine($"i: {i}, i^2: {j}");
                i++;
            } // all local defined variables in this while loop
              // gets destroyed, or GARBAGE COLLECTED

            // with scoping, an inner scope has access to 
            // previously defined variables in it's OUTER
            // scope, the inverse is not true.

            // in other words, if the program as a previosly defined
            // inner scope, like an if statement or an loop!
            // your program CANNOT Access these variables

            // Console.WriteLine(j); j no longer exist!


            // while loop with other conditions!

            int k = 5;
            while (k > 0)
            {
                int kSquared = k * k;
                Console.WriteLine($"j: {k}");
                k--;
            }

            //ALWAYS PLAN TO EXIT YOUR WHILE LOOPS, which is to say
            // IF YOU DON'T HAVE AN EXIT STRATEGY, YOU WILL HAVE
            // AN INFINITE LOOP!!!!!
            // code below is an infinite loop
            //while (true)
            //{
            //    Console.WriteLine($"AHH GET OUT OF HERE!!!{k}");
            //    k++;
            //}

            // Looping (works for ALL loop types) exit and continue
            // strategies

            int l = 0;
            while (l < 10)
            {
                l++;
                if (l % 2 == 0) // is l even
                {
                    continue; // continue takes your program
                              // BACK to the begenning of 
                              // the program
                }

                Console.WriteLine($"l: {l}");

                if (l > 6)
                {
                    // as much as possible, rely on your boolean
                    // expression in your while loop for readability
                    // there are exception, more on that later
                    break; // break exits your looping scope
                           // think of break as an additional 
                           // escape hatch for your loop
                }

                // Do-while loop is a while loop where your loop
                // will run AT LEAST once
                // we check if we continue the loop at the 
                // END and not the begenning.
            }

            int m = 0;
            do
            {
                Console.WriteLine($"m: {m}");
                m+=2;
            } while (m < 10);

            // For loop (oh boy)

            // 1)Initializer runs, creating our Indexing variable
            // 2) check boolean expression, should the loop continue?
            //   3). if TRUE, run scope of loop
            //   4). once we exit scope of loop, run index incrementor/decrementor
            //   5). repeat step 2)
            // 6). if false, exit loop
            for
            (
                int idx = 0; 
                idx < 10; 
                idx += 2 // the main reason we for loop is to
                         // get access to this idx number
                         // and mostly if your idx number will
                         // do anything other than conventional
                         // increment by 1 or decrement by 1
            )
            {
                Console.WriteLine($"idx: {idx}");
            }

            // one of the main reasons we even use a loop in our code,
            // is to LOOP OVER A COLLECTION OF ELEMENTS
            // Becasue this is such a common use case, most programming
            // languages gives you a loop specifically for looping
            // over EACH element in your collection

            // foreach loop, you will USE THIS THE MOST
            // 
            // this loop will loop over your ENUMERABLE of ELEMENTS 
            // for you, each ELEMENT at a time
            string name = "James"; // { 'J', 'a', 'm', 'e', 's' }
            foreach (char letter in name)
            {
                Console.WriteLine($"the letter is {letter}");
            } // the FOR-EACH LOOP WILL EXIT FOR YOU!!! 
              //  YOU DO NOT NEED A BOOLEAN EXPRESSION TO EXIT YOUR 
              // FOR EACH LOOP... you CAN still USE continue AND break;
              // IF YOU NEED TO.


            // doing a "foreach loop" with a for loop
            // collections use ZERO-BASED indexing
            // index:        0    1    2    3    4
            // collection: {'J', 'a', 'm', 'e', 's'} Length == 5
            //
            for (int j = 0; j < name.Length; j++)
            {
                char letter = name[j];
                Console.WriteLine($"the letter is {letter}");
            }
            // IF you are looping over your collection WITHOUT using
            // your INDEXER in any other way than just grabbing the 
            // NEXT ELEMENT.....
            // use a foreach loop... always.

            // for loop in reverse
            // this lets us start at the last element,
            // and work our way backwords
            for (int j = name.Length - 1; j >= 0; j--)
            {
                char letter = name[j];
                Console.WriteLine($"the letter is {letter}");
            }

            // reversing foreach loop
            foreach (char letter in name.Reverse())
            {
                Console.WriteLine($"the letter is {letter}");
            }


            // a valid use case for for loops, in the below example, we 
            // are USING our indexer variable 'j' to help dictate the 
            // control or 'logic' of our for loop.
            for (int j = 0; j < name.Length; j++)
            {
                char letter = name[j];
                if (j % 2 == 0)
                {
                    Console.WriteLine($"This letter is even!: {letter}");
                }
                else
                {
                    Console.WriteLine($"This letter is odd!: {letter}");
                }
            } //.... you can still use linq / foreach to do this.. more on that 
              // later

            // the MAIN use case for 'for' loops in modern programming,
            // is if you need to change your indexer at different
            // intervals... more on that with algorithms

            // Validation using while loop for user input
            int age;
            while(true)
            {
                Console.Write("Please insert your age in years (whole number): ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out age))
                {
                    break;
                }

                Console.WriteLine("Invalid age input... try again");
            }

            Console.WriteLine($"You are {age} years old");
        }
    }
}