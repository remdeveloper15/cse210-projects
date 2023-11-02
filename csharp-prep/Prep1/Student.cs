using System;
public class Student : People
{
    private string _number;

    public Student(string name, string number) : base(name)
    {
        _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }

    public string GetInfo()
    {
        string _name = GetName();
        return _name + " " + _number;
    }

    

}