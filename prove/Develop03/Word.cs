using System.Runtime.CompilerServices;
public class WordModder
{
private string scriptureModified = "";
    public WordModder(string entry)
    {
    string[] words = entry.Split(' ');
    int topValue = words.Count();
    Random rnd = new Random();
    int num = rnd.Next(0, topValue);
    int letterCount = words[num].Length;
    string blankLine = "";
        for (int i=0; i<letterCount; i++){
            blankLine+="_";
        }

words[num] = blankLine;
foreach (string word in words)
{
    scriptureModified += $"{word} ";
}
    }
    public string moddedScripture()
{
    return scriptureModified;
}
}
    // each time called, take as input the string, break it into an aray and then count the words.
    // Pass the earlier count, select a random number from 1-count.
    // take the entered scripture string and the random number, selest the word at the count of the random number, replace all the letters in it with '_'
    // Return modified string.
