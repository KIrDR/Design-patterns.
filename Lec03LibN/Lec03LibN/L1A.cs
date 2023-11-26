using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L1A : IBonus
    {
        public L1A(float cost1hour) 
        {
            this.cost1hour = cost1hour;
        }
        public float cost1hour { get; set; } = 0;
        public float calc(float number_hours) 
        {
            return number_hours * cost1hour;
        }
    }
}
