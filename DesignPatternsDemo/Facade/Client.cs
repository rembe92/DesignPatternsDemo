namespace DesignPatternsDemo.Facade
{
    // highter level interface, that makes the subsystem easier to use
    //improve the readability and usability of a software library
    //by masking interaction with more complex
    //components behind a single (and often simplified) API
    //provide a context-specific interface to more generic functionality (complete with context-specific input validation)

    //source: https://en.wikipedia.org/wiki/Facade_pattern#C++
    //https://www.youtube.com/watch?v=K4FkHVO5iac&ab_channel=ChristopherOkhravi
    internal class Client
    {
        public void Demo()
        {
            Facade facade = new Facade();
            facade.DoSomething();
        }
    }
}
