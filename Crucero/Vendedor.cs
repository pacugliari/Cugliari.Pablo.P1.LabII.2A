using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public class Vendedor : Persona
    {
        private string usuario;
        private string contrasenia;
        private DateTime fechaActual;

        public Vendedor(string usuario,string contrasenia, string nombre, string apellido) :base(nombre,apellido)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.fechaActual = DateTime.Now;
        }

        public static bool operator ==(Vendedor vendedor1,Vendedor vendedor2)
        {
            return ((vendedor1.usuario == vendedor2.usuario) && (vendedor1.contrasenia == vendedor2.contrasenia));
        }

        public static bool operator !=(Vendedor vendedor1, Vendedor vendedor2)
        {
            return !(vendedor1==vendedor2);
        }

        public static explicit operator string(Vendedor usuario)
        {
            return usuario.ToString();
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Nombre: {this.nombre}");
            texto.AppendLine($"Apellido: {this.apellido}");
            texto.AppendLine($"Fecha actual: {this.fechaActual.ToShortDateString()}");
            return texto.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Vendedor)
            {
                retorno = this == ((Vendedor)obj);
            }
            return retorno;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
