/*
Journal - Class Name
Attributes - Variables
- _entries: List<Entry>

Behaviors - Methods or Functions
- Display(): void
- SaveToFile(filename: string): void
- LoadFromFile(filename: string): List<Entry>
- AddEntry(newEntry : Entry): void (Use add. to append entry to list)
*/

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename + ".csv"))
        {
            foreach (Entry entry in _entries)
            {
                string csvLine = $"\"{entry._date}\",\"{entry._prompt}\",\"{entry._response}\"";
                outputFile.WriteLine(csvLine);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename + ".csv");

        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "\",\"" }, StringSplitOptions.None);
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim('\"');
            }
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
            
        }
    }
}