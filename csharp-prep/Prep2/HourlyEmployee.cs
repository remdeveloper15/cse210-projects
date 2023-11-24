public class HourlyEmployee : Employee
{
    private float _hourlyPayRate;
    private float _hourlyWorked;

    public HourlyEmployee(string name, string id, string address, string birhtday, float hourlyPayRate, float hourlyWorked) : base(name, id, address, birhtday)
    {
        _hourlyPayRate = hourlyPayRate;
        _hourlyWorked = hourlyWorked;
    }

    public float GetPayRate()
    {
        return _hourlyPayRate;
    }

    public float GetHourlyWorked()
    {
        return _hourlyWorked;
    }

    public override float GetPay()
    {
        return _hourlyWorked * _hourlyPayRate;
    }


}