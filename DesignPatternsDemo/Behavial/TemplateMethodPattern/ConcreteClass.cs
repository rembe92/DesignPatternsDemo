namespace DesignPatternsDemo.Behavial.TemplateMethodPattern
{
    internal class ConcreteClass : AbstractClass
    {
        public override void OperationOne()
        {
            Console.WriteLine("ConcreteClass OperationOne");
        }

        public override void OperationTwo()
        {
            Console.WriteLine("ConcreteClass OperationTwo");
        }

        //could override operationThree
        public override void OperationThree()
        {
            base.OperationThree();
        }
    }
}
