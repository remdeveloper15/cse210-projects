using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        while(answer != "quit")
        {
        Reference _reference = new Reference("Poverbs", "3", "5", "6");
        string stringReference = _reference.GetReference();
        Scripture _text = new Scripture("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths.");

        string _stringText = _text.GetText();
        Scripture _scripture = new Scripture(stringReference, _stringText);

        Console.WriteLine(_scripture.GetScripture());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        answer = Console.ReadLine();
        
        
        }

        
    }
}