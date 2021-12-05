namespace DesignPatternsDemo.Bridge
{
    abstract class Resource
    {
        public abstract string Snippet();

        public abstract string Title();

        public abstract string Description();

        public abstract string Url();
    }
}
