using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Pasajero:Persona
    {
        private int edad;
        private Pasaporte pasaporte;
        private bool esPremium;
        private Equipaje equipaje;

        public Equipaje Equipaje { get { return this.equipaje; } }
        public bool EsPremium { get { return this.esPremium; } }
        public Pasaporte Pasaporte { get { return this.pasaporte; } }

        public string Nombre { get { return this.nombre; } }

        public string Apellido { get { return this.apellido; } }

        public string Edad { get { return this.edad.ToString(); } }

        public Pasajero(string nombre, string apellido, char sexo, string nacionalidad, DateTime fechaNacimiento,
            string numeroDocumento, string domicilio, string lugarNacimiento, string numeroDocumentoViaje, DateTime fechaEmision,
            DateTime fechaVencimiento, string tipoPasaporte, string codigoPaisExterior, string autoridadExpedidora, Equipaje equipaje,bool esPremium) : 
            base(nombre, apellido,sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, lugarNacimiento)
        {
            this.edad = calcularEdad(fechaNacimiento);
            this.equipaje = equipaje;
            this.esPremium = esPremium;
            this.pasaporte = new Pasaporte(nombre, apellido, sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, lugarNacimiento,
                numeroDocumentoViaje, fechaEmision, fechaVencimiento, tipoPasaporte, codigoPaisExterior, autoridadExpedidora);

        }

        public static bool operator ==(Pasajero p1,Pasajero p2)
        {
            return (p1.numeroDocumento == p2.numeroDocumento);
        }


        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Pasajero)
            {
                retorno = this == ((Pasajero)obj);
            }
            return retorno;
        }

        private int calcularEdad(DateTime FechaNacimiento)
        {
            if (FechaNacimiento.Year == DateTime.Today.Year)
                return 0;

            return 1 + calcularEdad(FechaNacimiento.AddYears(1));
        }
    }
}
