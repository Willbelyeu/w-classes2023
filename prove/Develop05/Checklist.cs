using System.Runtime.CompilerServices;

class Checklist:Goal{
    private List <string> checklist=new List<string>();
    public override void Completed()
    {
        base.Completed();
    }
    public override void NewGoal()
    {
        base.NewGoal();
        Console.WriteLine("How many times do you wish to do this goal?");
        string count=Console.ReadLine();
        Console.WriteLine("How many points will completion be worth?");
        string finalpoints=Console.ReadLine();
    }

}
