namespace DesignPatternsDemo.Builder
{
    class UserBuilder : IUserBuilder
    {
        User user;
        public UserBuilder(string? name)
        {
            user = new User(name);
        }

        public UserBuilder SetAge(int age)
        {
            user.Age = age;
            return this;
        }

        public UserBuilder SetAddress(Address? address)
        {
            user.Address = address;
            return this;
        }

        public User Build() => user;
    }
}
