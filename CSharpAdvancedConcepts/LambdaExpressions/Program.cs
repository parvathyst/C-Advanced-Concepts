namespace LambdaExpressions
{
    class Program
    {
        public static void Main(string[] args)
        {
            // => : Lambda operator
            // args => expression : args goes to expression
            //number => number * number;
            // Without args: () => expression
            // One argument: x => expression
            // multiple argument: (x,y,z) => expression
            //Func<int, int> square = Square; // Delegate
            Func<int, int> square = number => number*number; // With lambda expression
            //Console.WriteLine(Square(5));// Without lambda expression
            Console.WriteLine(square(5));
            const int factor = 5;
            // Scope
            Func<int, int> multiplier = n => n * factor;
            // cw -> Tab : shortcut for Console.Writeline();
            var result = multiplier(10);
            Console.WriteLine(result);
            var books = new BookRepository().GetBooks();
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(b => b.Price<10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
        //static int Square(int number)
        //{
        //    return number*number;
        //}
        //static bool IsCheaperThan10Dollars(Book book) // Predicate method
        //{
        //    return book.Price < 10; // returns true if condition is satisfied - predicate
        //}
    }
}
    