using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Behavial.StatePattern
{
    internal interface IGateState
    {
        void Enter();
        void Pay();
        void PayOk();
        void PayFailed();
    }
}
