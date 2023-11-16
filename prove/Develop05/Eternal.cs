using System.Runtime.CompilerServices;

class Eternal:Goal{
    private List <string> eternal=new List<string>();
    private string goaltype="Eternal";
    public override void Completed()
    {
        base.Completed();
    }
    public override string NewGoal()
    {
        base.NewGoal();
        int completionsneeded=4000;
        string goalline=($"{goaltype}--{goalname}--{goaldiscription}--0--{points}--0--/--{completionsneeded}");
        return goalline;
        //string goalline2=($"{goaltype}--{goalname}--{goaldiscription}--{points-per-completion}--{finalpoints}--{timescompleted}/{completions-needed}");
    }
}