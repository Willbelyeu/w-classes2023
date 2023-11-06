using System.Diagnostics;

public class ListingActivity:Activity{
    //This class holds the process for the listing activity. 
    //prompts is a list for userprompts, introduction gives us a intro, and userEntries is where the user's responses are recorded.
    private string introduction=("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    private string[] prompts={"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> userEntries=new List<string>();
    //userEntries had to be in list rather than array in order to count the entries.
 
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
        //promptchoice is to get a random option from the promptChoice list.
        Console.WriteLine($"{prompts[promptChoice]}");

        Thread.Sleep(1000);
        Console.WriteLine("Think about what you want to enter.");
        Thread.Sleep(1000);
            bool stage1 =true;
            int x=5;
            // x is used to store the countdown which is displayed. 
            //In retrospect I could have made a method in activity that I could pass a value for x and it would count
            //down for me, but I'm out of time to work now.
            while (stage1==true){
                if (x>0){
                    x-=1;
                    Console.Write($"{x+1}");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                else if(x==0){
                    x=5;
                    stage1=false;
                }
            }
        DateTime currentTime = DateTime.Now;
        while (currentTime<futureTime){
            Console.WriteLine("Press enter to submit your choice.");
            string userEntry=Console.ReadLine();
            userEntries.Add(userEntry);
            Console.WriteLine("Keep entering until time is up.");
            currentTime=DateTime.Now;
        }
        int entryCount=userEntries.Count();
        //entryCount and userEntries now works. 
        Console.WriteLine($"You listed {entryCount} responses.");
    }
}