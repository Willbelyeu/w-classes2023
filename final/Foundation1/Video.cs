using System.Reflection.Metadata.Ecma335;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments=new List<Comment>();
    public Video(string title, string author, int length,  List<Comment> comments){
        _title=title;
        _author=author;
        _length=length;
        _comments=comments;
    }
    public string GetTitle(){
        return _title;
    }
    public string GetAuthor(){
        return _author;
    }
    public int GetLength(){
        return _length;
    }
    public List<Comment> GetList(){
        return _comments;
    }
    public int commentCount(){
        int count=_comments.Count;
        return count;
    }
}