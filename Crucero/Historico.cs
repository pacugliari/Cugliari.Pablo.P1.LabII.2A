using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Historico
    {
        private List<Viaje> listaViajes;
        private static Dictionary<string, float> destinosConFacturacion;
        private static Dictionary<string, int> destinosConCantidadViajes;
        private static Dictionary<string, int> pasajerosConCantidadViajes;
        private static Dictionary<string, int> crucerosConHoras;

        public static Dictionary<string, float> DestinosConFacturacion { get { return Historico.destinosConFacturacion; } }
        public static Dictionary<string, int> PasajerosConCantidadViajes { get { return Historico.pasajerosConCantidadViajes; } }
        public static Dictionary<string, int> DestinosConCantidadViajes { get { return Historico.destinosConCantidadViajes; } }
        public static Dictionary<string, int> CrucerosConHoras { get { return Historico.crucerosConHoras; } }

        static Historico()
        {
            Historico.destinosConFacturacion = new Dictionary<string, float>();
            Historico.destinosConCantidadViajes = new Dictionary<string, int>();
            Historico.pasajerosConCantidadViajes = new Dictionary<string, int>();
            Historico.crucerosConHoras = new Dictionary<string, int>();

            foreach (int ciudad in Enum.GetValues(typeof(eCiudades)))
            {
                if(eCiudades.BuenosAires_Argentina != (eCiudades)ciudad)
                {
                    Historico.destinosConFacturacion.Add(Enum.GetName(typeof(eCiudades), ciudad).ToString(), 0);
                    Historico.destinosConCantidadViajes.Add(Enum.GetName(typeof(eCiudades), ciudad).ToString(), 0);
                }
                    
            }

            foreach (Crucero cruceros in new Flota().obtenerListaEmbarcacion())
            {
                 Historico.crucerosConHoras.Add(cruceros.Nombre, 0);
            }

            /*
            Historico.destinosConFacturacion[eCiudades.PuertoMadryn_Argentina.ToString()] += 1500;
            Historico.destinosConFacturacion[eCiudades.Santiago_Chile.ToString()] += 500;
            Historico.destinosConFacturacion[eCiudades.Taipei_Taiwan.ToString()] += 5000;*/
        }


        public static Dictionary<string, float>obtenerDestinosConFacturacion()
        {
            return Historico.destinosConFacturacion.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
        public static Dictionary<string, int> obtenerPasajerosConCantidadViajes()
        {
            return Historico.PasajerosConCantidadViajes.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public static Dictionary<string, int> obtenerCrucerosConHoras()
        {
            return Historico.CrucerosConHoras.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public static Dictionary<string, int> obtenerDestinosConCantidadViajes()
        {
            return Historico.DestinosConCantidadViajes.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
