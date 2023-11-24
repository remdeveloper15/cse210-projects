using System.Dynamic;

public class Employee
{
    private string _name;
    private string _id;
    private string _address;
    private string _birthday;

    public Employee(string name, string id, string address, string birhtday)
    {
        _name = name;
        _id = id;
        _address = address;
        _birthday = birhtday;
    }

    public string GetName()
    {
        return _name;
    }
    
    public string GetID()
    {
        return _id;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetBirthtday()
    {
        return _birthday;
    }

    public void GetEmployee()
    {
        string employee = "Employee: " + _name + " " + _id + " " + _address + " " + _birthday;
        Console.WriteLine(employee);
    }

    public virtual float GetPay()
    {
        return -1;
    }
}