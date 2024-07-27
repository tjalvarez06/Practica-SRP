using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SRP.Class
{
    public class ImpresionDatos
    {
        
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Direccion: {persona.Direccion}");
            Console.WriteLine($"Correo electronico: {persona.CorreoElectronico}");
        }
    }
}
