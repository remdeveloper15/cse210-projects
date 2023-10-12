using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Welcome to you journet program!-----");
        
        string opcion = "";
        string entry;
        Prompt _propuesta = new Prompt(); 
        Diario _diario = new Diario();

        while (opcion != "5")
        {
            Console.WriteLine("Please enter one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Enter you option: ");
            
            opcion = Console.ReadLine();
            


        if (opcion == "1")
        {
            string propuesta = _propuesta.PromptGenerator();
            Console.WriteLine(propuesta);
            DateTime theCurrentTime = DateTime.Now;
            string _date = theCurrentTime.ToShortDateString();
            entry = Console.ReadLine();

            _diario.CreateEntry(_date, propuesta, entry);          
        }

        else if (opcion == "2")
        {
            _diario.DisplayEntry();
        }

        else if (opcion == "3")
        {
            Console.WriteLine("Ingrese el nombre que quiere asignarle al archivo: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Saving to File...");
            _diario.SaveFile(fileName);
            Console.WriteLine("Information was saved succesfully.");
        }

        else if (opcion == "4")
        {
            Console.WriteLine("Ingrese el nombre del archivo que quierer cargar: ");
            string fileName = Console.ReadLine();
            if (File.Exists(fileName)
            )
            {
            _diario.LoadFile(fileName);
            Console.WriteLine("The file have been loaded successfully");
            }

            else
            {
                Console.WriteLine("The file that you're trying to load doesn't exist.");                
            }
        }

        }   

        List<Entry> _entries = new List<Entry>();
    } 
}


