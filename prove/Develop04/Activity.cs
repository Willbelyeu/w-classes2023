using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Activity
{
    protected string _name;
    protected int _duration;
    protected string _introduction;
    public Activity(string name, int duration){
        _name=name;
        _duration=duration;
    }
    public void DisplayIntroduction(){
        Console.WriteLine($"{_introduction}");
    }
    public void DisplayAchievement(){
        Console.WriteLine($"You have done {_name} for {_duration} seconds!");
    }
}