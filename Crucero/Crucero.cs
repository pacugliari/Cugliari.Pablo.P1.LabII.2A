using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int cantidadCamarotes;
        private List<eSalones> salones;
        private List<Pasajero> pasajeros;
        private int cantidadCasinos;
        private float capacidadBodega;
        private int cantidadCamarotesPremium;
        private bool estaDisponible;
        private int cantidadPasajerosPorCamarote;
        private int camarotesPremiumUsados;
        private int camarotesTuristaUsados;
        private float capacidadBodegaUsada;


        public bool EstaDisponible { 
            set { this.estaDisponible = value; }
            get { return this.estaDisponible; } 
        }

        public string Matricula { get { return this.matricula; } }
        public string Nombre { get { return this.nombre; } }
        public string CantidadSalones { get { return this.salones.Count.ToString(); } }
        public string CantidadCasinos { get { return this.cantidadCasinos.ToString(); } }

        public int CamarotesPremiumUsados { get { return this.camarotesPremiumUsados; } }
        public int CamarotesTuristaUsados { get { return this.camarotesTuristaUsados; } }

        public float CapacidadBodega { get { return this.capacidadBodega; } }
        public float CapacidadBodegaUsada { get { return this.capacidadBodegaUsada; } }
        public string CantidadPasajerosPorCamarote { get { return this.cantidadPasajerosPorCamarote.ToString(); } }

        public List<Pasajero> Pasajeros { get { return this.pasajeros; } }

        public Pasajero obtenerPasajero(string numeroDocumentoViaje)
        {
            Pasajero retorno = null;

            foreach (Pasajero item in this.pasajeros)
            {
                if(item.Pasaporte.NumeroDocumentoViaje == numeroDocumentoViaje)
                {
                    retorno = item;
                    break;
                }
            }

            return retorno;
        }

        public bool estaCompleto()
        {
            bool retorno = false;

            if((this.camarotesPremiumUsados == this.CamarotesPremium() && this.camarotesTuristaUsados == this.CamarotesTurista()) 
                && (this.capacidadBodegaUsada == this.capacidadBodega))
            {
                retorno = true;
            }

            return retorno;
        }

        public Crucero(string matricula,string nombre,int cantidadCamarotes,List<eSalones> salones,float capacidadBodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.salones = salones;
            this.cantidadCasinos = 0;
            this.estaDisponible = true;
            this.cantidadPasajerosPorCamarote = 4;
            this.pasajeros = new List<Pasajero>();
            this.camarotesPremiumUsados = 0;
            this.camarotesTuristaUsados = 0;
            this.capacidadBodegaUsada = 0;

            foreach (eSalones item in this.salones)
            {
                if (item == eSalones.Casino)
                    this.cantidadCasinos++;
            }

            this.capacidadBodega = capacidadBodega;

            this.cantidadCamarotesPremium = (int)(this.cantidadCamarotes * 0.35);
       
        }

        public void agregarPasajeros(List<Pasajero> viajeros)
        {
            int cantCamPremium = 0;
            int cantCamTurista = 0;
            float pesoUsado = 0;
            Crucero.calcularCamarotes(viajeros, out cantCamTurista, out cantCamPremium);
            pesoUsado = Equipaje.calcularPesoTotal(viajeros);
            this.camarotesTuristaUsados += cantCamTurista;
            this.camarotesPremiumUsados += cantCamPremium;
            this.capacidadBodegaUsada += pesoUsado;
            foreach (Pasajero item in viajeros)
            {
                this.pasajeros.Add(item);
            }
        }

        public bool tieneElSalon(eSalones salon)
        {
            bool retorno = false;
            if (this.salones.Contains(salon))
                retorno = true;

            return retorno;
        }
        public int CamarotesPremium()
        {
            return this.cantidadCamarotesPremium;
        }

        public int CamarotesTurista()
        {
            return this.cantidadCamarotes- this.cantidadCamarotesPremium;
        }

        public static explicit operator string(Crucero embarcacion)
        {
            return embarcacion.nombre;
        }


        private static int calcularCantidadCamarotes(int cantidadPasajeros)
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

        public static void contarTiposPasajeros(List<Pasajero> listaViajeros, out int cantidadTuristas, out int cantidadPremium)
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

        public static void calcularCamarotes(List<Pasajero> listaViajeros,out int cantidadCamarotesTurista,out int cantidadCamarotesPremium)
        {
            int cantidadTuristas = 0;
            int cantidadPremium = 0;

            Crucero.contarTiposPasajeros(listaViajeros,out cantidadTuristas,out cantidadPremium);

            cantidadCamarotesTurista = Crucero.calcularCantidadCamarotes(cantidadTuristas);
            cantidadCamarotesPremium = Crucero.calcularCantidadCamarotes(cantidadPremium);

        }

        public bool tieneEspacioPara(int cantidadCamarotesTurista,int cantidadCamarotesPremium,float pesoGrupoFamiliar)
        {
            bool retorno = false;
            if((this.capacidadBodega-this.capacidadBodegaUsada) >= pesoGrupoFamiliar && 
                (this.CamarotesPremium()-this.camarotesPremiumUsados) >= cantidadCamarotesPremium 
                && (this.CamarotesTurista()-this.camarotesTuristaUsados) >= cantidadCamarotesTurista)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
