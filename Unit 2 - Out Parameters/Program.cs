namespace Unit_2___Out_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // RunOutParametersExample();
            RunOutputParameterExampleTwo();
        }


        static void RunOutParametersExample()
        {
            // out parameters is a way to return additional information
            // OUT of your Method / Function.  
            // HOWEVER, this should ONLY really be used if you are using
            // the Try"DoSomething" pattern when creating a method.
            // a core example of this would be int.TryParse... any of the 
            // "TryParse" methods.  the pattern is you Try to do something,
            // the function returns a boolean, and if your result is true,
            // then you output your out parameter with the data you care about...

            string userInput = Console.ReadLine();
            if (TryGetPositiveNumber(userInput, out int value))
            {
                Console.WriteLine($"This is a valid number, good job! {value}");
            }
            else
            {
                Console.WriteLine(":( no good chief/chiefette");
            }
        }

        static void RunOutputParameterExampleTwo()
        {
            int numberInRange = GetValidNumberInRange();
        }

        static bool TryGetPositiveNumber(string input, out int value)
        {
            if (int.TryParse(input, out int parsedValue) && parsedValue >= 0)
            {
                value = parsedValue;
                return true;
            }

            value = 0;
            return false;
        }

        //                                                          
        //
        //                                             an additional "returned" value                 
        //                                                                       ⬇️⬇️⬇️
        static bool TryGetNumberInRange(string input, int min, int max, out int value)
        {
            if (int.TryParse(input, out int parsedValue) 
                && parsedValue >= min 
                && parsedValue <= max)
            {
                value = parsedValue;
                return true;
            }

            value = 0;
            return false;
        }

        static int GetValidNumberInRange()
        {
            while (true)
            {
                Console.Write("Hey, can you please enter a number between 1-100 please?: ");
                string userInput = Console.ReadLine();
                if (TryGetNumberInRange(userInput, 1, 100, out int validNumber))
                {
                    return validNumber;
                }

                Console.WriteLine("Invalid input, try again please.");
            }
        }
    }
}