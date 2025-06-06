namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "The Pragmatic Programmer", Price = 5 },
                new Book() { Title = "Clean Code", Price = 9.99f },
                new Book() { Title = "Design Patterns", Price = 12 },
                new Book() { Title = "Refactoring", Price = 7 },
                new Book() { Title = "Refactoring", Price = 9 }
            };
        }
    }
}
