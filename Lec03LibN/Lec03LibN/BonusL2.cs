using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class BonusL2 : IFactory
    {
        float a = 0;
        public BonusL2(float a)
        {
            this.a = a;
        }
        public IBonus getA(float cost1hour)
        {
            return new L2A(cost1hour, a);
        }
        public IBonus getB(float cost1hour, float x)
        {
            return new L2B(cost1hour, a, x);
        }
        public IBonus getC(float cost1hour, float x, float y)
        {
            return new L2C(cost1hour, a, x, y);
        }
    }
}
