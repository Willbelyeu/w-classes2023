using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Activity
{
    private string _name;
    private int _durantion;
    private DateTime _startTime;
    public void Getter(string name, int duration, DateTime startTime){
        _name=name;
        _durantion=duration;
        _startTime=startTime;
    }
}