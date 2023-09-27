using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------HELLO WORLD!-----------");
        
        //Esto es una instancia.
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;

        //Esto tambien es una instancia.   
        Job job2 = new Job();
        job2._jobTitle = "JAVA Programmer";
        job2._company = "Mojang";
        job2._startYear = 2020;
        job2._endYear = 2023;
        
        //Esta tambien es una instancia.
        Resume resume = new Resume();
        resume._name = "Allison Rose";
        
        //Aqui usamos este comando para agregar los trabajos que creamos a la lita "Job".
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        //Finalmente llamamos al metodo ShowResume juntlo a la instancia resume para crear un objeto que se llama "Resume" 
        resume.ShowResume();
    }
}

