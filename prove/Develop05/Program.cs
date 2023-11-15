using System;
using System.Security.Cryptography.X509Certificates;

class Menu
{
    static void Main(string[] args)
    {
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
                // Just ask a 1 2 3 simple eternal or checklist, then pass it to the class by that name.
                Console.WriteLine("enter a number to choose which kind of goal you wish to enter.");
                Console.WriteLine("Goal types:");
                Console.WriteLine("1 eternal");
                Console.WriteLine("2 checklist");
                Console.WriteLine("3 normal");
                string goaltype=Console.ReadLine();
                //if else if statments calling the relivant class.
            }
            else if (selection=="2"){
                //call method to list your current goals. They should be in three seperate lists each called seperatly so you know what type they are.
                //Each should be displayed in format "{goaltype} {goalname} {number of times completed}"
            }
            else if (selection=="3"){
                //call method to save modfications to your goals.
                //I think this needs to call the earlier lists to check what has been changed and make new files for the names entered, or overwrite the old ones with the changes made.
                //Change of understanding. The goals are all in one file, which is named here. I will need a list to keep them in that holds them in a string that can be seperated. For example,
                //"{goaltype}--{goalname}--{goaldiscription}--{points-per-completion}--{timescompleted}". Once in that format they will need to be read in by line into the goal file.
            }
            else if (selection=="4"){
                //call method to Load your goals.
                Console.WriteLine("What is the name of the file you wish to load?");
                string filename=Console.ReadLine();
                //Load the file and read it by line into the goallist.
            }
            else if (selection=="5"){
                //call method to record an event. What kind? Completion of a goal?
                // Records if you acted on a goal. 
                Console.WriteLine("Which goal did you work on? Input a number.");
                string goalnumber=Console.ReadLine();
                //takes goalnumber and calls goallist[goalnumber], calls the 5th entry, +=1 to it.
                //displays "congradulations! You gained {points-per-completion} points!"
            }
            else if (selection=="6"){
                Console.WriteLine("Closing program.");
                break;
            }
        }
    }
}