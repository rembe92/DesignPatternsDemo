namespace DesignPatternsDemo.Proxy
{
    internal class LazyBookParserProxy : IBookParser
    {
        private BookParser? bookParser = null;
        private string book;

        public LazyBookParserProxy(string book)
        {
            this.book = book;
        }

        public int? GetNumberOfPages()
        {
            if (bookParser is null)
                bookParser = new BookParser(book);

            return bookParser.GetNumberOfPages();
        }
    }
}
