public class MenuLoop
{
    public void Run()
    {    
        //handles interface and keeps the program running in a loop
        Journal journal=new Journal();
        Menu menu=new Menu();
        while (true){
            Console.WriteLine("Enter 1 to make an entry, 2 to read old entrys, or 3 to close program. 4 to store entry to a file.");
            string UserEntry=Console.ReadLine();
            if (UserEntry=="1"){
                Entry entryToStore=menu.MakeEntry();
                journal.AppendEntry(entryToStore);
                //menu.FileStore();
            }
            else if (UserEntry=="2"){
                menu.FileRead();
            }
            else if (UserEntry=="3"){
                Console.WriteLine("Ending program. Goodbye!");
                break;
            }
            else if (UserEntry=="4"){
                menu.FileStore(journal);
            }
        }
    }
}