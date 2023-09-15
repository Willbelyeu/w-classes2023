using System;

class Program
{
    static void Main(string[] args)
    {
        string firstname;
        string lastname;
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name?");   
        firstname=Console.ReadLine();
        Console.Write("What is your last name?");
        lastname=Console.ReadLine();
        Console.Write($"Your name is {lastname}, {firstname} {lastname}.");
    }

}
