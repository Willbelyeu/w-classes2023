using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Activity
{
    //this class holds data used for the three activity classes.
    // Name refers to the activity name, duration the time in seconds for the activity. Introduction is the intro.
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