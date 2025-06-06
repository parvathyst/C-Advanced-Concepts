namespace Delegates
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> photoFilterHandler) // Using Action delegate
        {
            var photo = Photo.Load(path);
            // Without delegate - Not extensible - after every new filter - compilation and deployment
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.ApplyResize(photo);
            // With delegate
            photoFilterHandler(photo);  // the needed filter is defined by the client
            photo.Save();
        }
    }
}
