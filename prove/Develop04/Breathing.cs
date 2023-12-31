using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Breathing:Activity{
    //This class holds the process for the breathing activity.
    // introduction is for the intro. 
    private string introduction=("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    public Breathing(string name, int duration):base(name, duration){
        _name=name;
        _duration=duration;
        _introduction=introduction;
    }
        

    public void BreathingProcess(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime<futureTime){
            currentTime=DateTime.Now;
            Console.WriteLine("Breath in...");
            Thread.Sleep(1000);
            bool stage1 =true;
            int x=3;
            // x is used to store the countdown which is displayed.
            while (stage1==true){
                if (x>0){
                    x-=1;
                    Console.Write($"{x+1}");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                else if(x==0){
                    x=3;
                    stage1=false;
                }
            }
            Console.WriteLine("Breath out...");
            Thread.Sleep(1000);
            bool stage2 =true;
            while (stage2==true){
                if (x>0){
                    x-=1;
                    Console.Write($"{x+1}");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                else if (x==0){
                    x=3;
                    stage2=false;
                }                
            }
            currentTime = DateTime.Now;
        }
    }
}