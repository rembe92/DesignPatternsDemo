namespace DesignPatternsDemo.Behavial.StatePattern
{
    //Context
    internal class Gate
    {
        IGateState state;

        public Gate(IGateState state)
        {
            this.state = state;
        }

        public void Enter()
        {
            state.Enter();
        }

        public void Pay()
        {
            state.Pay();
        }

        public void PayOk()
        {
            state.PayOk();
        }

        public void Failed()
        {
            state.PayFailed();
        }

        public void ChangeState(IGateState state)
        {
            this.state = state;
        }
    }
}
