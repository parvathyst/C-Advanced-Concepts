namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();
                //calculator.Divide(5, 0); // DivideByZero Exception
                var api = new YoutubeApi();
                var videos = api.GetVideos("Sample");
            }
            // Always write from most specific to most generic exceptions
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero is not possible.");
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // ex has message, source(name of application that generated the error), target site(method where exception happened), stack trace etc properties
            {

                //Console.WriteLine("Sorry! An unexpected error has occured.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}