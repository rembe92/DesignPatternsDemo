namespace DesignPatternsDemo.Adapter
{
    //Not changes the underlying behavior
    //Combines two different types of interfaces where the two interfaces are not interoperable
    //the adapter patterns makes the interfaces interoperable
    //example: external library, something you want to deprecated step by step

    //source https://www.youtube.com/watch?v=2PKQtcJjYvc&t=137s&ab_channel=ChristopherOkhravi
    internal class Client
    {

        public void Demo()
        {
            ITarget target = new Adapter(new Adaptee());
            target.Request();

        }
    }
}
