using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities=new List<Activity>();

        string date="Feb 12, 2012";
        double timeSpent=30; //in minutes
        double laps=40.4;
        string activity="swimming";
        Swimming swimming=new Swimming(date, timeSpent, laps, activity);
        activities.Add(swimming);

        date="Feb 13, 2012";
        timeSpent=30;//in minutes
        activity="cycling";
        double speed=8.4; //mph
        Cycling cycling=new Cycling(date, speed, timeSpent, activity);
        activities.Add(cycling);

        date="Feb 14, 2012";
        timeSpent=30;//in minutes
        activity="running";
        speed=5.2; //mph
        Running running=new Running(date, speed, timeSpent, activity);
        activities.Add(running);


        foreach (var act in activities){
            Console.WriteLine($"{act.GetSummary()}");
        }
    }
}