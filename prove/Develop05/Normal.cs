using System.Runtime.CompilerServices;

class Normal:Goal{
    private List <string> normal=new List<string>();
    private string goaltype="Normal";
    private string completionsneeded="1";
    public override void Completed()
    {
        base.Completed();
    }
    public override string NewGoal()
    {
        base.NewGoal();
        string goalline=($"{goaltype}--{goalname}--{goaldiscription}--0--{points}--0--/--{completionsneeded}");
        return goalline;
    }
}