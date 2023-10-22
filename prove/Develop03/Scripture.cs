public class Scripture
{
    private string _reference;
    private string _text;
    private List<Word> _words = new List<Word>();


    
    public Scripture(string text)
    {
        _text = text;

        string [] words = _text.Split(" ");
        foreach (string stringWord in words)
        {
            _words.Add( new Word(stringWord));
        }
        
    }

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public string GetText()
    {
        string text = _text;

        return text;
    }
    
    public string GetScripture()
    {
        string scripture = _reference + ": " + _text;
        
        return scripture;
    }

    public void HideWords()
    {
        Console.Clear();
    }

}