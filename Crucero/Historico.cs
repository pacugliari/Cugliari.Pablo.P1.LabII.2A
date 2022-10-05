using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public static class Historico
    {
        private static Dictionary<string, float> destinosConFacturacion;
        private static Dictionary<string, int> destinosConCantidadViajes;
        private static Dictionary<string, int> pasajerosConCantidadViajes;
        private static Dictionary<string, int> crucerosConHoras;
        private static Dictionary<DateTime, string> fechasOcupadasViajes;

        /// <summary>
        /// Propiedad para obtener los destinos y su facturacion
        /// </summary>
        public static Dictionary<string, float> DestinosConFacturacion { get { return Historico.destinosConFacturacion; } }
        /// <summary>
        /// Propiedad para obtener los pasajeros y sus cantidad de viajes
        /// </summary>
        public static Dictionary<string, int> PasajerosConCantidadViajes { get { return Historico.pasajerosConCantidadViajes; } }
        /// <summary>
        /// Propiedad para obtener los destinos con la cantidad de viajes
        /// </summary>
        public static Dictionary<string, int> DestinosConCantidadViajes { get { return Historico.destinosConCantidadViajes; } }
        /// <summary>
        /// Propiedad para obtener la cantidad de horas del crucero y su nombre
        /// </summary>
        public static Dictionary<string, int> CrucerosConHoras { get { return Historico.crucerosConHoras; } }

        /// <summary>
        /// Constructor estatico que iniciliza los atributos ,los destinos validos y los cruceros 
        /// </summary>
        static Historico()
        {
            Historico.destinosConFacturacion = new Dictionary<string, float>();
            Historico.destinosConCantidadViajes = new Dictionary<string, int>();
            Historico.pasajerosConCantidadViajes = new Dictionary<string, int>();
            Historico.crucerosConHoras = new Dictionary<string, int>();
            Historico.fechasOcupadasViajes = new Dictionary<DateTime, string>();

            foreach (int ciudad in Enum.GetValues(typeof(eCiudades)))
            {
                if (eCiudades.BuenosAires_Argentina != (eCiudades)ciudad)
                {
                    Historico.destinosConFacturacion.Add(Enum.GetName(typeof(eCiudades), ciudad).ToString(), 0);
                    Historico.destinosConCantidadViajes.Add(Enum.GetName(typeof(eCiudades), ciudad).ToString(), 0);
                }

            }

            foreach (Crucero cruceros in Flota.ObtenerListaEmbarcacion())
            {
                Historico.crucerosConHoras.Add(cruceros.Nombre, 0);
            }

            /*
            Historico.destinosConFacturacion[eCiudades.PuertoMadryn_Argentina.ToString()] += 1500;
            Historico.destinosConFacturacion[eCiudades.Santiago_Chile.ToString()] += 500;
            Historico.destinosConFacturacion[eCiudades.Taipei_Taiwan.ToString()] += 5000;*/

            

        }

        /// <summary>
        /// Obtiene un diccionario ordenado de manera descendente de los destinos y su facturacion
        /// </summary>
        /// <returns>Diccionario con nombre de destino como key y facturacion como valor </returns>
        public static Dictionary<string, float>obtenerDestinosConFacturacion()
        {
            return Historico.destinosConFacturacion.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        /// <summary>
        /// Obtiene un diccionario ordenado de manera descendente de los pasajeros y las cantidad de viajes
        /// </summary>
        /// <returns>Diccionario ordenado con dni de key y cantidad de viajes como valor</returns>
        public static Dictionary<string, int> obtenerPasajerosConCantidadViajes()
        {
            return Historico.PasajerosConCantidadViajes.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        /// <summary>
        /// Obtiene un diccionario ordenado de manera descendente de los cruceros y sus horas viajadas
        /// </summary>
        /// <returns>Diccionario ordenado con nombreCrucero como key y las horas viajadas como valor</returns>
        public static Dictionary<string, int> obtenerCrucerosConHoras()
        {
            return Historico.CrucerosConHoras.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
        /// <summary>
        /// Obtiene un diccionario ordenado de manera descendente de los destinos y sus cantidad de viajes a ese lugar
        /// </summary>
        /// <returns>Diccionario ordenado con nombreDestino como key y cantidad de viajes como valor </returns>
        public static Dictionary<string, int> obtenerDestinosConCantidadViajes()
        {
            return Historico.DestinosConCantidadViajes.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
