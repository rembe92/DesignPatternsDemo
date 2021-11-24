namespace DesignPatternsDemo.Builder
{
    class Client
    {
        // separates the construction of a complex object from its representation
        //Encapsulate creating and assembling the parts of a complex object in a separate Builder object
        //A class delegates object creation to a Builder object instead of creating the objects directly
        // source: https://en.wikipedia.org/wiki/Builder_pattern
        public void Demo()
        {
            var user = new UserBuilder("Ben").SetAddress(new Address()).SetAge(10).Build();
        }
    }
}
