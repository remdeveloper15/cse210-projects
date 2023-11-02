public class Book
{
    private string _title;
    private string _author;

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
    }

    public string GetTitle()
    {
        string title = _title;
        return title;
    }

    public string GetAuthor()
    {
        string author = _author;
        return author;
    }
}