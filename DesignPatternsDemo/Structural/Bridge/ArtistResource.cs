namespace DesignPatternsDemo.Bridge
{
    internal class ArtistResource : Resource
    {
        public Artist Artist { get; set; }

        public ArtistResource(Artist artist)
        {
            Artist = artist;
        }

        public override string Description()
        {
            throw new NotImplementedException();
        }

        public override string Snippet()
        {
            return Artist.Biology;
        }

        public override string Title()
        {
            return Artist.Name;
        }

        public override string Url()
        {
            throw new NotImplementedException();
        }
    }
}
