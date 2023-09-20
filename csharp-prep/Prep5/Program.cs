using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        void WelcomeToProgram()
        {
            Console.WriteLine("Welcom to program!");
        }
        string GetUserName()
        {
            Console.WriteLine("What is your name?");
            string YourName=Console.ReadLine();
            return YourName;
        }
        int GetUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int YourNumber=int.Parse(Console.ReadLine());
            return YourNumber;
        }
        int SquareFavoriteNumber(int number)
        {
            int SquareNumber=number*number;
            return SquareNumber;
        }
        static void DisplayResults(string YourName, int SquareNumber)
        {
            Console.WriteLine($"{YourName}, the square of your number is {SquareNumber}.");
        }
        WelcomeToProgram();
        string YourName=GetUserName();
        int YourNumber=GetUserNumber();
        int SquareNumber=SquareFavoriteNumber(YourNumber);
        DisplayResults(YourName,SquareNumber);
    }
}