using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___OOPb_part_3
{

    // Interface describe what a Class CAN DO!, be describing a
    // Has A relationship. this is NOT IS A, ie. no inheritance
    // instead classes IMPLEMENT described members / behavior
    internal interface IDrive
    {
        // note that this is a method without a body!.... what?
        void Accelerate(); // these are Abstract methods, that means whatever class
                           // implements this interface, HAS TO define these methods themselves

        void Brake();
    }


    internal class Car
    {
        protected void Drive()
        {
            Console.WriteLine("I'm driving here");
        }
    }


    // a class can implement as MANY interfaces as you WANT
    internal class Truck : Car, IDrive // THIS IS NOT INHERITENCE
    {
        public void Accelerate()
        {
            Drive();
            Console.WriteLine("I'm driving here!");
        }

        public void Brake()
        {
            Console.WriteLine("");
        }
    }
}
