using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;
using Microsoft.VisualBasic;

class Program
{        

    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int response=1;
        int total=0;
        int highest=0;
        int average=0;
        while (response!=0)
        {
            Console.WriteLine("Type a number to add to the list.");
            response=int.Parse(Console.ReadLine());
            if (response!=0)
            {
                numbers.Add(response);
                total+=response;
                if (response>=highest)
                {
                    highest=response;
                }
                foreach (int number in numbers)
                {  
                    Console.Write($"{number}, ");                
                }
            }
            else
            {
                average=total/numbers.Count;
                Console.WriteLine ($"sum total is {total}");
                Console.WriteLine ($"Highest number is {highest}");
                Console.WriteLine ($"Average of numbers is {average}");
            }
        }
    }
}