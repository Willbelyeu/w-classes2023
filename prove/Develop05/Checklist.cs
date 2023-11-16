using System.Runtime.CompilerServices;

class Checklist:Goal{
    private List <string> checklist=new List<string>();
    private string goaltype="Checklist";
    public override void Completed()
    //Checklist is a goal that can be done a few times, so It needs to check if the goal is already complete, then if not add +1 to the count.
    //If the goal has been done the number of times it can be, it should give the bonus level points rather than the normal points. This should-
    //-be doable through if else if statements.
    {
        base.Completed();
    }
    public override string NewGoal()
    {
        base.NewGoal();
        Console.WriteLine("How many times do you wish to do this goal?");
        string completionsneeded=Console.ReadLine();
        Console.WriteLine("How many points will completion be worth?");
        string finalpoints=Console.ReadLine();
        string goalline=($"{goaltype}--{goalname}--{goaldiscription}--{points}--{finalpoints}--0--/--{completionsneeded}");
        return goalline;
    }
}
