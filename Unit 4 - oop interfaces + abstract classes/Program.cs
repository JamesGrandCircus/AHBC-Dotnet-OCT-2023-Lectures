namespace Unit_4___oop_interfaces___abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void RunExampleOne()
        {

            // this is an example of calling
            // the Mammal constructor
            var mammal = new Mammal();

            mammal.DoThing();

            // you can use underscores to 
            // represent commans for larger 
            // numbers, for ease of reading.
            //
            //                 1,000,000
            mammal.CellCount = 1_000_000;
        }

        static void RunExampleTwo()
        {
            // you CANNOT create instances of
            // interfaces into memory.
            // this is because an interface 
            // DESCRIBES what a class HAS TO 
            // DO, it is not a thing that can exist.
            // var drive = new IDrive();

            var car = new Car() as IDrive;
            car.Accelerate(10);
            car.Decelerate(5);

            // you CAN use interfaces in places of 
            // types or generics, because C# assumes
            // that you will just create intstances
            // of objects that IMPLEMENT said interface.
            var drivers = new List<IDrive>();

            drivers.Add(car);
            drivers.Add(new Elevator());

            foreach (var driver in drivers)
            {
                driver.Accelerate(2);
            }

        }
    }
}