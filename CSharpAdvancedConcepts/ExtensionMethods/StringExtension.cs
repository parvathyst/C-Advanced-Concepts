//namespace ExtensionMethods.Extensions
namespace System
{
    public static class StringExtension // To solve above issue - need a static class: naming - Class extending follwed by Extension
    {
        public static string Shorten(this string str, int numberOfWords) // First parameter should always be "this type name"
        {
            if(numberOfWords < 0) throw new ArgumentOutOfRangeException("Number of words should be greater than or equal to 0.");
            if (numberOfWords == 0) return "";
            var words = str.Split(' ');
            if (words.Length <= numberOfWords) return str;
            return string.Join(' ',words.Take(numberOfWords))+"...";
        }
    }
}
