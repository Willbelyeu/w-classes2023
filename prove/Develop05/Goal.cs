using System.Security.Cryptography.X509Certificates;

class Goal{
    protected string _goalType; 
    protected string _goalName;
    protected string _goalDiscription;
    protected int _pointsPerCompletion;
    protected int _finalPoints;
    protected int _timesCompleted;
    protected int _completionsNeeded;
    protected string _goalLine;
    public Goal(string savedFile){
                var stringArray=savedFile.Split("--");
                _goalType=stringArray[0];
                _goalName=stringArray[1];
                _goalDiscription=stringArray[2];
                _pointsPerCompletion=Convert.ToInt32(stringArray[3]);
                _finalPoints=Convert.ToInt32(stringArray[4]);
                _timesCompleted=Convert.ToInt32(stringArray[5]);
                _completionsNeeded=Convert.ToInt32(stringArray[6]);
    }            
    public virtual void DisplayGoal(){
        //This will show a goal. Probably needs something passed to it. No, but just display one goal? Not the whole list? Right, they're in their own
        //file, so they will be loaded. So this just displays what I'm currently working on? Like what is the point of displaying the goal if there is only one?
        Console.WriteLine($"{_goalType} goal, {_goalName}. {_goalDiscription}");
    }

    public virtual int Completed(){
        {
            return _pointsPerCompletion;
        }
    }
    
    public virtual string NewGoal(){
        Console.WriteLine("What is the name of your goal?");
        _goalName=Console.ReadLine();
        Console.WriteLine("What is a short discription of it?");
        _goalDiscription=Console.ReadLine();
        Console.WriteLine("How many points is it worth?");
        _pointsPerCompletion=Convert.ToInt32(Console.ReadLine());
        string _goalLine=($"blank--{_goalName}--{_goalDiscription}--0--{_pointsPerCompletion}--0--0");
        return _goalLine;

    }
}