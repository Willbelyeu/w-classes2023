using System;

class Menu
{
    static void Main(string[] args)
    {
        while (true){
            Console.WriteLine("To reflection, press 1. To List, press 2. For breathing, press 3. To close press 4.");
            string activityNext=Console.ReadLine();
            Console.WriteLine("How long in seconds will you do this activity?");
            var duration=int.Parse(Console.ReadLine());
            DateTime startTime = DateTime.Now;        
            if (activityNext=="1"){
                Console.Clear();
                Reflection reflection=new Reflection("Reflection", duration);
                reflection.ReflectionProcess();
                reflection.DisplayAchievement();
            }
            else if (activityNext=="2"){
                Console.Clear();
                ListingActivity listing=new ListingActivity("Listing Activity", duration);
                listing.ListingProcess();
                listing.DisplayAchievement();
            }
            else if (activityNext=="3"){
                Console.Clear();
                Breathing Runthrough=new Breathing("Breathing Activity", duration);
                Runthrough.DisplayAchievement();
            }
            else if (activityNext=="4"){
                Console.Clear();
                Console.WriteLine("closing the program.");
                break;
            }
            else{
                Console.Clear();
                Console.WriteLine("That wasn't an option.");
            }
        }
    }
}