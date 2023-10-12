using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Primero creamos la clase entry, que servira para crear nuestro objeto Entry. "Entry" sirve para fomar un objecto el cual se forma por la fecha, la propupuesta y la entrada del usuario.
public class Entry
{
    //Dentro de la clase Entry, definimos los tres aspectos antes mencionados. Nota: Al parecer se puede definir un apecto de una mejor manera al poner "public string _nombreDelAspecto;".
    public string _date;
    public string _prompt;
    public string _entry;

    //El siguiente paso es el que yo no conocia, el cual es crear una clase constructora. Una clase constructura son aquellas que no retornan nada, tampoco ahi que poner que tipo de informacion retorna, en su lugar solo ponemos la palabra public, el nombre de la clase, seguido de unos parentesis, en los cuales se ponen los parametros a recibir. En este caso procedo a poner el _date, _prompt, _entry. 
    //Nota: Recuerda que cada que ingresas un parametro, por lo general defines alli mismo que clase de dato es.

    public Entry(string date, string prompt, string entry)
    {
        //Ahora definimos los valores de nuestros parametros c; 
        //En este caso pongo los valores de mis parametros superiores ya que quieron que sean estos.
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_prompt} Entry: {_entry}.");
    }

}