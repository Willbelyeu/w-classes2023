using System.Runtime.CompilerServices;

class Normal:Goal{

    public Normal(string savedFile):base(savedFile){
        //nothing should be needed, as there are no new veriables.
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_goalType} goal, {_goalName}. {_goalDiscription} {_timesCompleted}/{_completionsNeeded}");
    }
    public override int Completed()
    {
        if (_pointsPerCompletion==_completionsNeeded){
            _timesCompleted+=0;
            return 0;
        }
        else {
            _timesCompleted+=1;
            return _finalPoints;
        }
    }
    public override string NewGoal()
    {
        base.NewGoal();
        string goalline=($"Normal--{_goalName}--{_goalDiscription}--{_pointsPerCompletion}--0--0--1");
        return goalline;
    }
}