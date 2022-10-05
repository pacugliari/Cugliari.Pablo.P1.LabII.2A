using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public class Viaje
    {
        private eCiudades ciudadPartida;
        private eCiudades ciudadDestino;
        private DateTime fechaInicioViaje;
        private DateTime fechaFinViaje;
        private Crucero crucero;
        private int cantidadCamarotesPremium;
        private int cantidadCamarotesTurista;
        private float costoTurista;
        private float costoPremium;
        private int duracionViaje;
        private List<Pasajero> pasajeros;

        /// <summary>
        /// Propiedad que retorna la cantidad de pasajeros del viaje
        /// </summary>
        public int CantidadPasajeros { get { return this.pasajeros.Count; } }
        /// <summary>
        /// Propiedad que retorna el crucero del viaje
        /// </summary>
        public Crucero Crucero { get { return this.crucero; } }

        /// <summary>
        /// Indexador que permite obtener un pasajero de la lista validando el indice 
        /// </summary>
        /// <param name="index">indice donde se encuentra el Pasajero a consultar</param>
        /// <returns>si es valido el indice retorna el pasajero sino null</returns>
        public Pasajero this[int index]
        {
            get
            {
                Pasajero retorno = null;
                if (index >= 0 && index < this.pasajeros.Count)
                    retorno = this.pasajeros[index];

                return retorno;
            }
        }

        /// <summary>
        /// Propiedad que retorna la ciudad de destino en formato string del viaje
        /// </summary>
        public string CiudadDestino { get { return this.ciudadDestino.ToString(); } }

        /// <summary>
        /// Propiedad que retorna la duracion del viaje 
        /// </summary>
        public int DuracionViaje { get { return this.duracionViaje; } }

        /// <summary>
        /// Inicializa la lista de pasajeros
        /// </summary>
        private Viaje()
        {
            this.pasajeros = new List<Pasajero>();
        }

        /// <summary>
        /// Inicializa un viaje con los datos del parametro
        /// </summary>
        /// <param name="ciudadDestino">ciudad de destino del viaje</param>
        /// <param name="duracionViaje">duracion del viaje en horas</param>
        /// <param name="nombreCrucero">nombre del crucero del viaje</param>
        /// <param name="fechaInicioViaje">fecha de inicio del viaje</param>
        public Viaje(string ciudadDestino, string duracionViaje, string nombreCrucero, string fechaInicioViaje):this()
        {
            this.ciudadDestino = this.ciudadPartida = eCiudades.BuenosAires_Argentina;
            Enum.TryParse(ciudadDestino, out this.ciudadDestino);
            this.duracionViaje = int.Parse(duracionViaje);
            this.crucero = Flota.ObtenerEmbarcacionDeNombre(nombreCrucero);
            this.fechaInicioViaje = DateTime.Parse(fechaInicioViaje);
        }
        /// <summary>
        /// Iniciliza un viaje con los datos del parametro 
        /// </summary>
        /// <param name="ciudadPartida">Ciudad de partida del viaje</param>
        /// <param name="ciudadDestino">Ciudad de destino del viaje</param>
        /// <param name="fechaInicioViaje">Fecha de inicio del viaje</param>
        /// <param name="crucero">Crucero del viaje</param>
        /// <param name="cantidadCamarotesPremium">Cantidad de camarotes premium del viaje </param>
        /// <param name="cantidadCamarotesTurista">Cantidad de camarotes turista del viaje</param>
        /// <param name="costoTurista">Costo turista del viaje</param>
        /// <param name="costoPremium">Costo premium del viaje</param>
        /// <param name="duracionViaje">Duracion en horas del viaje</param>
        public Viaje(string ciudadPartida, string ciudadDestino, DateTime fechaInicioViaje, Crucero crucero,
            int cantidadCamarotesPremium, int cantidadCamarotesTurista, float costoTurista, float costoPremium, int duracionViaje) : this()
        {
            Enum.TryParse(ciudadPartida, out this.ciudadPartida);
            Enum.TryParse(ciudadDestino, out this.ciudadDestino);
            this.fechaInicioViaje = fechaInicioViaje;
            this.crucero = crucero;
            this.cantidadCamarotesPremium = cantidadCamarotesPremium;
            this.cantidadCamarotesTurista = cantidadCamarotesTurista;
            this.costoTurista = costoTurista;
            this.costoPremium = costoPremium;
            this.duracionViaje = duracionViaje;
            this.fechaFinViaje = this.fechaInicioViaje.AddHours(this.duracionViaje);
        }

        /// <summary>
        /// Verifica si el nuevoViaje se solapa con viajes ya creados y da como salida una fecha disponible para dicho viaje
        /// </summary>
        /// <param name="listaViajes"> lista generica de viajes </param>
        /// <param name="nuevoViaje">viaje a verificar si se solapan las fechas</param>
        /// <param name="fechaDisponible">parametro de retorno de la fecha estimada para el viaje</param>
        /// <returns></returns>
        public static bool SeSolapanViajes(List<Viaje> listaViajes,Viaje nuevoViaje, out DateTime fechaDisponible)
        {
            bool retorno = false;
            fechaDisponible = new DateTime();
            DateTime fechaFinNuevoViaje = nuevoViaje.fechaFinViaje;
            foreach (Viaje item in listaViajes)
            {
                if((item.fechaInicioViaje <= nuevoViaje.fechaInicioViaje && nuevoViaje.fechaInicioViaje <= item.fechaFinViaje && nuevoViaje.crucero == item.crucero )
                    || (item.fechaInicioViaje <= fechaFinNuevoViaje && fechaFinNuevoViaje <= item.fechaFinViaje && nuevoViaje.crucero == item.crucero))
                {
                    if(fechaDisponible < item.fechaFinViaje)
                        fechaDisponible = item.fechaFinViaje;
                    retorno = true;
                }
            }

            return retorno;

        }

        /// <summary>
        /// Agrega al viaje una lista de pasajeros actualizando el estado del crucero
        /// </summary>
        /// <param name="clientes">Lista generica de pasajeros/clientes a ser dados de alta en el viaje</param>
        public void AgregarPasajeros(List<Pasajero> clientes)
        {
            int cantCamPremium = 0;
            int cantCamTurista = 0;
            float pesoUsado = 0;
            Crucero.CalcularCamarotes(clientes, out cantCamTurista, out cantCamPremium);
            pesoUsado = Equipaje.calcularPesoTotal(clientes);
            this.crucero.ActualizarDisponibilidad(cantCamTurista,cantCamPremium,pesoUsado);
            foreach (Pasajero item in clientes)
            {
                this.pasajeros.Add(item);
            }
        }

        /// <summary>
        /// Busca en la lista de viajes el que coincide con los parametros
        /// </summary>
        /// <param name="listaViajes">Lista generica de viajes</param>
        /// <param name="ciudadDestino">Ciudad de destino del viaje a buscar</param>
        /// <param name="fechaInicioViaje">Fecha de inicio del viaje a buscar</param>
        /// <param name="duracionViaje">Duracion en horas del viaje a buscar</param>
        /// <param name="nombreCrucero">Nombre del crucero del viaje a buscar</param>
        /// <returns>Si se encuentra el viaje lo retorna sino null</returns>
        public static Viaje BuscarViajePor(List<Viaje> listaViajes,string ciudadDestino, string fechaInicioViaje, string duracionViaje, string nombreCrucero)
        {
            Viaje retorno = null;
            foreach (Viaje item in listaViajes)
            {
                
                if (item == new Viaje(ciudadDestino, duracionViaje, nombreCrucero, fechaInicioViaje))
                {//ES EL MISMO VIAJE
                    retorno = item;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Filtra de una lista de cruceros aquellos que tienen los mismos viajes
        /// </summary>
        /// <param name="listaViajes">lista generica de viajes </param>
        /// <param name="listaCruceros">lista generica de cruceros</param>
        /// <returns>Lista generica con los cruceros que se encuentra para dichos viajes</returns>
        public static List<Viaje> FiltrarViajes(List<Viaje> listaViajes ,List<Crucero> listaCruceros)
        {
            List<Viaje> filtrada = new List<Viaje>();
            foreach (Crucero cruceroIndice in listaCruceros)
            {
                foreach (Viaje viajeIndice in listaViajes)
                {
                    if (cruceroIndice == viajeIndice && cruceroIndice.EstaDisponible)
                        filtrada.Add(viajeIndice);
                }
            }

            return filtrada;
        }

        /// <summary>
        /// Verifica si un destino es regional
        /// </summary>
        /// <param name="nombreDestino">nombre del destino</param>
        /// <returns>Si el destino es regional retorna true sino false</returns>
        public static bool EsRegional(string nombreDestino)
        {
            bool retorno = false;
            eCiudades destino;
            if (Enum.TryParse(nombreDestino, out destino))
            {
                if (((int)destino) >= 0 && ((int)destino) <= 9)//SI ESTA ENTRE 0 Y 9 ES UN DESTINO REGIONAL
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Calcula el precio turista segun el nombre de destino y la duracion
        /// </summary>
        /// <param name="nombreDestino">nombre del destino</param>
        /// <param name="duracion">duracion en horas</param>
        /// <returns>precio calculado segun destino y duracion</returns>
        public static float CalcularPrecioTurista(string nombreDestino,int duracion)
        {
            float precio = 120;
            if (EsRegional(nombreDestino))
                precio = 57;

            return precio*duracion;
        }

        /// <summary>
        /// Calcula el precio premium segun el nombre del destino y la duracion
        /// </summary>
        /// <param name="nombreDestino">nombre del destino</param>
        /// <param name="duracion">duracion  en horas</param>
        /// <returns>precio calculado segun destino y duracion</returns>
        public static float CalcularPrecioPremium(string nombreDestino,int duracion)
        {
            return (float)(Viaje.CalcularPrecioTurista(nombreDestino, duracion) * 1.2);
        }

        /// <summary>
        /// Calcula de manera aleatoria la duracion del viaje dependiendo si es regional o extraregional
        /// </summary>
        /// <param name="nombreDestino">nombre del destino</param>
        /// <returns>duracion calculada del destino</returns>
        public static int CalcularDuracion(string nombreDestino)
        {
            
            Random myObject = new Random();
            int duracion=0;

            if (Viaje.EsRegional(nombreDestino))
            {
                duracion = myObject.Next(72, 360);
            }else
                duracion = myObject.Next(480, 720);

            return duracion;
        }
        /// <summary>
        /// Calcula los costos totales segun una lista de viajeros
        /// </summary>
        /// <param name="listaViajeros">lista generica de viajeros</param>
        /// <returns>retorna el costo total segun los viajeros de la lista </returns>
        public float CalcularCostos(List<Pasajero> listaViajeros)
        {
            int cantidadDeTuristas=0;
            int cantidadDePremium=0;

            Crucero.ContarTiposPasajeros(listaViajeros, out cantidadDeTuristas,out cantidadDePremium);

            return (cantidadDeTuristas * this.costoTurista) + (cantidadDePremium * this.costoPremium);
        }

        /// <summary>
        /// Compara si 2 viajes son iguales segun ciudad destino, duracion del viaje, nombre del crucero y fecha de inicio del viaje
        /// </summary>
        /// <param name="v1">Viaje 1</param>
        /// <param name="v2">Viaje 2</param>
        /// <returns>Si son iguales retorna true sino false</returns>
        public static bool operator ==(Viaje v1, Viaje v2)
        {
            return (v1.ciudadDestino == v2.ciudadDestino && v1.duracionViaje == v2.duracionViaje && v1.crucero == v2.crucero &&
                v1.fechaInicioViaje.ToShortDateString() == v2.fechaInicioViaje.ToShortDateString());
        }

        /// <summary>
        /// Compara por distinto 2 viajes segun ciudad destino, duracion del viaje, nombre del crucero y fecha de inicio del viaje
        /// </summary>
        /// <param name="v1">viaje 1</param>
        /// <param name="v2">viaje 2</param>
        /// <returns>Si son distintos retorna true sino false</returns>
        public static bool operator !=(Viaje v1, Viaje v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Compara si el crucero del viaje es el mismo contra el que se compara
        /// </summary>
        /// <param name="crucero">crucero</param>
        /// <param name="viaje">viaje que contiene crucero</param>
        /// <returns>si el viaje contiene al crucero entonces retorna true sino false</returns>
        public static bool operator ==(Crucero crucero, Viaje viaje)
        {
            return (string)crucero == (string)viaje.crucero;
        }

        /// <summary>
        /// Compara si el crucero del viaje no es el mismo que el crucero que se compara
        /// </summary>
        /// <param name="crucero">crucero</param>
        /// <param name="viaje">viaje</param>
        /// <returns>si el viaje no contiene al crucero retorna true sino false</returns>
        public static bool operator !=(Crucero crucero, Viaje viaje)
        {
            return !(crucero == viaje);
        }

        /// <summary>
        /// Retorna el estado del objeto en formato string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.ciudadPartida}-{this.ciudadDestino}-{(string)this.crucero}-{this.fechaInicioViaje}-" +
                $"{this.cantidadCamarotesPremium}-{this.cantidadCamarotesTurista}-${this.costoPremium}-${this.costoTurista}-{this.duracionViaje}";
        }

        /// <summary>
        /// Compara si el objeto actual this es igual al del parametro comparando con la sobrecarga del ==
        /// </summary>
        /// <param name="obj">es de tipo object</param>
        /// <returns>si el objeto actual this es igual al del parametro retorna true sino false </returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Viaje)
            {
                retorno = this == ((Viaje)obj);
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
