using System.Drawing;

public class PictureBook : Book
{
    private string _illustrator;

    public PictureBook(string title, string author, string illustrator) : base(title, author)
    {
        _illustrator = illustrator;
    }

    public string GetIllustrator()
    {
        string illustrator = _illustrator;
        return illustrator;
    }

    public string GetBookInfo()
    {
        string title = GetTitle();
        string author = GetAuthor();

        return "Title: " + title + ", Author: " + author + ", Illustrator: " + _illustrator;
    }
}