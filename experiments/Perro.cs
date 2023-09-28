public class Perro
{
    public string _raza = "";
    public string _color = "";
    public int _edadNum = 0;
    public string _edadLet = "";
    public string _nombre = "";
    public string _sexo = "";

     public List<Perro> _perros = new List<Perro>();
    
    public void DesplegarInformacion()
    {
        Console.WriteLine($"{_nombre} {_edadNum} {_edadLet}, {_raza}, {_color}, {_sexo}.");

        
    }
    
     public void ListaDePerros()
    {
        Console.WriteLine("------------LIST OF DOGS WAITING FOR AN OPERATION-------------");   

        foreach (Perro _perro in _perros)
        {
              
            _perro.DesplegarInformacion();
        }

        Console.WriteLine("");
    }

}