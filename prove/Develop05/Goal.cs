class Goal{
    public virtual void DisplayGoal(){
        //This will show a goal. Probably needs something passed to it. No, but just display one goal? Not the whole list? Right, they're in their own
        //file, so they will be loaded. So this just displays what I'm currently working on? Like what is the point of displaying the goal if there is only one?
    }
    public virtual void Completed(){
        //This will display status complete once a goal is achieved.
        // If the goal was for a set number, such as /3, once it reaches that it will return more than normal.
    }
    public virtual void NewGoal(){
        Console.WriteLine("What is the name of your goal?");
        string goalname=Console.ReadLine();
        Console.WriteLine("What is a short discription of it?");
        string goaldiscription=Console.ReadLine();
        Console.WriteLine("How many points is it worth?");
        string goalline=($"{goalname}, {goaldiscription}");
    }
}