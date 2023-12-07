public class Comment
{
    private string _author;
    private string _comment;
    public Comment(string author, string comment){
        _author=author;
        _comment=comment;
    }
    public string GetAuthor(){
        return _author;
    }
    public string GetComment(){
        return _comment;
    }
}