using objeto.Clases;
using System;

namespace objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona persona = new Persona();

            persona.Nombre = "Josue yeriel";
            persona.Apellido = "pech cupido";
            persona.Edad = 34;
            persona.Salario = 199999999999999;

            persona.ImprimirDatos();

            Console.WriteLine("--------------------------------------------------------------------------");

            Persona persona2 = new Persona();

            persona2.Nombre = "chan ady";
            persona2.Apellido = "ku gomes";
            persona2.Edad = 34;
            persona2.Salario = 500;
            persona2.ImprimirDatos();
        }
    }
}
