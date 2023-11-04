using System.Diagnostics;

public class ListingActivity:Activity{

    private string introduction=("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    private string[] prompts={"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private string[] userEntries={};
 
    public ListingActivity(string name, int duration):base(name, duration){
        _name=name;
        _duration=duration;
        _introduction=introduction;
    }
    public void ListingProcess(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Random random=new Random();
        int promptChoice=random.Next(0,4);
        Console.WriteLine($"{prompts[promptChoice]}");

        Thread.Sleep(1000);
        Console.WriteLine("Think about what you want to enter.");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        DateTime currentTime = DateTime.Now;
        while (currentTime<futureTime){
            Console.WriteLine("Press enter to submit your choice.");
            string userEntry=Console.ReadLine();
            userEntries.Append(userEntry);
            Console.WriteLine("Keep entering until time is up.");
            currentTime=DateTime.Now;
        }
        int entryCount=userEntries.Count();
        Console.WriteLine($"You listed {entryCount+1} responses.");
    }
}