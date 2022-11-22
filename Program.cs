using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.nombre = "Juan";

            Console.WriteLine($"Nombre de la persona: {persona1.nombre}");
        }
    }
}
