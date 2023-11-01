using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Breathing:Activity{
    private string introduction=("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

    
    public void BreathingLoop(int duration){
        int timeRemaining=duration;
        while (timeRemaining>=0){
            timeRemaining-=12;
            Console.WriteLine("Breath in...");
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("Breath out...");
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}