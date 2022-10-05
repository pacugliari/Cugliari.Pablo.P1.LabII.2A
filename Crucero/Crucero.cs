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

        static Crucero()
        {
            Crucero.cantidadPasajerosPorCamarote = 4;
        }

        public bool EstaDisponible {
            set { this.estaDisponible = value; }
            get { return this.estaDisponible; }
        }

        public string Nombre { get { return this.nombre; } }
        public int CamarotesPremiumLibres { get { return this.cantidadCamarotesPremium - this.camarotesPremiumUsados; } }
        public int CamarotesTuristaLibres { get { return this.cantidadCamarotesTurista - this.camarotesTuristaUsados; } }
        public int CamarotesPremium{ get { return this.cantidadCamarotesPremium ; } }
        public int CamarotesTurista{ get { return this.cantidadCamarotesTurista; } }
        public float CapacidadBodegaLibre { get { return this.capacidadBodega-this.capacidadBodegaUsada; } }
        public string CantidadPasajerosPorCamarote { get { return Crucero.cantidadPasajerosPorCamarote.ToString(); } }

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

        public static void CalcularCamarotes(List<Pasajero> listaViajeros, out int cantidadCamarotesTurista, out int cantidadCamarotesPremium)
        {
            int cantidadTuristas = 0;
            int cantidadPremium = 0;

            Crucero.ContarTiposPasajeros(listaViajeros, out cantidadTuristas, out cantidadPremium);

            cantidadCamarotesTurista = Crucero.CalcularCantidadCamarotes(cantidadTuristas);
            cantidadCamarotesPremium = Crucero.CalcularCantidadCamarotes(cantidadPremium);

        }

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

        public void ActualizarDisponibilidad(int cantCamTurista,int cantCamPremium,float pesoUsado)
        {
            this.camarotesTuristaUsados += cantCamTurista;
            this.camarotesPremiumUsados += cantCamPremium;
            this.capacidadBodegaUsada += pesoUsado;
        }

        public bool TieneElSalon(eSalones salon)
        {
            bool retorno = false;
            if (this.salones.Contains(salon))
                retorno = true;

            return retorno;
        }

        public static explicit operator string(Crucero embarcacion)
        {
            return embarcacion.nombre;
        }

        public static bool operator ==(Crucero c1,Crucero c2)
        {
            return (c1.nombre == c2.nombre);
        }

        public static bool operator !=(Crucero c1, Crucero c2)
        {
            return !(c1 == c2);
        }

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

        public override string ToString()
        {
            return $"{this.matricula}-{this.nombre}-{this.totalDeCamarotes}-{this.salones.Count}--" +
                $"{this.cantidadCasinos}-{this.capacidadBodega}-{this.cantidadCamarotesTurista}-{this.cantidadCamarotesPremium}-" +
                $"{this.CantidadPasajerosPorCamarote}-{this.camarotesPremiumUsados}-{this.camarotesTuristaUsados}-{this.capacidadBodegaUsada}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

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
