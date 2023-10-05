public class menuLoop
{
    public void MenuLoop()
    {    
        //handles interface and keeps the program running in a loop
        bool menu = true;
        while (menu==true){
            Console.WriteLine("Enter 1 to make an entry, 2 to read old entrys, or 3 to close program.");
            string UserEntry=Console.ReadLine();
            if (UserEntry=="1"){
                Menu runThrough=new Menu();
                runThrough.FileStore();
            }
            else if (UserEntry=="2"){
                Menu runThrough=new Menu();
                runThrough.FileRead();
            }
            else if (UserEntry=="3"){
                menu=false;
                Console.WriteLine("Ending program. Goodbye!");
            }
        }
    }
}