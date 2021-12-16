namespace DesignPatternsDemo.Behavial.CommandPattern
{
    interface ICommand
    {
        public void Execute();

        //the inverse
        public void UnExecute();
    }
}
