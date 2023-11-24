using System;

class Program
{
    static void Main(string[] args)
    {
       HourlyEmployee h1 = new HourlyEmployee("Rubí", "0415hfr", "Ancon, Fenix City", "04-08-2006", 15, 35);

       SalaryEmployee e1 = new SalaryEmployee("Josh", "0503joso", "Ancon, Central Ward", "05-03-2010", 60000);

       DisplayEmployeeInfo(h1);
       DisplayEmployeeInfo(e1);

       
    }

    public static void DisplayEmployeeInfo(Employee employee)
    {
        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
    }

}