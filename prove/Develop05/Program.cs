using System;
using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Menu
{
    static void Main(string[] args)
    {
        List <string> goalList=new List<string>();
        int score=0;
        string emptySampleString=("Eternal--Paternal--External--0--0--0--0");
            var stringArray=emptySampleString.Split("--");
            string goalType=stringArray[0];
            string goalName=stringArray[1];
            string goalDiscription=stringArray[2];
            int pointsPerCompletion=Convert.ToInt32(stringArray[3]);
            int finalPoints=Convert.ToInt32(stringArray[4]);
            int timesCompleted=Convert.ToInt32(stringArray[5]);
            int completionsNeeded=Convert.ToInt32(stringArray[6]);
        while (true){
            Console.WriteLine($"Your score is {score}");
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
                    Eternal eternal=new Eternal(emptySampleString);
                    string newgoal=eternal.NewGoal();
                    goalList.Add(newgoal);
                }
                else if (goaltype=="2"){
                    Checklist checklist=new Checklist(emptySampleString);
                    string newgoal=checklist.NewGoal();
                    goalList.Add(newgoal);
                }
                else if (goaltype=="3"){
                    //call normal newgoal
                    Normal normal=new Normal(emptySampleString);
                    string newgoal=normal.NewGoal();
                    goalList.Add(newgoal);
                }
            }
            else if (selection=="2"){
                //call method to list your current goals. They should be in three seperate lists each called seperatly so you know what type they are. 
                //Belay that. The type is the first word of the goal string.
                int listCounter=0;
                foreach (string goal in goalList){
                        var stringArray=goal.Split("--");
                        string classCalled=stringArray[0];
                        Console.Write(listCounter+"-");
                        listCounter+=1;
                        if (classCalled=="Eternal"){
                            Eternal eternal=new Eternal(goal);
                            eternal.DisplayGoal();
                        }
                        else if (classCalled=="Checklist"){
                            Checklist checklist=new Checklist(goal);
                            checklist.DisplayGoal();
                        }
                        else if (classCalled=="Normal"){
                            Normal normal=new Normal(goal);
                            normal.DisplayGoal();
                        }
                }
            }
            else if (selection=="3"){
                //call method to save modfications to your goals.
                Console.WriteLine("What is the name of the file you wish to save? sample filename, goals.txt.");
                string fileName=Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine($"{score}");                            
                    }
                foreach (string goal in goalList){
                    using (StreamWriter outputFile = new StreamWriter(fileName, true))
                    {
                        outputFile.WriteLine($"{goal}");                            
                    }
                } 
            }
            else if (selection=="4"){
                //call method to Load your goals.
                Console.WriteLine("What is the name of the file you wish to load?");
                string filename=Console.ReadLine();
                //Load the file and read it by line into the goallist.
                bool skipLine=true;
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines){
                    if (skipLine){
                        score=Convert.ToInt32(line);
                        skipLine=false;
                    }
                    else{
                        goalList.Add(line);
                    }
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
                int completed=0;
                if (goaltype=="Eternal"){
                    //call eternal newgoal
                    Eternal eternal=new Eternal(goalCompleted);
                    completed=eternal.Completed();
                    score+=completed;
                    //find out how to replace the line in the goalList, but otherwise this is great.
                    //ask the tutors about that one. Other than that it looks fine.
                }
                else if (goaltype=="Checklist"){
                    Checklist checklist=new Checklist(goalCompleted);
                    completed=checklist.Completed();
                    score+=completed;
                    //find out how to replace the line in the goalList, but otherwise this is great.
                }
                else if (goaltype=="Normal"){
                    Normal normal=new Normal(goalCompleted);
                    completed=normal.Completed();
                    score+=completed;
                }
                    //find out how to replace the line in the goalList, but otherwise this is great.
                if (completed!=0){
                    //timesCompleted is stringArray[5]
                    int timesCompleted=Convert.ToInt32(stringArray[5]);
                    timesCompleted+=1;
                    string updatedString=($"{stringArray[0]}--{stringArray[1]}--{stringArray[2]}--{Convert.ToInt32(stringArray[3])}--{Convert.ToInt32(stringArray[4])}--{timesCompleted}--{Convert.ToInt32(stringArray[6])}");
                    goalList[goalnumber]=updatedString;
                }
                //
            }
            else if (selection=="6"){
                Console.WriteLine("Closing program.");
                break;
            }
        }
    }
}