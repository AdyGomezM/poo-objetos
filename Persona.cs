using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Persona
    {
        internal int Edad;

        public bool Nombre { get; internal set; }
        public string Apellido { get; internal set; }

        internal void ImprimirDatos()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Persona(persona v)
        {
            throw new NotImplementedException();
        }
    }
}