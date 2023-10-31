namespace Unit_4___OOP_intro // <- name space, more on this later
{
    // a Class is a "description" or "contract" or "Blueprint"
    // that DESCRIBES how your instance of an OBJECT will Look / Behave
    internal class Pen // Classes are "types" by creating a class, you have now introduced
        // a new TYPE to your program.
    {

        // Classes are scoped (curly brackets), Classes contain "members", Members are the "things"
        // that LIVES withen the SCOPE of a class.

        // the MAIN MEMBERS
        // - Methods
        // - Properties

        // - Fields - more on this later (fields are private variables)
        // - Constructors - more on this later


        // Nouns, PROPERTIES

        // PROPERTIES expose Public Data of a class.
        // think of them as "public" variables
        public string Color { get; set; } = "Blue"; // <- default VALUE of this property

        // the IDEA of READ / WRITE (getting a value, or setting a value) (this can be controlled)
        // is NOT THE SAME as a member being Public or Private
        public string Brand { get; set; }
        public string InkType { get; set; }

        // Access Modifiers, describes the Members protection "level"
        // in other words, if a Member is Private, you will NOT be 
        // able to acces it outside of this class.  if a member is 
        // Public, that member CAN be accessed Outside of the class

        // Public -> member CAN be accessed OUTSIDE of the SCOPE of this class
        // Private -> member CANNOT be accessed OUTSIDE of the SCOPE of this class
        //
        // protected -> member can ONLY be accessed withen this classes inhertance chain (more on this later)
        // internal -> member can ONLY be accessed withen the same BINARIES, ie. the same Project.

        // Actions (Methods)
        public void Write(string message)
        {
            Color = "Green";
            ConsoleColor color = ConsoleColor.White;

            // this method Write, is ACCESSEING the Color Property!!!
            //                           ⬇️⬇️⬇️
            Enum.TryParse<ConsoleColor>(Color, out color);
            // because Color lives OUTSIDE of the scope of this method (rules of scope)
            // this non static method has access to color

            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }

        // Methods are just functions that BELONG to a class, ie. it's a 
        // MEMBER of a class.
        // IF a METHOD is NOT STATIC!!!!!!@!!!!@!!@#$!@#!@#!@#!@#!@#!@!!!!
        // if a METHODI S NOT STATIC!!!!!!!!!!!
        // that METHOD will have ACCESS to OTHER MEMBERS in that CLASS!!
    }
}
