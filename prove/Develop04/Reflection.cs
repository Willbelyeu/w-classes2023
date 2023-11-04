public class Reflection:Activity{
    private string introduction=("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    private string[] userPrompts={"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private string[] contemplationPrompts={"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"};


    public Reflection(string name, int duration):base(name, duration){
        _name=name;
        _duration=duration;
    }

    public void reflectionSpinner(){
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
        Console.WriteLine($"{introduction}");
        Thread.Sleep(5000);
        Random rnd = new Random();
        int random=rnd.Next(0,3);
        Console.WriteLine($"{userPrompts[random]}");
        Thread.Sleep(3000);
        int ran=0;
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