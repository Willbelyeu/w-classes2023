using System.Runtime.CompilerServices;

class Eternal:Goal{
    private List <string> eternal=new List<string>();
    public Eternal(string savedFile):base(savedFile){
        //nothing should be needed
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_goalType} goal, {_goalName}. {_goalDiscription}");
    }

    public override int Completed()
    {
        _timesCompleted+=1;
        return _pointsPerCompletion;
        //this while then be += to points, a int in Program.
    }
    public override string NewGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        _goalName=Console.ReadLine();
        Console.WriteLine("What is a short discription of it?");
        _goalDiscription=Console.ReadLine();
        Console.WriteLine("How many points is it worth?");
        _pointsPerCompletion=Convert.ToInt32(Console.ReadLine());
        string _goalLine=($"Eternal--{_goalName}--{_goalDiscription}--{_pointsPerCompletion}--0--0--0");
        return _goalLine;
        //string goalline2=($"{goaltype}--{goalname}--{goaldiscription}--{points-per-completion}--{finalpoints}--{timescompleted}/{completions-needed}");
    }
}