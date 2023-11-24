using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

public class CheckListGoal : Goal
{
    private int _times;
    private int _bonus;
    public CheckListGoal(string type, string typeDescription) : base(type, typeDescription)
    {
    }

    public CheckListGoal(string name, string description, int points, int times, int bonus) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _times = times;
        _bonus = bonus;
    }

    public int GetTimes()
    {
        return _times;
    }
    public override string GetGoalIndicator()
    {
        string goalIndicator = _name + " " + "(" + _description + ")" + " " + "--- Currently complete 0/" + _times;
        return goalIndicator;
    }
}