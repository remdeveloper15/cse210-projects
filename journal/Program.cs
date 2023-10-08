using System;
using System.Formats.Asn1;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        
        
           
        string response = "";
        Console.WriteLine("");
        Console.WriteLine("WELCOME TO THE JOURNEY PROGRAM!");

        while (response != "5")
        {
             Console.WriteLine("Please select one of the following choices: ");
             Console.WriteLine("1. Write");
             Console.WriteLine("2. Display");
             Console.WriteLine("3. Load");
             Console.WriteLine("4. Save");
             Console.WriteLine("5. Quit");
             Console.Write("What you would like to do? ");
             response = Console.ReadLine()!;
             
             
        if (response == "1")
        {
            prompt.PromptGenerator();
            string answer = Console.ReadLine()!;  
        }

        if (response == "2")
        {

        }
            
        }
    
    }

}