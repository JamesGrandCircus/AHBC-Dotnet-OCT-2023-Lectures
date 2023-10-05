namespace Unit_2___Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conditionals.... logic... boolean expressions
            // do this or that? yep
            // Control Flow
            // Control flow helps dictate what "direction"
            // our application is going to go in, using
            // boolean expressions

            // before we get into boolean expressions... whats an
            // expression?
            // an expression is Code that will be Evaluated at 
            // RUN TIME

            // algebriac expressions
            int x = 2 * (3 + 4); // 14

            // 1) expression identified, 2+2
            // 2) expression is Resolved! giving us 4.
            // 3) results of expression (4) is assigned to y
            // 4) end statement.
            int y = 2 + 2;

            // technically the function call ReadLine() is an expression
            // becasue, this function NEEDS to be evaluated at runtime.
            // hence, it is an expression.
            string userInput = Console.ReadLine();

            // finally boolean expressions? yes please!
            // Boolean Expressions.
            int age = 23;
            bool canDrink = age >= 18;

            // if statements, more on this in a bit...
            if (canDrink)
            {
                Console.WriteLine("WHAT DO YOU WANT!!!!");
            }
            else
            {
                Console.WriteLine("FUCK OFF");
            }

            // Comparison Operators
            // allows you to compare two data points 
            // into a boolean expression
            canDrink = age >  21; // greater than, if number 
                                 // is greater, true, else: false

            canDrink = age <  21; // less than, if number 
                                 // is less, true, else: false
            // age = 32
            canDrink = age >= 21; // Equal to or greater than
            canDrink = age <= 21; // Equal to or less than

            canDrink = age == 21; // Equality operator,
                                  // data HAS to equal data true
                                  // else false

            canDrink = age != 21; // Inequality operator,
                                  // data NOT equal to DATA true
                                  // else false

            // LOGICAL OPERATORS
            // lets you chain together multiple boolean expressions 
            // together, to evaluate into a single boolean value
            // at runtime (ie. boolean expression)

            bool hasId = true;
            canDrink = hasId && age >= 21; // BOTH EXPRESSIONS HAS TO BE TRUE
                                           // Both Operands has evaluate to true
                                           // if the left operand is false before the right operand, the right
                                           // operand will NOT be operated on, which means that code WILL NOT RUN.
                                           // this is known as Short Circuiting

            canDrink = hasId || age >= 21; // EITHER Expression has to BE TRUE
                                           // ONly ONE Operand has to evaluate to true
                                           // if the left operand is true,
                                           // the right operand will not run, 
                                           // this is still short circuiting

            canDrink = !(hasId && age >= 21); // BANG or NOT operator, getting
                                              // the inverse value of the 
                                              // boolean expression
            canDrink = !false; // evals to true
            canDrink = !true;  // evals to false


            // Control flow with control flow expresions / scopes

            // If statement

            bool isTrue = !true;
            if (isTrue) // ONLY IF TRUE, STEP INTO IF SCOPE
            {
                // if the code evals to true IN the parens of the 
                // if statement, THEN the program will step into
                // this Block or SCOPE of code. where curly brackets
                // in this context defines your Scope/Block of code.
                Console.WriteLine("Hey, I'm inside the if statement!");
            }

            // If Else, an If statement WITH a DEFUALT path
            // the if statment takes in a boolean expression, this means the 
            // expression can be of ANY size, as long is something evaulautes 
            // to a boolean, ie. True or False
            if ((1 == 1 && 2 > 1))
            {
                // run code in here
                Console.WriteLine("I will run, but ELSE block will not");
            } 
            else // totally optinal
            {
                // the inverse or DEFAULT code will run here ONLY if the 
                // above if statement is FLASE
                Console.WriteLine("I'll only run if the if statement is false");
            }

            // if, else if, else if, ... .etc.... then else if you want it
            // you chain else ifs to your if statement, and your else ifs, 
            // run in order
            // there is no limit to how many else ifs you can chain.
            // and just like the above example, else is still optional

            if (isTrue)
            {

            }
            else if(isTrue || canDrink)
            {
                // Will ONLY run if If statement is false
            }
            else
            {// else is efault because it's the LAST check you can 
                // chain in your if else chains.

                // Will only run if ABOVE else if is false
                // think of chaining an else block IF all the above
                // if and else if statements are false.

                // no if or other else ifs can come after 'else', 
                // 'else' is the FINAL default 'branch'
            }


            // switch case
            int z = 5;

            if (z == 1)
            {
                Console.WriteLine("your choice is 1");
            }
            else if (z == 2)
            {
                Console.WriteLine("your choice is 2");
            }
            else if (z == 3)
            {
                Console.WriteLine("your choice is 3");
            }
            else
            {
                Console.WriteLine("you have some number I don't care about");
            }

            // switch / case statement is syntactic sugar for the above code.
            // switch cases are used whenever you are running multiple equality
            // checks on the same value, equality being the equality comparison
            // operator
            // ie.  z == 1
            //      z == 5
            //      z == 6
            switch(z)
            {
                case 1:
                    {
                        Console.WriteLine("your choice is 1");
                        break; // this just means break out of the entire switch case statement
                    }
                case 2:
                    {
                        Console.WriteLine("your choice is 2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("your choice is 3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("you have some number I don't care about");
                        break;
                    }
            }

            // Terenary operator
            int a;
            if (isTrue)
            {
                // if true, your variable gets assgined a value.
                a = 3;
            }
            else
            {
                // else, ie false, you assign THIS value instead
                a = 6;
            }

            // Terenary operator is syntactic sugar for the code above
            // the pattern here is if you need to assign a value to a
            // variable based on a boolean expression, but becasue variables
            // cannot be used if unassigned, you need a default value in case
            // your expression is false.

            int b = isTrue 
                ? 3 // if true, assign the b variable 3
                : 6; // if false, assign the b variable 6.

            int c = isTrue ? 3 : 6; // same thing, just one line

            // Loops - they exist, just example for now lol, next 
            // sln, a deep dive

            int d = 5;
            // as long as the expression in the while loop is TRUE,
            // you will step into  the while loop scope.
            while (d > 0)
            {
                Console.WriteLine($"the value of d is {d}");
                d--;
            }

            // done with the while loop... more on this tomorrow ;)

            // better way to parse safely
            Console.WriteLine("Hey, please enter a WHOLE number");
            string userNumberInput = Console.ReadLine();
            int userNumber = int.Parse(userNumberInput); // IF THE USER INPUTS
                                                        // AN INVALID NUMBER,
                                                        // THIS WILL BREAK 
                                                        // YOUR PROGRAM!!!
            
            // we can use TryParse which is a function that returns a BOOLEAN
            // so if the user enters a valid number, we can then assign the 
            // parsed number in our 'out' int, and use it inside of our 
            // if statement!
            // the fact that we are using the int keyword in our "out", 
            // means we are declaring a NEW variable.  if you have an existing
            // int that you want to use, you can omit the 'int'
            if (int.TryParse(userNumberInput, out int validUserNumber))
            {
                Console.WriteLine(validUserNumber + 2);
            } 
            else
            {
                Console.WriteLine("Sorry, this is an invalid number!");
            }

        }
    }
}