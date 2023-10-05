using Microsoft.Win32.SafeHandles;

public class Menu
{
    public void FileStore()
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
        string entry = Console.ReadLine();
        string date = DateTime.Now.ToString();
        Console.WriteLine("Save? press 1 for yes, or 2 for no.");
        string save = Console.ReadLine();
        if (save == "1")
        {
            Console.WriteLine($"What is the file you wish to write to?");
            string FileToStore = Console.ReadLine();
            string TextToStore = ($"{date} {prompts[num]} {entry}");
            File.WriteAllText(FileToStore, TextToStore);
        }
    }

public void FileRead()
{
    Console.WriteLine(" ");
    try
    {
        Console.WriteLine("What file do you want to read?");
        string openedFile = Console.ReadLine();
        //Pass the file path and file name to the StreamReader constructor
        StreamReader sr = new StreamReader("journal.txt");
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