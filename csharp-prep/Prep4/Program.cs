using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Excélsior");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
            
        int number_list = -1;
        int sum = 0;
        float average = 0;
        int max = 0;
        int smallest = 99999999;
        while (number_list != 0)
        {
            
            Console.Write("Enter number: ");
            string user_number = Console.ReadLine();
            number_list = int.Parse(user_number);
            
            if (number_list != 0)
            {
                numbers.Add(number_list);    
            }
            
            int numbers_count = numbers.Count;
            sum += number_list;
            average = ((float)sum) / numbers_count;

            if (number_list > max)
            {
                max = number_list;
            }

            if (number_list < smallest)
            {
                smallest = number_list;
            }
        }

        Console.WriteLine("The average is: "); 
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The list is: ");

        foreach (int number in numbers)
        { 
            Console.WriteLine(number);
        }
    }
}