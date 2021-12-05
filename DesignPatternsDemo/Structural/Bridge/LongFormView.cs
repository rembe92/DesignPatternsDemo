namespace DesignPatternsDemo.Bridge
{
    internal class LongFormView : View
    {
        public LongFormView(Resource resource) : base(resource)
        {
        }

        public override string Show()
        {
            //construct html
            return Resource.Snippet();
        }
    }
}
