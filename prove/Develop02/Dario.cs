using System;
using System.IO;
using Microsoft.VisualBasic;
public class Diario
{
    List<Entry> entries;
    public Diario()
    {
        entries = new List<Entry>();
    }
    
    public void CreateEntry(string date, string prompt, string entry)
    {
        entries.Add(new Entry(date, prompt, entry));
    }

    public void DisplayEntry()
    {
        foreach (Entry e in entries)
        {
            e.DisplayInfo();
        }
    }

    public void SaveFile(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"Date: {entry._date}, Prompt: {entry._prompt}, Entry: {entry._entry}");
            }

        }   
    }

    public void LoadFile(string fileName)
    {
        string [] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string [] parts = line.Split(",");

            string fileDate = parts[0];
            string filePrompt = parts[1];
            string fileEntry = parts [2];
            entries.Add(new Entry(fileDate, filePrompt, fileEntry));
        }
    }
}