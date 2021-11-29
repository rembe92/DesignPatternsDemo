namespace DesignPatternsDemo.Facade
{
    internal class A
    {
        B _b;

        public A(B b)
        {
            _b = b;
        }

        public void ComplexMethod()
        {
            //ComplexMethod
            _b.ComplexMethod();
        }
    }
}
