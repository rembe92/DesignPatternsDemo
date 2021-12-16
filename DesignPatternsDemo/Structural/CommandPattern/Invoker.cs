namespace DesignPatternsDemo.Structural.CommandPattern
{
    internal class Invoker
    {
        public ICommand Action { get; set; }

        public ICommand AnotherAction { get; set; }

        public Invoker(ICommand action, ICommand anotherAction)
        {
            Action = action;
            AnotherAction = anotherAction;
        }

        public void InvokeAction()
        {
            Action.Execute();
        }

        public void InvokeAnotherAction()
        {
            AnotherAction.Execute();
        }


    }
}
