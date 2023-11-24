public class SimpleGoal : Goal
{
    public SimpleGoal(string type, string typeDescription) : base(type, typeDescription)
    {
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public override string GetGoalIndicator()
    {
        string goalIndicator = _name  + " " + "(" + _description + ")";
        return goalIndicator;
    }

    public override int GetGoalPuntation()
    {
        return 4;
    }


}