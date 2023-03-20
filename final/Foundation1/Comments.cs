public class Comments
{
    public string _commentator;
    public string _commentText;
    public List<Video> videos = new List<Video>();
    public Comments()
    {
    }

    public void Display()
    { 
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
    
    public void Comment()
    {
            Console.Write($"'{_commentText}' - ");
            Console.WriteLine($"{_commentator}");
    }
}
