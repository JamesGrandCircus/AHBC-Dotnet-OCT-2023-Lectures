namespace Unit_2___Methods__Functions__part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z = DivideTwoNumbers(1.2, 0.4);
            double a = DivideTwoNumbers(20.5f, 0.5f);
            double b = DivideTwoNumbers(1.3);
            double c = DivideTwoNumbers();
        }


        static double DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            return result;
        }

        // Function Overloading
        // Overlaoding a function simply means creating another fucntion (in the same class)
        // that has..
        // 1). Same Name
        // 2). Same output.
        // 3). Different Input. (number of inputs and or types)
        // ... the only thing that is different, is the input
        // when do you overload? typically when you are SOLVING the exact same problem,
        // but you need different inputs / input types

        static double DivideTwoNumbers(float x, float y)
        {
            double result = x / y;
            return result;
        }

        static double DivideTwoNumbers(double x)
        {
            double result = x / 0.1;
            return result;
        }

        static double DivideTwoNumbers()
        {
            double result = 0.5 / 0.1;
            return result;
        }
    }
}