public class Goal
{
    protected string _type;
    protected string _typeDescription;
    protected string _name;
    protected string _description;
    protected int _points; 

    public Goal(string type, string typeDescription)
    {
        _type = type;
        _typeDescription = typeDescription;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal()
    {
    }
    public void GetGoalsSelector()
    {
        Console.WriteLine("");
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goals");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    public string GetTypeG()
    {
        return _type;
    }
    public string GetTypeDescription()
    {
        return _typeDescription;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetGoalIndicator()
    {
        return "";
    }

    public virtual int GetGoalPuntation()
    {
        return 0;
    }
}