using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___OOP_intro
{
    public class Student // c# recognizes this as a progammer defined TYPE
    {
        // these three properties will STAY PUBLIC
        // so we can ACCESS them in the PROGRAM class.
        // .. or really any class that needs to access these properties
        public string Name { get; set; }
        public double Grade { get; set; }
        public string Course { get; set; }

        public string GetStudenInfo()
        {
            return $"Name: {Name}\nGrade: {Grade}\nCourse: {Course}";
        }
    }
}
