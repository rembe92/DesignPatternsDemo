namespace DesignPatternsDemo.Facade
{
    internal class Facade
    {
        public void DoSomething()
        {
            B b = new B();
            b.ComplexMethod();
            A a = new A(b);
            a.ComplexMethod();
            
        }
    }
}
