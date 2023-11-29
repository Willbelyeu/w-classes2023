using System.Reflection.Metadata.Ecma335;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments=new List<Comment>();
    public Video(string title, string author, int length,  List<Comment> comments){
        _title=title;
        _author=author;
        _length=length;
        _comments=comments;
    }
    public int commentCount(){
        int count=_comments.Count;
        return count;
    }
}