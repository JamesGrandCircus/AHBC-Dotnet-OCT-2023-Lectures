namespace Unit_4___OOP_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RunExampleOne();
            RunExampleTwo();
        }

        // This METHOD is a MEMBER to the Program class.
        static void RunExampleOne()
        {

            // this is how you CREATE an INSTANCE of an OBJECT based 
            // on a CLASS into MEMORY (in memory means theres an Instance of it)
            // the "new" keword is used to create a new Instance of an
            // an object into memory.
            Pen penOne = new Pen();
            //           ⬆️  new creates a "new" instance of an object

            // "DOT" notation is USED to ACCESS the MEMBER of an object
            //    ⬇️  
            penOne.Color = "Blue";

            //    DOT notation to access the PUBLIC METHOD, WriteLine which is a MEMBER of "Console"
            //     ⬇️
            Console.WriteLine(penOne.Color);
            penOne.Color = "Green";
            // the fact that we can ACCESS the "Color" PROPERTY outiside of the Pen CLASS
            // imples that the "Color" PROPERTY, is PUBLIC.

            // "int" is a "TYPE" like "PEN" is a type
            int x = 3;
            
            // List<string> is a TYPE, also a class, we KNOW it's a class becasue we are using the 
            // new keyword to create an INSTANCE of a List<string> into memory
            List<string> names = new List<string>();

            Console.WriteLine("Hello, World!");
        }

        // an example of using a Student object to describe the 
        // properties of a Student!
        //
        // Requirements: create an "app"(thid method) that list the names and Grades of Students in a course
        // the Student should have the following properties
        //  - Name
        //  - Grade
        //  - course
        static void RunExampleTwo()
        {
            Console.WriteLine("Hello, here are the Students in a course");

            // you can MAKE a list of STUDENTS, because a STUDENT is just a TYPE
            // like a STRING is a TYPE, or an int... or a double... or a bool, or an array
            // etc. etc.
            List<Student> students = new List<Student>();

            // creating an object of TYPE "Student" using the 
            // Object Instance syntax
            // you ASSIGN the properties inline this way.
            Student studentOne = new Student()
            {
                // within the curly brackets, we can assign
                // the public properties
                Name = "Nathaniel",
                Grade = 420.00,
                Course = "Dotnet"
            };

            Student studentTwo = new Student() // Yes it's "bypassing" the constructor... because there is "None"
            { // ⬅️ the syntax for creating a "New Object" into memory while assigning values
                Name = "Angela",
                Grade = 9000.00,
                Course = "Dotnet"
            };

            //   ⬆️
            // object Instance value assigning 
            // the SAME AS
            //   ⬇️   manually assigning each Property on it's own line

            studentTwo.Name = "Angela";
            studentTwo.Grade = 9000.00;
            studentTwo.Course = "Dotnet";

            Console.WriteLine(studentTwo.GetStudenInfo());

            string newStudent = studentTwo.GetStudenInfo();

            // adding my Students to my LIST of Students, or a List of Type Students
            // List<Student>
            students.Add(studentOne);
            students.Add(studentTwo);

            // looping over each individual 
            foreach (Student student in students)
            {
                // accessing that student's PUBLIC PROPERTY
                // NAME using the Dot notation
                // we are able to WriteLine the Students Name.
                string studentInfo = student.GetStudenInfo();
                string combinedLines = $"{studentInfo}\n{new string('-', 20)}";
                Console.WriteLine(combinedLines);
                Console.WriteLine();
            }
        }
    }
}