namespace Events
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise/publish the event
        public class VideoEventArgs : EventArgs // To pass additional information like reference to the video etc we need a class that is derived from EventArgs
        {
            public Video Video { get; set; }
        }
        //public delegate void VideoEncodedEventHandler(object source, EventArgs e);
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);
        //public event VideoEncodedEventHandler VideoEncoded; // Past tense as the process has happened then event is fired
        public event EventHandler<VideoEventArgs> VideoEncoded; // Pre-built can be used instead of custom delegate
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            //OnVideoEncoded();
            OnVideoEncoded(video);
        }
        // Event publisher method
        //protected virtual void OnVideoEncoded()
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null) // Checking for subscribers
            {
                //VideoEncoded(this, EventArgs.Empty);

                VideoEncoded(this, new VideoEventArgs() { Video = video});

            }
        }
    }
}
