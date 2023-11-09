using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___oop_interfaces___abstract_classes
{
    // a class can implement as many 
    // interfaces as it wants
    // a class can ONLY inherit from one other class
    internal class Car : IDrive, ITurn
    {
        private int _currentSpeed = 0;
        private string _direction = "forward";

        public void Accelerate(int speed)
        {
            if (_currentSpeed < speed)
            {
                _currentSpeed += speed;
            }
        }

        public void Decelerate(int speed)
        {
            if (_currentSpeed > speed)
            {
                _currentSpeed -= speed;
            }
        }

        public void TurnInDirection(string direction)
        {
            _direction = direction;
        }
    }

    public class Elevator : IDrive
    {
        int _currentSpeed;

        public void Accelerate(int speed)
        {
            if (speed > _currentSpeed && speed < 3)
            {
                _currentSpeed += speed;
            }
        }

        public void Decelerate(int speed)
        {
           if (speed < _currentSpeed && speed > 3)
            {
                _currentSpeed -= speed;
            }
        }
    }

    // public contracts, a class that implements this
    // interface HAS to make the members the interface
    // is demanding, public
    internal interface IDrive
    {
        // when defining Methods inside of 
        // an interfacem, you DO NOT provide
        // a SCOPE for that interface.
        // this is because , the Classs
        // that impelments said interface 
        // HAS TO PROVIDE THE SCOPE
        void Accelerate(int speed);

        // when defining a method in an interface,
        // simply provide the return type, the name,
        // and it's parameters
        // otherwise known as.. method signature.
        void Decelerate(int speed);
    }


    // interfaces ARE TYPES, which means you can
    // use polymorphism with them.
    // there are several reasons why interfaces are good
    // 1. it does enforce public methods for your calsses
    // 2. it allows NARROWING your type to specific
    //    functionality.  
    //
    // 3. for Mocking when writing unit tests
    // 4. for dependancy injections
    internal interface ITurn
    {
        // default access modifier for 
        // members described in an interface 
        // is public by default
        void TurnInDirection(string direction);
    }
}
