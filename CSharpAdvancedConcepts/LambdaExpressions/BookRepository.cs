namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title = "C# in Depth", Price = 5 },
                new Book { Title = "Clean Code", Price = 7 },
                new Book { Title = "The Pragmatic Programmer", Price = 17 }
            };
        }
    }
}
