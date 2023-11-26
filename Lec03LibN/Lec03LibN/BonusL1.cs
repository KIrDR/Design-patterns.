using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class BonusL1 : IFactory
    {
        public IBonus getA(float cost1hour)
        {
            return new L1A(cost1hour);
        }
        public IBonus getB(float cost1hour, float x)
        {
            return new L1B(cost1hour, x);
        }
        public IBonus getC(float cost1hour, float x, float y)
        {
            return new L1C(cost1hour, x, y);
        }
    }
}
