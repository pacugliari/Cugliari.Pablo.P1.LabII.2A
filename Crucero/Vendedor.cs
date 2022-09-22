using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Vendedor : Persona
    {
        private string usuario;
        private string contrasenia;

        public Vendedor(string usuario,string contrasenia, string nombre, string apellido) :base(nombre,apellido)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
    }
}
