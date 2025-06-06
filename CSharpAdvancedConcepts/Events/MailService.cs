using static Events.VideoEncoder;

namespace Events
{
    public class MailService
    {
        //public void OnVideoEncoded(object source, EventArgs e)
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            //Console.WriteLine("MailService: Sending an email...");
            Console.WriteLine("MailService: Sending an email..."+e.Video.Title);
        }
    }
}
