public class Reflection:Activity{
    //This class holds the process for the reflection activity. 
    //UserPrompts is the list for what you are thinking about, and contemplationPrompts is a list to help them think.
    private string introduction=("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    private string[] userPrompts={"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private string[] contemplationPrompts={"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public Reflection(string name, int duration):base(name, duration){
        _name=name;
        _duration=duration;
        _introduction=introduction;
    }

    public void reflectionSpinner(){
        // the symbol "\" is a command so it could not be used on the console.
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("-");
    }
    public void ReflectionProcess(){
        Thread.Sleep(5000);
        Random rnd = new Random();
        int random=rnd.Next(0,3);
        //the two lines above are to find items on the userprompt list.
        Console.WriteLine($"{userPrompts[random]}");
        Thread.Sleep(3000);
        int ran=0;
        //ran is short for random, which will be used to find an option on the contemplationPrompts list.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime=DateTime.Now;
        while (currentTime<futureTime){
            ran=rnd.Next(0,8);
            Console.WriteLine($"{contemplationPrompts[ran]}");
            reflectionSpinner();
            currentTime=DateTime.Now;
        }
    }
}