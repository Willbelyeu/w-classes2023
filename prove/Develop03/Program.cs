using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press enter when ready to begin.");
        Console.ReadLine();
        // call the scriptures list from Scripture and name it scriptures.
        Scriptures scriptures=new Scriptures();
        // call the references list from Reference and name it references.
        References references=new References();
        int topValue=scriptures.scriptures.Count;
        Random rnd = new Random();
        int num = rnd.Next(0, topValue);
        string currentScripture=scriptures.getScripture()[num];
        string currentReference=references.getReferences()[num];
        // Use the random number 'rnd' to select the matching reference from references. reference[rnd]=currentReference

        while (true){
            // Pass the string currentScripture to Word. Store the result back to the name currentScripture.
            WordModder word=new WordModder(currentScripture);   
            currentScripture=word.moddedScripture();
            Console.WriteLine($"{currentReference}");
            Console.WriteLine($"{currentScripture}");
            // Console.WriteLine($"{currentScripture}");
            Console.WriteLine("To end program enter 'quit', to continue hit enter.");
            string Continue = Console.ReadLine();
            if (Continue=="quit"){
                break;
            }
            else {
                Console.Clear();                          
            }
        }
    }
}