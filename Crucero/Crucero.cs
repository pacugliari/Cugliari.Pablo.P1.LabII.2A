using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int totalDeCamarotes;
        private List<eSalones> salones;
        private int cantidadCasinos;
        private float capacidadBodega;
        private int cantidadCamarotesTurista;
        private int cantidadCamarotesPremium;
        private bool estaDisponible;
        private static int cantidadPasajerosPorCamarote;
        private int camarotesPremiumUsados;
        private int camarotesTuristaUsados;
        private float capacidadBodegaUsada;

        /// <summary>
        /// Constructor estatico que iniciliza la cantidad de pasajeros por camarote de todos los cruceros
        /// </summary>
        static Crucero()
        {
            Crucero.cantidadPasajerosPorCamarote = 4;
        }

        /// <summary>
        /// Propiedad para setear o obtener el valor del crucero, si esta en viaje es false si esta disponible true
        /// </summary>
        public bool EstaDisponible {
            set { this.estaDisponible = value; }
            get { return this.estaDisponible; }
        }

        /// <summary>
        /// Propiedad para obtener el nombre del crucero
        /// </summary>
        public string Nombre { get { return this.nombre; } }
        /// <summary>
        /// Propiedad para obtener el calculo de camarotes premium libres
        /// </summary>
        public int CamarotesPremiumLibres { get { return this.cantidadCamarotesPremium - this.camarotesPremiumUsados; } }
        /// <summary>
        /// Propiedad para obtener el calculo de camarotes turista libres
        /// </summary>
        public int CamarotesTuristaLibres { get { return this.cantidadCamarotesTurista - this.camarotesTuristaUsados; } }
        /// <summary>
        /// Propiedad para obtener la cantidad de camarotes premium del crucero
        /// </summary>
        public int CamarotesPremium{ get { return this.cantidadCamarotesPremium ; } }
        /// <summary>
        /// Propiedad para obtener la cantidad de camarotes turista del crucero
        /// </summary>
        public int CamarotesTurista{ get { return this.cantidadCamarotesTurista; } }
        /// <summary>
        /// Propiedad para obtener la capacidad libre que tiene el crucero 
        /// </summary>
        public float CapacidadBodegaLibre { get { return this.capacidadBodega-this.capacidadBodegaUsada; } }
        /// <summary>
        /// Propiedad para consultar el atributo estatico de la cantidad de pasajeros por camarote
        /// </summary>
        public string CantidadPasajerosPorCamarote { get { return Crucero.cantidadPasajerosPorCamarote.ToString(); } }

        /// <summary>
        /// Me permite copiar el contenido de un objeto crucero en otro
        /// </summary>
        /// <param name="cruceroCopia">Objeto de tipo crucero a copiar en uno nuevo</param>
        public Crucero(Crucero cruceroCopia)
        {
            this.matricula = cruceroCopia.matricula;
            this.nombre = cruceroCopia.nombre;
            this.totalDeCamarotes = cruceroCopia.totalDeCamarotes;
            this.salones = cruceroCopia.salones;
            this.cantidadCasinos = cruceroCopia.cantidadCasinos;
            this.capacidadBodega = cruceroCopia.capacidadBodega;
            this.cantidadCamarotesTurista = cruceroCopia.cantidadCamarotesTurista;
            this.cantidadCamarotesPremium = cruceroCopia.cantidadCamarotesPremium;
            this.estaDisponible = cruceroCopia.estaDisponible;
            this.camarotesPremiumUsados = cruceroCopia.camarotesPremiumUsados;
            this.camarotesTuristaUsados = cruceroCopia.camarotesTuristaUsados;
            this.capacidadBodegaUsada = cruceroCopia.capacidadBodegaUsada;
        }

        /// <summary>
        /// Inicializar un objeto crucero con los campos matricula,nombre,camarotes,salones y la capacidad de la bodega
        /// </summary>
        /// <param name="matricula">numero de matricula del crucero</param>
        /// <param name="nombre"> nombre del crucero</param>
        /// <param name="cantidadCamarotes">cantidad de camarotes del crucero</param>
        /// <param name="salones">List generica de enumerados de salones</param>
        /// <param name="capacidadBodega">capacidad de la bodega del crucero</param>
        public Crucero(string matricula, string nombre, int cantidadCamarotes, List<eSalones> salones, float capacidadBodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.totalDeCamarotes = cantidadCamarotes;
            this.salones = salones;
            this.cantidadCasinos = 0;
            this.estaDisponible = true;
            this.camarotesPremiumUsados = 0;
            this.camarotesTuristaUsados = 0;
            this.capacidadBodegaUsada = 0;

            foreach (eSalones item in this.salones)
            {
                if (item == eSalones.Casino)
                    this.cantidadCasinos++;
            }

            this.capacidadBodega = capacidadBodega;

            this.cantidadCamarotesPremium = (int)(this.totalDeCamarotes * 0.35);
            this.cantidadCamarotesTurista = this.totalDeCamarotes - this.cantidadCamarotesPremium;

        }

        /// <summary>
        /// Calcula la cantidad de camarotes para un numero determinado de pasajeros
        /// </summary>
        /// <param name="cantidadPasajeros"> cantidad de pasajeros en total</param>
        /// <returns>cantidad de camarotes necesarios</returns>
        private static int CalcularCantidadCamarotes(int cantidadPasajeros)
        {
            int retorno = 0;

            while (cantidadPasajeros >= 4) //CANTIDAD DE PERSONAS POR CAMAROTE
            {
                retorno++;
                cantidadPasajeros -= 4;
            }

            if (cantidadPasajeros != 0)
                retorno++;

            return retorno;
        }

        /// <summary>
        /// De una lista generica de Pasajeros me permite saber cual es la cantidad premium y cuantos son los turistas
        /// </summary>
        /// <param name="listaViajeros">Lista generica de pasajeros</param>
        /// <param name="cantidadTuristas">parametro de salida de la cantidad de turistas contados</param>
        /// <param name="cantidadPremium">parametro de salida de la cantidad de premium contados</param>
        public static void ContarTiposPasajeros(List<Pasajero> listaViajeros, out int cantidadTuristas, out int cantidadPremium)
        {
            cantidadTuristas = 0;
            cantidadPremium = 0;

            foreach (Pasajero item in listaViajeros)
            {
                if (item.EsPremium)
                {
                    cantidadPremium++;
                }
                else
                    cantidadTuristas++;
            }
        }

        /// <summary>
        /// Calcula la cantidad de camarotes de tipo turista y premium segun una lista generica de pasajeros
        /// </summary>
        /// <param name="listaViajeros">lista generica</param>
        /// <param name="cantidadCamarotesTurista">parametro de salida de cantidad de camarotes turista</param>
        /// <param name="cantidadCamarotesPremium">parametro de salida de cantidad de camarotes premium</param>
        public static void CalcularCamarotes(List<Pasajero> listaViajeros, out int cantidadCamarotesTurista, out int cantidadCamarotesPremium)
        {
            int cantidadTuristas = 0;
            int cantidadPremium = 0;

            Crucero.ContarTiposPasajeros(listaViajeros, out cantidadTuristas, out cantidadPremium);

            cantidadCamarotesTurista = Crucero.CalcularCantidadCamarotes(cantidadTuristas);
            cantidadCamarotesPremium = Crucero.CalcularCantidadCamarotes(cantidadPremium);

        }

        /// <summary>
        /// Para saber si un crucero tiene la capaciad tanto de camarotes tipo turista/premium y el peso que recibe la bodega
        /// </summary>
        /// <param name="cantidadCamarotesTurista">cantidad de camarotes turista que va a recibir el crucero</param>
        /// <param name="cantidadCamarotesPremium">cantidad de camrotes premium que va a recibir el crucero</param>
        /// <param name="pesoGrupoFamiliar">peso que recibe la bodega del crucero</param>
        /// <returns>si puede contener lo pasado por parametro retorna true, sino false </returns>
        public bool TieneEspacioPara(int cantidadCamarotesTurista, int cantidadCamarotesPremium, float pesoGrupoFamiliar)
        {
            bool retorno = false;
            if ((this.capacidadBodega - this.capacidadBodegaUsada) >= pesoGrupoFamiliar &&
                (this.cantidadCamarotesPremium- this.camarotesPremiumUsados) >= cantidadCamarotesPremium
                && (this.cantidadCamarotesTurista - this.camarotesTuristaUsados) >= cantidadCamarotesTurista)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Verifica si el crucero esta lleno
        /// </summary>
        /// <returns>si esta lleno retorna true sino false</returns>
        public bool EstaCompleto()
        {
            bool retorno = false;

            if((this.camarotesPremiumUsados == this.cantidadCamarotesPremium && this.camarotesTuristaUsados == this.cantidadCamarotesTurista) 
                && (this.capacidadBodegaUsada == this.capacidadBodega))
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Descuenta una cantidad X de camarotes turista/premium y un peso de la bodega
        /// </summary>
        /// <param name="cantCamTurista"></param>
        /// <param name="cantCamPremium"></param>
        /// <param name="pesoUsado"></param>
        public void ActualizarDisponibilidad(int cantCamTurista,int cantCamPremium,float pesoUsado)
        {
            this.camarotesTuristaUsados += cantCamTurista;
            this.camarotesPremiumUsados += cantCamPremium;
            this.capacidadBodegaUsada += pesoUsado;
        }

        /// <summary>
        /// Verifica si el salon se encuentra en el crucero
        /// </summary>
        /// <param name="salon">enumerado de tipo eSalon</param>
        /// <returns>si el salon se encuentra retorna true sino false</returns>
        public bool TieneElSalon(eSalones salon)
        {
            bool retorno = false;
            if (this.salones.Contains(salon))
                retorno = true;

            return retorno;
        }

        /// <summary>
        /// Casteo explicito de embarcacion a string retornando el nombre del mismo
        /// </summary>
        /// <param name="embarcacion">crucero a castear</param>
        public static explicit operator string(Crucero embarcacion)
        {
            return embarcacion.nombre;
        }

        /// <summary>
        /// Compara dos objetos del tipo crucero
        /// </summary>
        /// <param name="c1">crucero 1</param>
        /// <param name="c2">crucero 2</param>
        /// <returns>si los nombre de los cruceros son iguales retorna true sino false</returns>
        public static bool operator ==(Crucero c1,Crucero c2)
        {
            return (c1.nombre == c2.nombre);
        }

        /// <summary>
        /// Compara dos cruceros por desigual
        /// </summary>
        /// <param name="c1">crucero 1</param>
        /// <param name="c2">crucero 2</param>
        /// <returns>si los nombre de los cruceros son iguales retorna false sino true</returns>
        public static bool operator !=(Crucero c1, Crucero c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Metodo usado para hardcodear Viaje indicando crucero y ciudad destino
        /// </summary>
        /// <param name="crucero">crucero que se agrega en el viaje creado</param>
        /// <param name="destino">destino que se agrega en el viaje creado</param>
        /// <returns>retorna el objeto Viaje creado con los datos</returns>
        public static Viaje CrearViajePrueba (Crucero crucero, eCiudades destino)
        {
            string nombreDestino = destino.ToString();
            string nombrePartida = eCiudades.BuenosAires_Argentina.ToString();
            int duracion = Viaje.CalcularDuracion(nombreDestino);
            float costoPremium = Viaje.CalcularPrecioPremium(nombreDestino, duracion);
            float costoTurista = Viaje.CalcularPrecioTurista(nombreDestino, duracion);
            return new Viaje(nombrePartida, nombreDestino, DateTime.Now, crucero,
            crucero.cantidadCamarotesPremium, crucero.cantidadCamarotesTurista, costoTurista, costoPremium, duracion);
      
        }

        /// <summary>
        /// Retorna un string con el estado del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.matricula}-{this.nombre}-{this.totalDeCamarotes}-{this.salones.Count}--" +
                $"{this.cantidadCasinos}-{this.capacidadBodega}-{this.cantidadCamarotesTurista}-{this.cantidadCamarotesPremium}-" +
                $"{this.CantidadPasajerosPorCamarote}-{this.camarotesPremiumUsados}-{this.camarotesTuristaUsados}-{this.capacidadBodegaUsada}";
        }

        /// <summary>
        /// Codigo Hash del objeto
        /// </summary>
        /// <returns>retorna el codigo hash</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

        /// <summary>
        /// Verifica si el objeto this actual es igual al pasado por el parametro
        /// </summary>
        /// <param name="obj">de tipo object, a verificar si es igual al objeto this</param>
        /// <returns>si los objetos son iguales retorna true, sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Crucero)
            {
                retorno = this == ((Crucero)obj);
            }
            return retorno;
        }

    }
}
