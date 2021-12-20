using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Behavial.TemplateMethodPattern
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            OperationOne();
            OperationTwo();
            OperationThree();
        }

        public abstract void OperationOne();
        public abstract void OperationTwo();
        public virtual void OperationThree()
        {
            Console.WriteLine("TemplateMethodPattern OperationThree");
        }
    }
}
