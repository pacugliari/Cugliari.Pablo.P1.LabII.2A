using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Viaje
    {
        private eCiudades ciudadPartida;
        private eCiudades ciudadDestino;
        private DateTime fechaInicioViaje;
        private Crucero crucero;
        private int cantidadCamarotesPremium;
        private int cantidadCamarotesTurista;
        private float costoTurista;
        private float costoPremium;
        private int duracionViaje;

        public string CiudadPartida{get { return this.ciudadPartida.ToString();}}
        public string CiudadDestino { get { return this.ciudadDestino.ToString();}}
        public DateTime FechaInicioViaje { get { return this.fechaInicioViaje; } }
        public string Crucero { get { return (string)this.crucero; } }
        public string CantidadCamarotesPremium { get { return this.cantidadCamarotesPremium.ToString(); } }
        public string CantidadCamarotesTurista { get { return this.cantidadCamarotesTurista.ToString(); } }
        public string CostoTurista { get { return "$"+this.costoTurista.ToString(); } }
        public string CostoPremium { get { return "$" + this.costoPremium.ToString(); } }
        public int DuracionViaje { get { return this.duracionViaje; } }

        public static bool operator ==(Crucero crucero,Viaje viaje)
        {
            return (string)crucero == (string)viaje.crucero;
        }

        public static bool operator !=(Crucero crucero, Viaje viaje)
        {
            return !(crucero == viaje);
        }

        public static List<Viaje> filtrarViajes(List<Viaje> listaViajes ,List<Crucero> listaCruceros)
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

        public Viaje()
        {
            this.ciudadPartida = eCiudades.BuenosAires_Argentina;
            
        }

        public Viaje(string ciudadPartida, string ciudadDestino, DateTime fechaInicioViaje, Crucero crucero,
            int cantidadCamarotesPremium, int cantidadCamarotesTurista, float costoTurista, float costoPremium, int duracionViaje)
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
        }

        public static bool esRegional(string nombreDestino)
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

        public static float calcularPrecioTurista(string nombreDestino,int duracion)
        {
            float precio = 120;
            if (esRegional(nombreDestino))
                precio = 57;

            return precio*duracion;
        }

        public static float calcularPrecioPremium(string nombreDestino,int duracion)
        {
            return (float)(Viaje.calcularPrecioTurista(nombreDestino, duracion) * 1.2);
        }

        public static int calcularDuracion(string nombreDestino)
        {
            
            Random myObject = new Random();
            int duracion=0;

            if (Viaje.esRegional(nombreDestino))
            {
                duracion = myObject.Next(72, 360);
            }else
                duracion = myObject.Next(480, 720);

            return duracion;
        }

        public float calcularCostos(List<Pasajero> listaViajeros)
        {
            int cantidadDeTuristas=0;
            int cantidadDePremium=0;

            global::Crucero.Crucero.contarTiposPasajeros(listaViajeros, out cantidadDeTuristas,out cantidadDePremium);

            return (cantidadDeTuristas * this.costoTurista) + (cantidadDePremium * this.costoPremium);
        }


    }
}
