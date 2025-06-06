//using ExtensionMethodsExtensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a long blog post...";
            var shortenedPost = post.Shorten(5);
            IEnumerable<int> numbers = new List<int>() { 1,5,3,10,2,18}; // pre-existing extension methods
            var max = numbers.Max();
            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);
        }
    }
    //public class RichString : String {} // Cannot inherit from sealed class String
}