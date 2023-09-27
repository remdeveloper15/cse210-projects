public class Job
{
    //Estas de aqui son las variables. 
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
     
    //Este de aqui realmente no se que es lo que hace pero por lo que se es importante.
    public Job()
    {
    }
    
    //Esto de aqui es un Metodo! Es importante para crear y personalizar un objeto que se enseñara en la funcion principal. En el caso de este, es solo para mostrar el nombre de la compañia.
    public void ShowCompanyName()
    {
        Console.WriteLine($"{_company}");
    }

    public void ShowJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
    }

}