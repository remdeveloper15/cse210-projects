using System;

class Program
{
    static void Main(string[] args)
    {
        Student _student = new Student("Rubi", "04062006");
        string name = _student.GetName();
        string number = _student.GetNumber();
        Console.WriteLine(name);
        Console.WriteLine(number);
        Console.WriteLine(_student.GetInfo());

        PictureBook _book = new PictureBook("Tokyo Ghoul :re", "Sui Ishida", "Ken Kaneki");
        Console.WriteLine(_book.GetBookInfo());
    }
}
