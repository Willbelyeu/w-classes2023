using Microsoft.Win32.SafeHandles;

public class Menu
{
    public void FileStore(Journal journal)
    {
        {
            Console.WriteLine($"What is the file you wish to write to?");
            string FileToStore = Console.ReadLine();
            File.WriteAllText(FileToStore, journal.SendToJournal());
        }
    }
    public Entry MakeEntry()
        {        
        List<string> prompts = new List<string>();
        prompts.Add("How was your day?");
        prompts.Add("Who was the most intersting person you talked to today?");
        prompts.Add("How was work today?");
        prompts.Add("What do you wish you had done differently?");
        prompts.Add("What did you learn today?");
        prompts.Add("How are you doing right now?");

        Random rnd = new Random();
        int num = rnd.Next(0, 5);
        Console.WriteLine($"{prompts[num]}");
        string userEntry = Console.ReadLine();
        string date = DateTime.Now.ToString();
        Entry entry=new Entry(prompts[num], date, userEntry);
        return entry;
        }


public void FileRead()
{
    Console.WriteLine(" ");
    try
    {
        Console.WriteLine("What file do you want to read?");
        string openedFile = Console.ReadLine();
        //Pass the file path and file name to the StreamReader constructor
        StreamReader sr = new StreamReader(openedFile);
        //Read the first line of text
        string line = sr.ReadLine();
        //Continue to read until you reach end of file
        while (line != null)
        {
            //write the line to console window
            Console.WriteLine(line);
            //Read the next line
            line = sr.ReadLine();
        }
        //close the file
        sr.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
}
}