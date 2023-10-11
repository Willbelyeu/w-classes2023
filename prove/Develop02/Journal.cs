public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public void AppendEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public string SendToJournal()
    {
        string compiledEntry = "";
        foreach (Entry entry in entries)
        {
            string entryString = ($"{entry.userEntry} {entry.prompt} {entry.date}");
            compiledEntry += entryString;
        }
        return compiledEntry;
    }
}
