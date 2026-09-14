using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }


public void DisplayAll()
{
    foreach (Entry entry in _entries)
    {
        entry.Display();
    }

}

public void SaveToFile(string filename)
{
    using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (Entry entry in _entries)
        {
            writer.WriteLine($"{entry.GetDate()}|{entry.GetPromptText()}|{entry.GetEntryText()}");
        }
    }


}

public void LoadFromFile(String filename)
    {
        _entries= new List<Entry>();
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            
            
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];
                Entry entry = new Entry(date, promptText, entryText);
                _entries.Add(entry);
            
        }
    }

}

