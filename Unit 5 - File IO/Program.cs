namespace Unit_5___File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RunExampleFour();
        }

        static void RunExampleOne()
        {
            var studentFileManager = new StudentFileManager();

            studentFileManager.WriteNameToFile("Benjamin");
        }


        // adding multiple names to a file, LINE BY LINE
        static void RunExampleTwo()
        {
            var studentFileManager = new StudentFileManager();

            studentFileManager.WriteNameToFile(new string[] { "James", "Benjamin"});
        }


        // reading all names from a file
        static void RunExampleThree()
        {
            var studentFileManager = new StudentFileManager();

            var names = studentFileManager.GetAllNames();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        // reading all names from a file
        static void RunExampleFour()
        {
            var studentFileManager = new StudentFileManager();
            var names = studentFileManager.GetAllNamesFromFile();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}