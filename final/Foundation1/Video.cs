using System;
public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public int _countComments;
    public List<Comments> _commentList = new List<Comments>();

    public Video()
    {

    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video length (in seconds): {_lengthInSeconds}");
    }

    public void AddComment(string commentText, string commentator)
    {
        Comments comments = new Comments();

        comments._commentText = commentText;
        comments._commentator = commentator;
        _commentList.Add(comments);
    }

    public void DisplayComment()
    {
        foreach (Comments comment in _commentList)
        {
            comment.Comment();
        }
    }

    public void GetNumberOfComments()
    {
        _countComments = _commentList.Count();

        Console.WriteLine($"The number of comments for this video is: {_countComments} ");
    }
}