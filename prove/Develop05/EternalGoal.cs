public class EternalGoal : Goal
{
    public EternalGoal(string type, string typeDescription) : base(type, typeDescription)
    {
    }

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetGoalIndicator()
    {
        string goalIndicator = _name  + " " + "(" + _description + ")";
        return goalIndicator;
    }
}