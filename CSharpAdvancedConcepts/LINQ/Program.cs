namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            // Without Linq - To query books that are cheaper than price 10
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if(book.Price < 10)
            //    {
            //        cheapBooks.Add(book);
            //    }
            //}
            // With Linq
            // Linq Extension methods
            var cheapBooks = books
                                  .Where(b => b.Price < 10)
                                  .OrderBy(b => b.Title)
                                  .Select(b=>b.Title);
            //cheapBooks.OrderBy(b => b.Title); // Instead of giving in next line can be chained to above line
            var singleBook = books.Single(b => b.Title == "Clean Code"); // For returning single object instead of list use Single instead of where
            var singleBook1 = books.SingleOrDefault(b => b.Title == "Clean Coder"); // To handle InvalidOperationException - there must be one object in collection that satisfies the condition - if not sure the object exist or not then use SingleOrDefault
            Console.WriteLine(singleBook1 == null);
            Console.WriteLine(singleBook.Title);
            var firstBook = books.First(b=>b.Title == "Refactoring"); // Gets the first object that satisfies the condition
            var firstBook1 = books.FirstOrDefault(b=>b.Title == "Refactoring123");
            var lastBook = books.LastOrDefault(b=>b.Title == "Refactoring");
            Console.WriteLine(firstBook.Title + " " + firstBook.Price);
            Console.WriteLine(lastBook.Title + " " + lastBook.Price);
            Console.WriteLine(firstBook==null);
            var pagingBookList = books.Skip(2).Take(3);
            foreach (var pagingBook in pagingBookList) 
            { 
                Console.WriteLine(pagingBook.Title);
            }
            var count = books.Count();
            Console.WriteLine(count);
            var maxPrice = books.Max(b=>b.Price);
            Console.WriteLine(maxPrice);
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);
            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);
            // Linq Query operators
            var cheaperbooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + ' '+book.Price);
                Console.WriteLine(book); // As select is used for projection and result is a list of string
            }
        }
    }
}