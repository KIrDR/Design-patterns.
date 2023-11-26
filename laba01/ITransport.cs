using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba01
{
    public  interface ITransport
    {
        string name { get; set; }

        void Ride();
    }
}
