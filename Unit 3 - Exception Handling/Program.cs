using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

namespace Unit_3___Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a good mental model for you try catch block, your TRy 
            // scope is simillar your if (true) statmenet, than your catch,
            // is your else.  so if your app throws an exception, you will catch it 
            // in "catch" block, ie. your else.
            try
            {
                // RunExampleOne();
                // RunExampleTwo();
                // RunExampleThree();
                RunExampleFour();
            }
            catch (IndexOutOfRangeException ex) // IF your app happens to THROW an
            // index out of range exception, THIS catch block will run.
            {
                Console.WriteLine($"Your index was out of range, make sure you are accessing an element that is valid and in range: {ex.Message}");
            }
            catch (Exception ex) // think of this as the "catch all" excption
            {
                Console.WriteLine($"Hey, your app broke dude {ex.Message}");
            }
            finally
            {
                // something that runs even if your application does NOT crash
                // finall will run after your try, or after your catch block.

                // FINALLY ALWAYS RUNS
                Console.WriteLine("Thanks for running the app!");
            }


        }

        // introduct an Index out of Range Exception
        static void RunExampleOne()
        {
            //                0  1  2
            int[] numbers = { 1, 2, 3 };

            int x = numbers[8];
        }


        // no matter what, the finally block will run
        static void RunExampleTwo()
        {
            Console.Write("Hey, give me some sort of message I guess dude: ");
            string message = Console.ReadLine();

            Console.WriteLine(message);
        }

        // DON'T ACTUALLY DO THIS, HANDLE VALIDATION WITH IF STATMETNS AND LOOPS, DON'T THROW
        static void RunExampleThree()
        {
            Console.Write("Enter a number between 1 - 10");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int value) && value > 0 && value < 11)
            {
                Console.WriteLine($"You did it, good job, heres your value: {value}");
            } 
            else
            {
                // Internally, whenever an Exception is being happening in your app,
                // dotnet,is THROWING an exception FOR YOU!
                // throwing an exception is the act of aknowleding that your app SHOULD be broken,
                throw new ArgumentException("User entered an invalid number, or the number was NOT between 1-10");
            }
        }


        // demonstrating the CALL STACK
        static void RunExampleFour()
        {
            FunctionThree();
        }


        static void FunctionThree()
        {
            FucntionFour();
        }

        static void FucntionFour()
        {
            FunctionFive();
        }

        static void FunctionFive()
        {
            FunctionSix();
        }

        static void FunctionSix()
        {
            throw new Exception("You made it to the end of the abyss... great... are you happy with yourself?");
        }
    }
}