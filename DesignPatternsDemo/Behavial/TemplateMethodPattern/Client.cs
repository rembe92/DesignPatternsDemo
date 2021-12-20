using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Behavial.TemplateMethodPattern
{
    // defines the skeleton of an algorithm in the superclass but lets subclasses
    // override specific steps of the algorithm without changing its structure
    // break down an algorithm into a series of steps, turn these steps into methods,
    // and put a series of calls to these methods inside a single template method
    // The steps may either be abstract, or have some default implementation.
    //source https://www.youtube.com/watch?v=7ocpwK9uesw&t=1455s&ab_channel=ChristopherOkhravi
    //https://refactoring.guru/design-patterns/template-method
    public static class Client
    {
        public static void Demo()
        {
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.TemplateMethod();
        }
    }
}
