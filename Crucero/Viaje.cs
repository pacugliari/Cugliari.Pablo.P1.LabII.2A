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
        public int CantidadPasajeros { get { return this.pasajeros.Count; } }
        public Crucero Crucero { get { return this.crucero; } }

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

        public string CiudadDestino { get { return this.ciudadDestino.ToString(); } }
        public int DuracionViaje { get { return this.duracionViaje; } }

        private Viaje()
        {
            this.pasajeros = new List<Pasajero>();
        }

        public Viaje(string ciudadDestino, string duracionViaje, string nombreCrucero, string fechaInicioViaje):this()
        {
            this.ciudadDestino = this.ciudadPartida = eCiudades.BuenosAires_Argentina;
            Enum.TryParse(ciudadDestino, out this.ciudadDestino);
            this.duracionViaje = int.Parse(duracionViaje);
            this.crucero = Flota.ObtenerEmbarcacionDeNombre(nombreCrucero);
            this.fechaInicioViaje = DateTime.Parse(fechaInicioViaje);
        }

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

        public static float CalcularPrecioTurista(string nombreDestino,int duracion)
        {
            float precio = 120;
            if (EsRegional(nombreDestino))
                precio = 57;

            return precio*duracion;
        }

        public static float CalcularPrecioPremium(string nombreDestino,int duracion)
        {
            return (float)(Viaje.CalcularPrecioTurista(nombreDestino, duracion) * 1.2);
        }

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

        public float CalcularCostos(List<Pasajero> listaViajeros)
        {
            int cantidadDeTuristas=0;
            int cantidadDePremium=0;

            Crucero.ContarTiposPasajeros(listaViajeros, out cantidadDeTuristas,out cantidadDePremium);

            return (cantidadDeTuristas * this.costoTurista) + (cantidadDePremium * this.costoPremium);
        }


        public static bool operator ==(Viaje v1, Viaje v2)
        {
            return (v1.ciudadDestino == v2.ciudadDestino && v1.duracionViaje == v2.duracionViaje && v1.crucero == v2.crucero &&
                v1.fechaInicioViaje.ToShortDateString() == v2.fechaInicioViaje.ToShortDateString());
        }

        public static bool operator !=(Viaje v1, Viaje v2)
        {
            return !(v1 == v2);
        }

        public static bool operator ==(Crucero crucero, Viaje viaje)
        {
            return (string)crucero == (string)viaje.crucero;
        }

        public static bool operator !=(Crucero crucero, Viaje viaje)
        {
            return !(crucero == viaje);
        }

        public override string ToString()
        {
            return $"{this.ciudadPartida}-{this.ciudadDestino}-{(string)this.crucero}-{this.fechaInicioViaje}-" +
                $"{this.cantidadCamarotesPremium}-{this.cantidadCamarotesTurista}-${this.costoPremium}-${this.costoTurista}-{this.duracionViaje}";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Viaje)
            {
                retorno = this == ((Viaje)obj);
            }
            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
