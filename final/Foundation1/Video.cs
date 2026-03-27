using System;


public class Video
{
    public string _title;
    public string _author;
    public  List<Comment> _comment = new List<Comment>();
    public double _length;

public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

public string GetTitle()
    {
        return _title;
    }

public string GetAuthor()
    {
        return _author;
    }

public double GetLength()
    {
        return _length;
    }

public void AddComment(Comment comment)
    {
         _comment.Add(comment);
    }
public int GetNumberOfComment()
    {
        return _comment.Count;
    }
public List<Comment> GetComments()
    {
        return _comment;
    }
}