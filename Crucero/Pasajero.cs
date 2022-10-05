using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public class Pasajero:Persona
    {
        private int edad;
        private Pasaporte pasaporte;
        private bool esPremium;
        private Equipaje equipaje;

        /// <summary>
        /// Propiedad que retorna el objeto equipaje del pasajero
        /// </summary>
        public Equipaje Equipaje { get { return this.equipaje; } }
        /// <summary>
        /// Propiedad que retorna si el pasajero es premium (true)o no (false)
        /// </summary>
        public bool EsPremium { get { return this.esPremium; } }
        /// <summary>
        /// Propiedad que retorna el objeto pasaporte del pasajero
        /// </summary>
        public Pasaporte Pasaporte { get { return this.pasaporte; } }
        /// <summary>
        /// Propiedad que retorna el nombre del pasajero
        /// </summary>
        public string Nombre { get { return this.nombre; } }
        /// <summary>
        /// Propiedad que retorna el apellido del pasajero
        /// </summary>
        public string Apellido { get { return this.apellido; } }
        /// <summary>
        /// Propiedad que retorna la edad en string de la persona
        /// </summary>
        public string Edad { get { return this.edad.ToString(); } }

        /// <summary>
        /// Inicializa con valores validos el objeto Pasajero que va a ser creado
        /// </summary>
        /// <param name="nombre">Nombre del pasajero</param>
        /// <param name="apellido">Apellido del pasajero</param>
        /// <param name="sexo">Sexo del pasajero, M -> masculino , F -> femenino</param>
        /// <param name="nacionalidad">Nacionalidad del pasajero</param>
        /// <param name="fechaNacimiento">fecha de nacimiento</param>
        /// <param name="numeroDocumento">numero de documento del pasajero</param>
        /// <param name="domicilio">Domiciilio del pasajero</param>
        /// <param name="lugarNacimiento">Lugar de nacimiento del pasajero o ciudad</param>
        /// <param name="numeroDocumentoViaje">Numero de pasaporte</param>
        /// <param name="fechaEmision">fecha de emision del pasaporte</param>
        /// <param name="fechaVencimiento">fecha de vencimiento del pasaporte</param>
        /// <param name="tipoPasaporte">tipo de pasaporte del pasajero</param>
        /// <param name="codigoPaisExterior">codigo que indica de que pais/abreviatura es el pasajero</param>
        /// <param name="autoridadExpedidora">autoridad que hizo el pasaporte, ej ARG -> RENAPER</param>
        /// <param name="equipaje">objeto equipaje del pasajero</param>
        /// <param name="esPremium">si es premium (true)o no (false) el pasajero</param>
        public Pasajero(string nombre, string apellido, char sexo, string nacionalidad, DateTime fechaNacimiento,
            string numeroDocumento, string domicilio, string lugarNacimiento, string numeroDocumentoViaje, DateTime fechaEmision,
            DateTime fechaVencimiento, string tipoPasaporte, string codigoPaisExterior, string autoridadExpedidora, Equipaje equipaje,bool esPremium) : 
            base(nombre, apellido,sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, lugarNacimiento)
        {
            this.edad = CalcularEdad(fechaNacimiento);
            this.equipaje = equipaje;
            this.esPremium = esPremium;
            this.pasaporte = new Pasaporte(nombre, apellido, sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, lugarNacimiento,
                numeroDocumentoViaje, fechaEmision, fechaVencimiento, tipoPasaporte, codigoPaisExterior, autoridadExpedidora);

        }
        /// <summary>
        /// Calcula la edad segun una fecha de nacimiento
        /// </summary>
        /// <param name="FechaNacimiento">fecha de nacimiento</param>
        /// <returns>Edad del pasajero</returns>
        private int CalcularEdad(DateTime FechaNacimiento)
        {
            if (FechaNacimiento.Year == DateTime.Today.Year)
                return 0;

            return 1 + CalcularEdad(FechaNacimiento.AddYears(1));
        }

        /// <summary>
        /// Busca en una lista generica de Pasajero si se encuentra el que posee el dni/pasaporte del parametro
        /// </summary>
        /// <param name="listaPasajeros">lista generica de pasajeros</param>
        /// <param name="dniOPasaporte">dni/pasaporte a buscar en la lista</param>
        /// <returns>Si se encuetra el pasajero lo retorna sino null</returns>
        public static Pasajero BuscarPasajero(List<Pasajero> listaPasajeros, string dniOPasaporte)
        {
            Pasajero retorno = null;

            foreach (Pasajero item in listaPasajeros)
            {
                if (item.numeroDocumento == dniOPasaporte || item.pasaporte.NumeroDocumentoViaje == dniOPasaporte)
                {
                    retorno = item;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Busca el pasajero en un viaje
        /// </summary>
        /// <param name="viaje">viaje que contiene una lista de pasajeros</param>
        /// <param name="dniOPasaporte">dni/pasaporte a buscar en en viaje</param>
        /// <returns>Si se encuentra el pasajero lo retorna sino null</returns>
        public static Pasajero BuscarPasajero(Viaje viaje, string dniOPasaporte)
        {
            Pasajero retorno = null;

            for (int i = 0; i < viaje.CantidadPasajeros; i++)
            {
                if (viaje[i].numeroDocumento == dniOPasaporte || viaje[i].pasaporte.NumeroDocumentoViaje == dniOPasaporte)
                {
                    retorno = viaje[i];
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Compara si 2 pasajeros son iguales verificando si son iguales sus numeros de documento
        /// </summary>
        /// <param name="p1">pasajero 1</param>
        /// <param name="p2">pasajero 2</param>
        /// <returns>son iguales retorna true sino false</returns>
        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            System.Diagnostics.Debug.WriteLine(p1.numeroDocumento, p2.numeroDocumento);
            return (p1.numeroDocumento == p2.numeroDocumento);
        }

        /// <summary>
        /// Comparar si 2 pasajeros son distintos segun su numero de documento
        /// </summary>
        /// <param name="p1">pasajero 1</param>
        /// <param name="p2">pasajero 2</param>
        /// <returns>si son distintos retorna true sino false</returns>
        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Compara si el objeto this actual es igual al pasaddo por parametro
        /// </summary>
        /// <param name="obj">de tipo object</param>
        /// <returns>si el objeto this actual es igual al del parametro comparando por la sobrecarga del == retorna true sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Pasajero)
            {
                retorno = this == ((Pasajero)obj);
            }
            return retorno;
        }

        /// <summary>
        /// Valor Hash del objeto
        /// </summary>
        /// <returns>Valor Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Retorna un string con el estado del objeto
        /// </summary>
        /// <returns>string con el estado del objeto</returns>
        public override string ToString()
        {
            return $"{base.ToString()}-{this.edad}-{this.pasaporte.ToString()}-{this.equipaje.ToString()}";
        }


    }
}
