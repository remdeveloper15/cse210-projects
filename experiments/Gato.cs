public class Gato
{
    public string _raza = "";
    public string _color = "";
    public int _edadNum = 0;
    public string _edadLet = "";
    public string _nombre = "";
    public string _sexo = "";

    public List<Gato> _gatos = new List<Gato>();

    public void DesplegarInformacion()
    {
        Console.WriteLine($"{_nombre} {_edadNum} {_edadLet}, {_raza}, {_color}, {_sexo}.");

        
    }

    public void ListaDeGatos()
    {
        Console.WriteLine("------------LIST OF CATS WAITING FOR AN OPERATION-------------");  

        foreach (Gato _gato in _gatos)
        {
                
            _gato.DesplegarInformacion();   
        }

        Console.WriteLine("");
    }
}