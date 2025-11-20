public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comments> _comments;

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = new List<Comments>();
    }

    public int GetCommentsNum()
    {
        return _comments.Count;
    }
}