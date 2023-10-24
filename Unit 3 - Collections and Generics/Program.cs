namespace Unit_3___Collections_and_Generics
{
    internal class Program
    {
       

        // Generics
        static void RunExampleOne()
        {
            // Generics is a language feature that allows you 
            // to tell the compiler of what 'T' for Type you
            // will use for that Class or Method

            // the "Generic" is simply a Placeholder for the TYPE that 
            // WILL be used when you call your Class or Method


            // IF your generic is being USED as a return type or a parameter,
            // whenever you CALL the method, the TYPE will be automaically
            // inferred by the compiler
            WriteToConsole(2, 3);
            WriteToConsole("Hello world!", "sup");
            WriteToConsole(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3});
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // RunExampleOne();
            // RunExampleTwo();
            // RunExampleThree();
            // RunExampleFour();
            //RunExampleFive();


            // example App
            RunExampleSix();
        }


        // Generic Placeholder 'T'
        // you define your Generic Placeholder in angle brackets
        // AFTER the name of your method when defining your method...
        // this ALLOWS you to use your generic 'T' anywhere in the method
        // what a TYPE would be declared
        static void WriteToConsole<T>(T input, T otherInput)
        {
            // to keep things simple, Generics are TYPICALLY used as a placeholder
            // type in which you are NOT invoking BEHAVRIOR with that type,
            // instead you are PASSING that type around
            Console.WriteLine(input);
        }


        static void RunExampleTwo()
        {
            // A list is a collction of Dynamic size! of a single Type
            // unlike arrays, Lists CAN SHRINK or GROW
            // THE MOST COMMON DEVELOPER DEFINED COLLECTION YOU WILL USE
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();

            // LIsts allows you to Add and Remove Content pretty easily

            // the order in which you add elements into a List
            // is also in indexed order incremented
            // ie. if the list is empty, the FIRST element you insert
            // into the list, will live at index 0, etc. etc.
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(4);

            // like arrays (and most collections frankly) you can access 
            // the lists elements with bracket notation providing an index.

            int firstNumber = numbers[0]; // 1

            // int sixthNumber = numbers[5]; // CANNOT BE DONE, Index Out Of Range Exception

            // because lists are of dynamic length, removing from a list COULD affect
            // the index "address"
            // Lists gives you a few helper Methods to REMOVE elements from itself.


            // if you remove a value type, it will find the first instance of that 
            // value. ie. if you have multiple number 4s, it will remove the first 4
            // in ascending order
            // if you can help it, try to use Remove.
            numbers.Remove(4);

            if (numbers.Remove(3))
            {
                Console.WriteLine("You have succesfully removed the number");
            }
            else
            {
                Console.WriteLine("element did not exist, try again");
            }

            // you can remove at a certain index, RemoveAT IS 100%
            // bound by the range of indexes as well.
            // which means, if you pass in an index that is out of range,
            // an exception will be thrown, (your app will crash)
            // use this method with caution...
            numbers.RemoveAt(2);

            // Remove Range allows you to remove multiple elements,
            // the first arugment is where you the program will START
            // removing elements, the second optional argument is how many
            // elements after yoru starting index do you want to remove.
            //        x  x  x 
            //   { 1, 2, 3, 4, 5  }
            numbers.RemoveRange(1, 3);

            // you can pass in a collection of the same type
            // and AddRange will add them to itself in ascending order
            // basically the de-factor way to combine collections
            numbers.AddRange(new []{ 1, 2, 3, 4, 5});
        }

        static void RunExampleThree()
        {
            // you can use an object literal to add your initial data,
            // just like arrays
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
        }

        static void RunExampleFour()
        {
            // using our list as a means to AGGREGATE data,
            // as the APP goes on...
            List<string> roomNames = new List<string>();
            while (true)
            {
                Console.Write("Enter the name of your room!");
                string userInput = Console.ReadLine();

                roomNames.Add(userInput);

                Console.Write("Do you want to quit? [Y/N]");
                string userYesOrNo = Console.ReadLine();
                if (userYesOrNo.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }

            foreach (string roomName in roomNames)
            {
                Console.WriteLine(roomName);
            }
        }

        // Dictionary!!!
        // A collection of KEY value Pairs
        // the BEST way to think about a Dictionary is,
        // YOU define the INDEX, the KEY (index in this example)
        // can be of WHATEVER TYPE
        //
        // you Typically DO NOT use Dictionaries for LOOPING
        // you use Dictionaries for key value looks, in other words,
        // you will HAPPEN to have the Address, or Index..the KEY to 
        // get the element
        // Dictionary Lookups are like... 10x faster than looping over 
        // collections... and it scales as collections get larger (list/ array)
        static void RunExampleFive()
        {
            // if you can get access to a KEY and you can ASSOCIATE yourself
            // with a VALUE, use a dictionary.
            // KEYS are UNIQUE, you CANNOT have a repeat KEY
            // strings are the most common type used for Keys in a dictionary
            //... maybe ints second?
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();

            // Dictionaries ARE NOT INDEXED, they are KEYED
            studentGrades.Add("Frank", 95);
            studentGrades.Add("Benjamin", 90);
            studentGrades.Add("David", 96);
            studentGrades.Add("Lauren", 97);
            studentGrades.Add("Peggy", 99);

            // you RARELY want to pull DATA out of your dictionary this way
            int franksGrade = studentGrades["Frank"];

            // how to safely get values out of a dictionary
            // you should STRIVE to ONLY TryGetValues
            // this is a safe way to get a value, it WILL not break
            // your app if the key does not exist, it will just
            // return false
            if (studentGrades.TryGetValue("Frank", out franksGrade))
            {
                Console.WriteLine($"Hey Frank, your grade is {franksGrade}");
            }
            else
            {
                Console.WriteLine("Invalid student, pleae provide a differet student name");
            }

            // Try add will allow you to safely add a key value pair, which 
            // is to say, IF the key value already exist, it will NOT add it
            // return true if it was added, false if it wasnt
            // you ONLY want to do this if you Absolutly do not want to 
            // override the existing value for the key.
            if (studentGrades.TryAdd("Frank", 85))
            {
                Console.WriteLine("Yay, Frank's grade was added!");
            }
            else
            {
                Console.WriteLine("Sorry, this student already exist!");
            }

            // if you don't care about overrieing... just access the key!
            studentGrades["Frank"] = 95; // this will override the last value...
            ICollection<string> keys = studentGrades.Keys;

            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }
        }

        static void RunExampleSix()
        {
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                { "FRANK", 100 }
            };
            while (true)
            {
                Console.Write("Do you want to [VIEW] or [ADD] a student?: ");
                string userInput = Console.ReadLine();

                if (userInput.Equals("VIEW", StringComparison.OrdinalIgnoreCase))
                {
                    ViewStudentGrade(students);
                }
                else if (userInput.Equals("ADD", StringComparison.OrdinalIgnoreCase))
                {
                    AddStudentGrade(students);
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                }

                EnterToClearConsole();
            }
        }

        // View a current student Grade
        static void ViewStudentGrade(Dictionary<string, int> students)
        {
            DisplayStudentNames(students.Keys);
            Console.WriteLine();
            Console.Write("Enter a students name to see their grades: ");
            string userInput = Console.ReadLine().Trim().ToUpper();

            if (students.TryGetValue(userInput, out int grade))
            {
                Console.WriteLine($"{userInput} grade is {grade}");
            }
            else
            {
                Console.WriteLine("Sorry, there are no records of this student 😔");
            }
        }

        // Add a student and view grade
        static void AddStudentGrade(Dictionary<string, int> students)
        {
            Console.Write("Enter the students name please: ");
            string studentName = Console.ReadLine().Trim().ToUpper();

            int grade;
            while (true)
            {
                Console.Write("Enter the Students grade please: ");
                string userGradeInput = Console.ReadLine();
                if (int.TryParse(userGradeInput, out grade) && grade >= 0)
                {
                    break;
                }
            }

            students[studentName] = grade;

            Console.WriteLine("Current students...");
            DisplayStudentNames(students.Keys);
        }

        static void DisplayStudentNames(ICollection<string> studentNames)
        {
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }
        }

        static void EnterToClearConsole()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}