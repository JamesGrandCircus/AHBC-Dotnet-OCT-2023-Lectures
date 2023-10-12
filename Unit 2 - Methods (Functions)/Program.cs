using System.Runtime.InteropServices;

namespace Unit_2___Methods__Functions_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // variables should be named as if they are nouns... 
            // or a question if it's a boolean

            int z = 13;

            // INputs == arguments, same idea... arguments are the technical term
            int result = AddTwoNumbers(2, 3); // Calling or Invoking a function!
            int result2 = AddTwoNumbers(result, 2);
            int result3 = AddTwoNumbers(result, result2);

            // you can re-use variables as long as you are NOT 
            // trying re -INITIALIZE by giving a type.  re-assigning
            // a variable will 100% replace the data thats in it.
            result = SubtractTwoNumbers(result, result3);

            // as far as the RunTime goes, the FUnctino itself does NOT 
            // exist, until it's called.. this implies that ALL variables
            // defiend in a function ONLY exist while that function
            // as actively being called on.

            // why functions?
            // 1) repeatable, which means YOU DON'T have to REPEAT YOUR 
            //    LOGIC OVER AND OVER, solve that ONE problem once
            //   and just call that function over and over again :)
            //
            // 2) Testable! (more on this later) essentially, you 
            //  can test each function individually, which allows you
            //  to make your problems smaller
            //
            //
            // 3) functions keep your code ORGANIZED!!! if you have  function
            //    that is 20 lines of code? you could probably refacotr that 
            //    function to be like.. .3 functions maybe? keep your
            //    code nice and organized
            //
            //  4) help you think smaller chunks of code at a time, so you
            //     the Human developer that you are, stays sane.

            //  5) DRY - Don't repeat yourself!

            // the return keyword...
            int result4 = MultiplyTwoNumbers(2, 3);

            // function with NO output
            WriteToConsole("hello world");

            // function With no Input, With Output
            string helloWorld = GetConstantMessage();

            // function with no input, no output
            GiveNothingTakeNothing();

            int validResult = GetValidNumber("Please insert a valid whole number");
            int otherValidResult = GetValidNumber("how old are you!");
        }


        // A function (or method.... curse oop!) is a block
        // of SELF contained code that optionally has Input / Output
        //
        // arrow V
        // f(x) => y // INPUT -> OUTPUT

        // functions / methods should be named as if it has action,
        // ie. a verb
        // input and output types have to match!
        static int AddTwoNumbers(int x, int y) // parameters == INPUT
        {
            int sum = x + y;
            return sum; // returning our OUTPUT!... reutrn keyword returns our OUTPUT.
        }

        // you can think about parameters (input) syntactically as 
        // just variables that exist as inputs for a function... why?
        // because thats all they literally are. variables that are SCOPED
        // just to this function
        static int SubtractTwoNumbers(int x, int y)
        {
            // method body can contain any kind of code... be it more 
            // if statements, or more loops even FUNCTIONS... more on that later
            int difference = x - y;
            return difference;
        }

        static int MultiplyTwoNumbers(int x, int y)
        {

            int product = x * y;

            // the return does TWO things, it acts as a "break" keyword
            // like in loops, and it TAKES the DATA WITH IT (it's how
            // you provide the caller of the function, it's ouput)
            return product;
            // the return keyword KICKS you out of the function


            int someRandomVar = 2;
        }

        // the VOID return type is a function returning NOTHING.
        // NOT OUTPUT
        static void WriteToConsole(string message)
        {
            Console.WriteLine(message);

            // return keywords are STILL valid in a function with NO
            // output, because it's a way to exit a fucntion early!
            return;
        }

        // function with NO input!
        static string GetConstantMessage()
        {
            return "hello world!";
        }

        // fucntion with no input or output
        static void GiveNothingTakeNothing()
        {
            Console.WriteLine("yeah I got nothing for you dude...");
        }

        // validation function to get a valid integer from user
        static int GetValidNumber(string initialMessage)
        {
            
            while(true)
            {
                Console.WriteLine(initialMessage);
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result))
                {
                    return result; // we break out of the loop, AND the FUNCTION!
                }

                Console.WriteLine("Invalid input, try again");
            }
        } 
    }
}