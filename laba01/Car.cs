using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba01
{
    public class Car : ITransport
    {
        private float power;
        public float Power
        {
            set { power = value; }
            get { return power; }
        }
        public void Ride()
        {
            Console.WriteLine("Едешь как обчная машина ");
        }

        public string name { get; set; }

        virtual public void Info()
        {
            Console.WriteLine($"Название машины {name} \t Её мощность = {power} \n ");

        }

        public void Upgrete(float plus )
        {
            Console.WriteLine("\nПроизошёл АПГРЕЙД\n");

            Power += plus;
        }

    }
}
