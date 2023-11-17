using System.Runtime.CompilerServices;

class Checklist:Goal{
    private List <string> checklist=new List<string>();
    public Checklist(string savedFile):base(savedFile){
        //nothing should be needed
    }    
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_goalType} goal, {_goalName}. {_goalDiscription} {_timesCompleted}/{_completionsNeeded}");
    }

    public override int Completed(){
        if (_pointsPerCompletion==_completionsNeeded){
            _timesCompleted+=0;
            return 0;
        }
        else if (_pointsPerCompletion+1==_completionsNeeded){
            _timesCompleted+=1;
            return _finalPoints;
        }
        else{
            _timesCompleted+=1;
            return _pointsPerCompletion;
        }
    }
    //Checklist is a goal that can be done a few times, so It needs to check if the goal is already complete, then if not add +1 to the count.
    //If the goal has been done the number of times it can be, it should give the bonus level points rather than the normal points. This should-
    //-be doable through if else if statements.
    public override string NewGoal()
    {
        base.NewGoal();
        Console.WriteLine("How many times do you wish to do this goal?");
        string completionsneeded=Console.ReadLine();
        Console.WriteLine("How many points will completion be worth?");
        string finalpoints=Console.ReadLine();
        _goalLine=($"Checklist--{_goalName}--{_goalDiscription}--{_pointsPerCompletion}--{finalpoints}--0--{completionsneeded}");
        return _goalLine;
    }
}
