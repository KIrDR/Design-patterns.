using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class BonusL3 : IFactory
    {
        float a = 0;
        float b = 0;
        public BonusL3(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public IBonus getA(float cost1hour)
        {
            return new L3A(cost1hour, a, b);
        }
        public IBonus getB(float cost1hour, float x)
        {
            return new L3B(cost1hour, a, b, x);
        }
        public IBonus getC(float cost1hour, float x, float y)
        {
            return new L3C(cost1hour, a, b, x, y);
        }
    }
}
