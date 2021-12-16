using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Behavial.CommandPattern
{
    internal class Command : ICommand
    {
        Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action();
        }

        public void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
