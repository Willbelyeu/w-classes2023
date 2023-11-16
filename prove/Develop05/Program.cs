using System;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Menu
{
    static void Main(string[] args)
    {
        List <string> goalList=new List<string>();
        while (true){
            //display current points.
            Console.WriteLine($"Menu options:");
            Console.WriteLine($"1 create new goal");
            Console.WriteLine($"2 list goals");
            Console.WriteLine($"3 save goals");
            Console.WriteLine($"4 load goals");
            Console.WriteLine($"5 record event");
            Console.WriteLine($"6 quit");
            Console.WriteLine($"To select what you want to do enter the number that begins the line that names what you want to do.");
            string selection=Console.ReadLine();
            if (selection=="1"){
                Console.WriteLine("enter a number to choose which kind of goal you wish to enter.");
                Console.WriteLine("Goal types:");
                Console.WriteLine("1 eternal");
                Console.WriteLine("2 checklist");
                Console.WriteLine("3 normal");
                string goaltype=Console.ReadLine();
                if (goaltype=="1"){
                    //call eternal newgoal
                    Eternal eternal=new Eternal();
                    string newgoal=eternal.NewGoal();
                    goalList.Add(newgoal);
                }
                else if (goaltype=="2"){
                    Checklist checklist=new Checklist();
                    string newgoal=checklist.NewGoal();
                    goalList.Add(newgoal);
                }
                else if (goaltype=="3"){
                    //call normal newgoal
                    Normal normal=new Normal();
                    string newgoal=normal.NewGoal();
                    goalList.Add(newgoal);
                }
            }
            else if (selection=="2"){
                //call method to list your current goals. They should be in three seperate lists each called seperatly so you know what type they are. 
                //Belay that. The type is the first word of the goal string.
                foreach (string goal in goalList){
                        //string goalline2=($"{goaltype}--{goalname}--{goaldiscription}--{points-per-completion}--{finalpoints}--{timescompleted}/{completions-needed}");
                        var stringArray=goal.Split("--");
                        int timesCompleted=(Convert.ToInt32(stringArray[5]));
                        int completionsNeeded=(Convert.ToInt32(stringArray[6]));
                        if (timesCompleted>=completionsNeeded){
                        Console.WriteLine($"{stringArray[0]} goal, {stringArray[1]}. {stringArray[2]}. {stringArray[5]}/{stringArray[6]}. Goal complete.");
                        }
                        else if (timesCompleted<completionsNeeded){
                        Console.WriteLine($"{stringArray[0]} goal, {stringArray[1]}. {stringArray[2]}. {stringArray[5]}/{stringArray[6]}. Goal not complete.");
                        }
                }
            }
            else if (selection=="3"){
                //call method to save modfications to your goals.
                Console.WriteLine("What is the name of the file you wish to save? sample filename, goals.txt.");
                string fileName=Console.ReadLine();
                foreach (string goal in goalList){
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                    // You can use the $ and include variables just like with Console.WriteLine
                        outputFile.WriteLine($"{goal}");
                    }
                }
            }
            else if (selection=="4"){
                //call method to Load your goals.
                Console.WriteLine("What is the name of the file you wish to load?");
                string filename=Console.ReadLine();
                //Load the file and read it by line into the goallist.
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines){
                    goalList.Add(line);
            }
            }
            else if (selection=="5"){
                // Records if you acted on a goal. 
                Console.WriteLine("Which goal did you work on? Input a number.");
                string goalnumberstring=Console.ReadLine();
                int goalnumber=Convert.ToInt32(goalnumberstring);
                string goalCompleted=goalList[goalnumber];
                var stringArray=goalCompleted.Split("--");
                string goaltype=stringArray[0];
                if (goaltype=="Eternal"){
                    //call eternal newgoal
                    Eternal eternal=new Eternal();
                    string completed=eternal.Completed();
                    goalList[goalnumber]=completed;
                }
                else if (goaltype=="Checklist"){
                    Checklist checklist=new Checklist();
                    string completed=checklist.Completed();
                    goalList[goalnumber]=completed;
                }
                else if (goaltype=="Normal"){
                    Normal normal=new Normal();
                    string completed=normal.Completed();
                    goalList[goalnumber]=completed;
                // 
            }
            else if (selection=="6"){
                Console.WriteLine("Closing program.");
                break;
            }
        }
    }
}
}