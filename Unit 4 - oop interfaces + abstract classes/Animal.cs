using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___oop_interfaces___abstract_classes
{
    internal class Animal
    {

        // field, stores private data.. ie.
        // it's literally a VARIABLE
        // SCOPED to a class.
        private int _id;

        // public data
        public int CellCount { get; set; }

        // this constructor returns a new 
        // Animal object
        public Animal()
        {
            
        }

        // A fucntion that lives inside of class
        public void DoThing()
        {
            // ORDER ONLY MATTERS IN FUNCTIONS!!!
        }


        // all MEMBERS have an access level of
        // PRIVATE by default.  it's up to you
        // the developer to provide a non private
        // access modifier
        void OtherDoThing()
        {

        }
    }

    //  the colon means "inherits" or "implements"
    //                   ⬇️
    internal class Mammal : Animal
    {
        
    }
}
