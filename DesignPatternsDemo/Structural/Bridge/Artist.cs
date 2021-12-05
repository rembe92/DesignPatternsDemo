namespace DesignPatternsDemo.Bridge
{
    internal class Artist
    {
        public string Biology { get; set; }

        public string Name { get; set; }

        public Artist(string biology, string name)
        {
            Biology = biology;
            Name = name;
        }
    }
}
