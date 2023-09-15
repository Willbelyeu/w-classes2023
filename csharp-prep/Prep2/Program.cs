using System;

class Program
{
    static void Main(string[] args)
    {
        string importantNumber;
        string letterGrade;
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        importantNumber=Console.ReadLine();
        int number=int.Parse(importantNumber);

        if (number>=90)
        {
            letterGrade="A";
        }
        else if (number>=80 && number<90)
        {
            letterGrade="B";
        }
        else if (number>=70 && number<80)
        {
            letterGrade="C";
        }
        else if (number>=60 && number<70)
        {
            letterGrade="D";
        }
        else 
        {
            letterGrade="F";
        }

        if (number>70)
        {
            Console.WriteLine($"Your letter grade is {letterGrade}. Congradulations! You have passed.");
        }
        else if (number<70)
        {
            Console.WriteLine($"Your letter grade is {letterGrade}. You have failed this class.");
        }
    }
}