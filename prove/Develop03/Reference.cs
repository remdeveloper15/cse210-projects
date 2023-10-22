using System.Dynamic;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endverse;

    public Reference(string book, string chapter, string verse, string endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;        
    }

    public string GetReference()
    {
        string reference = _book + " " + _chapter + ":" + _verse + "-" + _endverse;

        return reference;
    }

}