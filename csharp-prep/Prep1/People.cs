using System;
public class People
{
    private string _name;

    public People(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}