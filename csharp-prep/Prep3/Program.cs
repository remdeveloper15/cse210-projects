using System;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Bueno la estructuctura para un while es: "while" seguido de unos parentesis "()", y dentro de los mismos la declaracion que queremos hacer en el bucle. Luego de eso se abren corchetes "{}", y dentro de los mismos se pone la entreda y su respuesta. */

        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Do you wanto to continue? ");
            response = Console.ReadLine();
        }

        string respuesta = "no";
        while ( respuesta != "si")
        {
            Console.Write("Quieres seguir conmigo? ");
            respuesta = Console.ReadLine();
        }
        {
        
        if (respuesta == "si")
        {
            Console.WriteLine("Happy Happy Happy!! ");
        }

        string eleccion = "pollo";
        do 
        {
            Console.Write("pollo o carne? ");
            eleccion = Console.ReadLine();
        } while (eleccion != "carne");

        }

        Console.WriteLine("");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

         for (int i = 2; i <= 20; i = i + 2)
        {
            Console.WriteLine(i);
        }

        // ASIGNMENT */

        string play_again = "yes";
        while (play_again == "yes")
        {

        Console.WriteLine("Which will be the magic number...? ");
        Random randomGenerator = new Random ();
        int magic_number = randomGenerator.Next(1,100);
        int number_1 = 0;
        int guess_count = 0;
        

        while(magic_number != number_1)
        {
            Console.WriteLine("What is you guess? ");
            string text = Console.ReadLine();
            number_1 = int.Parse(text);
            guess_count = guess_count + 1;

            if (number_1 > magic_number)
            {
                Console.WriteLine("Lower");
            }

            else if (number_1 < magic_number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it! ");
                Console.WriteLine($"You have finished with a total of {guess_count} guesses");
                Console.WriteLine("Do you want to play again, yes or no? ");
                play_again = Console.ReadLine();
            }
        }
        }
    }
}

