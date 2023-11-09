namespace Unit_4___OOPb_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void RunExampleOne()
        {
            // polymorophism, in this case, an Apple IS AN apple, but because
            // it inherits from Fruit, Apple can be LOOKED AT as a Fruit instead
            // because an Apple IS A FRUIT
            Fruit fruit = new Apple();
        }


        // the VAR keyword
        static void RunExampleTwo()
        {
            // the var keyword, allows the compiler to INFER the type
            // based on it's assignment.


            //  var is assuming it's identity based on what ever TYPE is being
            // assigned to it, so in this case, the variable "apple" is of type... Apple
            // 
            var apple = new Apple();
            var fruit = new Fruit();

            // var itself, is not a type, var just INFERS the type.
            var x = 2;

            var name = "Angela";

            // this cannot be done, the var keyword ONLY works
            // when the variable itself, is being assigned
            // var notPossible;

            // this can be done becuas we are EXPLICITLY declaring the variables
            // type, it is of type bool.
            bool isPossible;

            isPossible = true;


            // using the var keyword with "Casting" and "Polymorphism"
            var secondFruit = new Apple() as Fruit;
        }


        // this functions return type is VOID, which means it RETURNS NOTHING
        static void RunExampleThree()
        {

            var fruits = new List<Fruit>();

            // as a dev, you mightn not care about the type at that moment, you just 
            // want to call a function, get your data, 
            var names = GetNames();

            // you do NOT need to store a single instance of an object into a variable
            // if you do not need to.  the only reason you need a variable, is if you are going
            // to USE that varialbe in some meaningful way.  in this case, I'm just adding
            // new fruits to our list.  our LIST cares about the objects, but as a dev, you may
            // not care about a SINGULAR (a variable) fruit outside of the list.

            fruits.Add(new Apple());
            fruits.Add(new Orange());
            fruits.Add(new Grape());

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Seeds);
            }
        }

        static int GetNumber()
        {
            return 2;
        }

        static List<string> GetNames()
        {
            return new List<string>()
            {
                "Angela"
            };
        }

        static string[] GetNamesArray()
        {
            return new[] { "Nathaniel" };
        }
    }
}