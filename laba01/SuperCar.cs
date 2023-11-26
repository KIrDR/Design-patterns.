using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba01
{
    public class SuperCar : Car
    {
        public override void Info()
        {
            Console.WriteLine("У тебя есть суперКар");
        }

        public void Ride()
        {
            Console.WriteLine($"Едешь со скростью звука !!! \t Твоя можность:{Power}");
        }
    }
}
