namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine($"Applying brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine($"Applying contrast");
        }

        public void ApplyResize(Photo photo)
        {
            Console.WriteLine($"Resizing photo");
        }
    }
}
