using System.Security.Cryptography.X509Certificates;

class Goal{
    protected string goalname="goalname";
    protected string goaldiscription="";
    protected string goalline="";
    protected int _points=0;
    public virtual void DisplayGoal(){
        //This will show a goal. Probably needs something passed to it. No, but just display one goal? Not the whole list? Right, they're in their own
        //file, so they will be loaded. So this just displays what I'm currently working on? Like what is the point of displaying the goal if there is only one?
    }
    public virtual int Completed(int timescompleted, int completionsNeeded){
        //string goalline2=($"{goaltype}--{goalname}--{goaldiscription}--{points-per-completion}--{finalpoints}--{timescompleted}/{completions-needed}");                
        if (timescompleted>=completionsNeeded){
            //do nothing
        }
        else if (timescompleted<completionsNeeded){
            //increase timescompleted by 1.
            //if timescompleted now equils completionsneeded return the second ammount for points.
            //otherwise, return the first ammount and the new completionsneeded.
        }
        // When called it will add one to a goal if the goal isn't finished.
        // If the goal was for a set number, such as x/3, once it reaches max such as 3/3 it will return more than normal.
    }
    public virtual string NewGoal(){
        Console.WriteLine("What is the name of your goal?");
        goalname=Console.ReadLine();
        Console.WriteLine("What is a short discription of it?");
        goaldiscription=Console.ReadLine();
        Console.WriteLine("How many points is it worth?");
        _points=Convert.ToInt32(Console.ReadLine());
        string goalline=($"--{goalname}--{goaldiscription}--0--{_points}--0--/--1");
        return goalline;

    }
}