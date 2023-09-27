using System.Runtime.CompilerServices;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void ShowResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");

        //Aqui se usa el bulce "foreach" para imprimir cada elemento de la lista "Job"
        foreach (Job job in _jobs)
        {  
           //Este comando sirve para que que el metodo ShowJobsDetails se aplique en cada trabajo
           job.ShowJobDetails(); 
        }

    }
}