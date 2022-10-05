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

        /// <summary>
        /// Iniciliza con los datos del parametro un objeto Vendedor
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Vendedor(string usuario,string contrasenia, string nombre, string apellido) :base(nombre,apellido)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.fechaActual = DateTime.Now;
        }

        /// <summary>
        /// Compara si un vendedor es igual a otro
        /// </summary>
        /// <param name="vendedor1">vendedor1</param>
        /// <param name="vendedor2">vendedor2</param>
        /// <returns>si el usuario y contraseña son iguales entonces retorna true sino false</returns>
        public static bool operator ==(Vendedor vendedor1,Vendedor vendedor2)
        {
            return ((vendedor1.usuario == vendedor2.usuario) && (vendedor1.contrasenia == vendedor2.contrasenia));
        }

        /// <summary>
        /// Compara si son distintos 2 vendedores
        /// </summary>
        /// <param name="vendedor1">vendedor 1</param>
        /// <param name="vendedor2">vendedor 2</param>
        /// <returns>si son distintos retorna true, sino false</returns>
        public static bool operator !=(Vendedor vendedor1, Vendedor vendedor2)
        {
            return !(vendedor1==vendedor2);
        }
        
        /// <summary>
        /// Castea de manera explicita el Vendedor a string retornando el nombre de usuario
        /// </summary>
        /// <param name="usuario">nombre de usuario</param>
        public static explicit operator string(Vendedor usuario)
        {
            return usuario.ToString();
        }

        /// <summary>
        /// Retorna el estado del objeto de tipo string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Nombre: {this.nombre}");
            texto.AppendLine($"Apellido: {this.apellido}");
            texto.AppendLine($"Fecha actual: {this.fechaActual.ToShortDateString()}");
            return texto.ToString();
        }

        /// <summary>
        /// Compara si el objeto this actual es igual obj del parametro comparando por la sobrecarga del ==
        /// </summary>
        /// <param name="obj">de tipo object</param>
        /// <returns>si son iguales retorna true sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Vendedor)
            {
                retorno = this == ((Vendedor)obj);
            }
            return retorno;
        }
        /// <summary>
        /// Codigo Hash del objeto
        /// </summary>
        /// <returns>Codigo Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
