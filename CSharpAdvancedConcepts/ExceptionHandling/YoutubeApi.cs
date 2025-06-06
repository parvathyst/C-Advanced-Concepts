namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
			try
			{
                // Access youtube web service
                // Read the data
                // Create a list of video objects
                throw new Exception("Some low level youtube error."); // inner exception
			}
			catch (Exception ex)
			{
                // Log
				throw new YoutubeException("Could not fetch the videos from youtube.", ex); // Actual exception encapsulated within a meaningful one
			}
            return new List<Video>();
        }
    }
}
