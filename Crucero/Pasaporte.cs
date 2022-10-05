using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public class Pasaporte : Persona
    {
        private string numeroDocumentoViaje;
        private DateTime fechaEmision;
        private DateTime fechaVencimiento;
        private ePasaportes tipoPasaporte;
        private string codigoPaisExterior;
        private string autoridadExpedidora;

        /// <summary>
        /// Propiedad que me retorna el numero de pasaporte
        /// </summary>
        public string NumeroDocumentoViaje { get { return this.numeroDocumentoViaje; } }

        /// <summary>
        /// Inicializa con valores validos el objeto Pasaporte a crear
        /// </summary>
        /// <param name="nombre">nombre del dueño del pasaporte</param>
        /// <param name="apellido">apellido del dueño del pasaporte</param>
        /// <param name="sexo">sexo de la persona</param>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        /// <param name="fechaNacimiento">fecha de nacimiento de la persona</param>
        /// <param name="numeroDocumento">numero de documento de la persona</param>
        /// <param name="domicilio">domicilio de la persona</param>
        /// <param name="lugarNacimiento">lugar de nacimiento de la persona/ciudad</param>
        /// <param name="numeroDocumentoViaje">numero de pasaporte de la persona</param>
        /// <param name="fechaEmision">fecha de emision del pasaporte</param>
        /// <param name="fechaVencimiento">fecha de vencimiento del pasaporte</param>
        /// <param name="tipoPasaporte">tipo de pasaporte</param>
        /// <param name="codigoPaisExterior">abreviatura del pais del pasaporte, ej Argentina - ARG </param>
        /// <param name="autoridadExpedidora">autoridad que hizo el pasaporte, EJ- ARG -> RENAPER </param>
        public Pasaporte(string nombre, string apellido, char sexo, string nacionalidad, DateTime fechaNacimiento, 
            string numeroDocumento,string domicilio, string lugarNacimiento,string numeroDocumentoViaje,DateTime fechaEmision,
            DateTime fechaVencimiento, string tipoPasaporte, string codigoPaisExterior, string autoridadExpedidora) : base(nombre,apellido,
                sexo,nacionalidad,fechaNacimiento,numeroDocumento,domicilio,lugarNacimiento)
        {
            this.numeroDocumentoViaje = numeroDocumentoViaje;
            this.fechaEmision = fechaEmision;
            this.fechaVencimiento = fechaVencimiento;
            Enum.TryParse(tipoPasaporte, out this.tipoPasaporte);
            this.codigoPaisExterior = codigoPaisExterior;
            this.autoridadExpedidora = autoridadExpedidora;
        }

        /// <summary>
        /// Retorna un string con el estado del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.numeroDocumentoViaje}-{this.fechaEmision}-{this.fechaVencimiento}-{this.tipoPasaporte.ToString()}-" +
                $"{this.codigoPaisExterior}-{this.autoridadExpedidora}";
        }

        /// <summary>
        /// Compara si el objeto this actual es igual al del parametro comparando con la sobrecarga del ==
        /// </summary>
        /// <param name="obj">de tipo object</param>
        /// <returns>si el objeto this actual es igual al del parametor retorna true sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Pasaporte)
            {
                retorno = this == ((Pasaporte)obj);
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
