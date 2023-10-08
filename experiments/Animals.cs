using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Gato gato1 = new Gato();
        gato1._nombre = "Hana";
        gato1._edadNum = 2;
        gato1._edadLet = "años";
        gato1._raza = "Siames";
        gato1._sexo = "Masculino";
        gato1._color = "Calico";

        Gato gato2 = new Gato();
        gato2._nombre = "Luna";
        gato2._edadNum = 3;
        gato2._edadLet = "meses";
        gato2._raza = "Montes";
        gato2._sexo = "Masculino";
        gato2._color = "Negro";
        
        Gato gato3 = new Gato();
        gato3._nombre = "Pico";
        gato3._edadNum = 4;
        gato3._edadLet = "años";
        gato3._raza = "Esfinge";
        gato3._sexo = "Femenino";
        gato3._color = "Sin pelaje";

        Gato gato4 = new Gato();
        gato4._nombre = "John";
        gato4._edadNum = 4;
        gato4._edadLet = "semanas";
        gato4._raza = "Azul ruso";
        gato4._sexo = "Masculino";
        gato4._color = "Naranaja";

        Gato gato5 = new Gato();
        gato5._nombre = "Haku";
        gato5._edadNum = 5;
        gato5._edadLet = "meses";
        gato5._raza = "Persa";
        gato5._sexo = "Femenino";
        gato5._color = "Blanco";

        Gato gato6 = new Gato();
        gato6._nombre = "Hana";
        gato6._edadNum = 2;
        gato6._edadLet = "años";
        gato6._raza = "Siames";
        gato6._sexo = "Masculino";
        gato6._color = "Atigrado";

        Gato lista1 = new Gato();
        lista1._gatos.Add(gato1);
        lista1._gatos.Add(gato2);
        lista1._gatos.Add(gato3);
        lista1._gatos.Add(gato4);
        lista1._gatos.Add(gato5);
        lista1._gatos.Add(gato6);

        Perro perro1 = new Perro();
        perro1._nombre = "Rocket";
        perro1._edadNum = 6;
        perro1._edadLet = "años";
        perro1._raza = "Zorro";
        perro1._sexo = "Masculina";
        perro1._color = "Rubio";

        Perro perro2 = new Perro();
        perro2._nombre = "Kai";
        perro2._edadNum = 5;
        perro2._edadLet = "años";
        perro2._raza = "Husky";
        perro2._sexo = "Masculino";
        perro2._color = "Blanco";
        
        Perro perro3 = new Perro();
        perro3._nombre = "Laika";
        perro3._edadNum = 6;
        perro3._edadLet = "meses";
        perro3._raza = "American Pitbull";
        perro3._sexo = "Femenino";
        perro3._color = "Manchado";

        Perro perro4 = new Perro();
        perro4._nombre = "Capitan";
        perro4._edadNum = 3;
        perro4._edadLet = "años";
        perro4._raza = "Doberman";
        perro4._sexo = "Masculino";
        perro4._color = "Amarillo";

        Perro perro5 = new Perro();
        perro5._nombre = "Aslan";
        perro5._edadNum = 6;
        perro5._edadLet = "meses";
        perro5._raza = "American Pitbull";
        perro5._sexo = "Masculino";
        perro5._color = "Manchado";

        Perro perro6 = new Perro();
        perro6._nombre = "Hana";
        perro6._edadNum = 2;
        perro6._edadLet = "años";
        perro6._raza = "Siames";
        perro6._sexo = "Masculino";
        perro6._color = "Atigrado";

        Perro lista2 = new Perro();
        lista2._perros.Add(perro1);
        lista2._perros.Add(perro2);
        lista2._perros.Add(perro3);
        lista2._perros.Add(perro4);
        lista2._perros.Add(perro5);
        lista2._perros.Add(perro6);
        
        lista1.ListaDeGatos();
        lista2.ListaDePerros();
    }
}
