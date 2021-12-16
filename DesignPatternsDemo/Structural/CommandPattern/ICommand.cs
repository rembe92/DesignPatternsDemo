using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Structural.CommandPattern
{
    interface ICommand
    {
        public void Execute();

        //the inverse
        public void UnExecute();
    }
}
