namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // Every delegate is a class derived from multicast delegate - which is derived from System.Delegate - has method and target(class that holds the method)
            //PhotoProcessor.PhotoFilterHandler photoFilterHandler = filters.ApplyBrightness;
            Action<Photo> photoFilterHandler = filters.ApplyBrightness;
            photoFilterHandler += filters.ApplyContrast;
            photoFilterHandler += RemoveRedEyeFilter;
            processor.Process("sample.jpg", photoFilterHandler);

        }

        static void RemoveRedEyeFilter(Photo photo) // Newly created filter - after release of application  
        {
            Console.WriteLine("Apply RemoveRedEyes");
        }
    }
}
