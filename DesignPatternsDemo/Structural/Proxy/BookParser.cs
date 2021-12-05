namespace DesignPatternsDemo.Proxy
{
    internal class BookParser : IBookParser
    {
        public BookParser(string book)
        {
            //expensive parsing
        }

        public int? GetNumberOfPages()
        {
            throw new NotImplementedException();
        }
    }
}
