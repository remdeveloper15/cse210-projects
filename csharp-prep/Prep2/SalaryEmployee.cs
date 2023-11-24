public class SalaryEmployee : Employee
{
    private float _annualSalary;

    public SalaryEmployee(string name, string id, string address, string birhtday, float annualSalary) : base(name, id, address, birhtday)
    {
        _annualSalary = annualSalary;
    }

    public override float GetPay()
    {
        return _annualSalary / 12;
    }
}