using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___OOPa_part_2
{
    internal class Instruction
    {
        public static void RunInstruction()
        {
            var room = new Room(10, 12);

            Console.WriteLine(room.Area); 
        }
    }
}
