using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Please enter your grade: ");
string grade = Console.ReadLine();
int number = int.Parse(grade);

if (number >= 90)
{
    Console.WriteLine("Your grade in letters is A");
}

else if (number >= 80)
{
    Console.WriteLine("Your grade in letters is B");
}

else if (number >= 70)
{
    Console.WriteLine("Your grade in letters is C");
}

else if (number >= 60)
{
    Console.WriteLine("Your grade in letters is D");
}

else
{
    Console.WriteLine("Your grade in letters is F");
}

if (number >= 70)
{
    Console.WriteLine("Congratulations! You have passed! :D");
}

else
{
    Console.WriteLine("Sorry! You didn't get it D;");
}
    }
}