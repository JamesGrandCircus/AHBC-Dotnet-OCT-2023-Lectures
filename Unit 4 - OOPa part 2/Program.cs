namespace Unit_4___OOPa_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void RunExampleOne()
        {
            double length = GetValidMeasurement("Please enter the Length of your room... ");
            double width = GetValidMeasurement("Please enter the Width of your room... ");

            Console.ReadLine();

            List<string> names = new List<string>();
            Room room = new Room(length, width);


            Console.WriteLine($"The area of your room is {room.Area}\nThe perimeter is {room.Per}");
        }

        void RunExampleTwo()
        {
            Room roomOne = new Room(13, 32);
            Room roomTwo = new Room(5, 6); 
            Room roomThree = new Room(69, 420);

            // the only way to call the Constructor Function is the provide the 
            // new keyword.  the new keyword imples that you are CONSTRUCTING a
            // OBJECT into memory.  by claling the CONSTRUCTOR method.
            Room roomFour = new Room(12);

            double height = roomFour.Height;
        }

        static double GetValidMeasurement(string inputMessage)
        {
            while (true)
            {
                Console.Write(inputMessage);
                string userInput = Console.ReadLine();
                if (double.TryParse(userInput, out double result))
                {
                    return result;
                }

                Console.WriteLine("Invalid input, press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}