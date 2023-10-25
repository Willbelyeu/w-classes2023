using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        WrittingAssignment writtingAssignment= new WrittingAssignment("Samuel Bennett", "Eauropean History", "An irelivent string");
        string summaryWritting=writtingAssignment.GetSummary();
        string writtingSummary=writtingAssignment.GetWrittingInformation();
        Console.WriteLine($"{summaryWritting}");
        Console.WriteLine($"{writtingSummary}");

        MathAssignment mathAssignment= new MathAssignment("Samuel Bennett", "fractions", "section 7.3", "Problems 8-19");
        string summaryMath=mathAssignment.GetSummary();
        string mathSummary=mathAssignment.GetHomeworkList();
        Console.WriteLine($"{summaryMath}");
        Console.WriteLine($"{mathSummary}");
    }
}