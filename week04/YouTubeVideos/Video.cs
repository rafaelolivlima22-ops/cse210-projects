using System.Collections.Generic;
class Video 
{
    string _title;
    string _author;
    int _lengthInSeconds;
    List<Comment>_comments;
    

    public Video(string title, string author, int lengthInSeconds)
    {
        this._title = title;
        this._author = author;
        this._lengthInSeconds = lengthInSeconds;
        this._comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

     public string GetTitle()
    {
        return _title;
    }

     public string GetAuthor()
    {
        return _author;
    }

     public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

     public List<Comment> GetComments()
    {
        return _comments;
    }

}