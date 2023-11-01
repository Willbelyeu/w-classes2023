using System;

class Menu
{
    static void Main(string[] args)
    {
        Console.WriteLine("To reflection, press 1. To List, press 2. For breathing, press 3.");
        string activityNext=Console.ReadLine();
        Console.WriteLine("How long in seconds will you do this activity?");
        var duration=int.Parse(Console.ReadLine());
        string name="Blank";
        DateTime startTime = DateTime.Now;
        Breathing Runthrough=new Breathing();
        Runthrough.Getter(name, duration, startTime);
        Runthrough.BreathingLoop(duration);
    }
}