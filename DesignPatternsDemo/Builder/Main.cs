namespace DesignPatternsDemo.Builder
{
    class Main
    {
        public void Demo()
        {
            var user = new UserBuilder("Ben").SetAddress(new Address()).SetAge(10).Build();
        }
    }
}
