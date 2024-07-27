using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SRP.Class
{
    public class EnvioCorreo
    {
        public void EnviarCorreoElectronico(Persona persona)
        {
            Console.WriteLine($"Enviando correo desde {persona.CorreoElectronico} ....");            
        }
    }


}
