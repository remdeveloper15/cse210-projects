using System;

class Program
{
    static void Main(string[] args)
    {
        Franction f1 = new Franction();
        Console.WriteLine(f1.GetFranctionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        Franction f2 = new Franction(5);
        Console.WriteLine(f2.GetFranctionString());
        Console.WriteLine(f2.GetDecimalValue());

        Franction f3 = new Franction(3, 4);
        Console.WriteLine(f3.GetFranctionString());
        Console.WriteLine(f3.GetDecimalValue());

        Franction f4 = new Franction(1, 3);
        Console.WriteLine(f4.GetFranctionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}