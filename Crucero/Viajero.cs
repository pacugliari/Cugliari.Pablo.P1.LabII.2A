using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Viajero:Persona
    {
        private int edad;
        private Pasaporte pasaporte;
        private bool esPremium;
        private Equipaje equipaje;

        public Viajero(string nombre, string apellido, char sexo, ePaises nacionalidad, DateTime fechaNacimiento,
            string numeroDocumento, string domicilio, string lugarNacimiento, string numeroDocumentoViaje, DateTime fechaEmision,
            DateTime fechaVencimiento, char tipoPasaporte, string codigoPaisExterior, string autoridadExpedidora) : base(nombre, apellido,
                sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, lugarNacimiento)
        {
            this.edad = calcularEdad(fechaNacimiento);
            this.pasaporte = new Pasaporte(nombre, apellido, sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, lugarNacimiento,
                numeroDocumentoViaje, fechaEmision, fechaVencimiento, tipoPasaporte, codigoPaisExterior, autoridadExpedidora);

        }

        private int calcularEdad(DateTime fechaNacimiento)
        {
            return 8888;
        }
    }
}
