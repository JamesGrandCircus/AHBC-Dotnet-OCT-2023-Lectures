using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___OOPb_part_3
{
    public class Fruit
    {
        public int Seeds { get; set; }
    }

    public class Apple : Fruit
    {
        public Apple()
        {
            this.Seeds = 8;
        }
        public string CoreFlavor { get; set; }
    }

    public class Orange : Fruit
    {
        public Orange()
        {
            Seeds = 4;
        }
    }

    public class Grape : Fruit
    {
        public Grape()
        {
            Seeds = 2;
        }
    }
}
