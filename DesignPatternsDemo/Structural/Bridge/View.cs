namespace DesignPatternsDemo.Bridge
{
    abstract class View
    {
        protected Resource Resource { get; set; }

        public View(Resource resource)
        {
            Resource = resource;
        }

        public abstract string Show();
    }
}
