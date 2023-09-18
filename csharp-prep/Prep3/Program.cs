using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator=new Random();
        int number= randomGenerator.Next(1,11);
        int guessNumber=21;

        while (guessNumber!=number) 
        {         
            Console.Write("What do you think the number is?");
            guessNumber=int.Parse(Console.ReadLine());

        
            if (guessNumber>number)
            {
                Console.WriteLine("Your guess is larger than the number.");
            }
            else if (guessNumber==number)
            {
                Console.WriteLine("That is correct.");
            }
            else if (guessNumber<number)
            {
                Console.WriteLine("Your guess was smaller than the number.");
            }
        }
            
    }
}