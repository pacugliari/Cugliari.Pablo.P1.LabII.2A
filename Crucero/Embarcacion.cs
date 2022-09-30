using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Embarcacion
    {
        private string matricula;
        private string nombre;
        private int cantidadCamarotes;
        private int cantidadSalones;
        private List<eSalones> salones;
        private List<Viajero> personas;
        private int cantidadCasinos;
        private float capacidadBodega;
        private int cantidadCamarotesPremium;
        private bool estaDisponible;
        private int cantidadPasajerosPorCamarote;


        public bool EstaDisponible { 
            set { this.estaDisponible = value; }
            get { return this.estaDisponible; } 
        }

        public Embarcacion(string matricula,string nombre,int cantidadCamarotes,List<eSalones> salones,float capacidadBodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.salones = salones;
            this.cantidadSalones = this.salones.Count;
            this.cantidadCasinos = 0;
            this.estaDisponible = true;
            this.cantidadPasajerosPorCamarote = 4;

            foreach (eSalones item in this.salones)
            {
                if (item == eSalones.Casino)
                    this.cantidadCasinos++;
            }

            this.capacidadBodega = capacidadBodega;

            this.cantidadCamarotesPremium = (int)(this.cantidadCamarotes * 0.35);
       
        }

        public void agregarPasajeros(List<Viajero> viajeros)
        {
            foreach (Viajero item in viajeros)
            {
                this.personas.Add(item);
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

        public static explicit operator string(Embarcacion embarcacion)
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

        public static void contarTiposPasajeros(List<Viajero> listaViajeros, out int cantidadTuristas, out int cantidadPremium)
        {
            cantidadTuristas = 0;
            cantidadPremium = 0;

            foreach (Viajero item in listaViajeros)
            {
                if (item.EsPremium)
                {
                    cantidadPremium++;
                }
                else
                    cantidadTuristas++;
            }
        }

        public static void calcularCamarotes(List<Viajero> listaViajeros,out int cantidadCamarotesTurista,out int cantidadCamarotesPremium)
        {
            int cantidadTuristas = 0;
            int cantidadPremium = 0;

            Embarcacion.contarTiposPasajeros(listaViajeros,out cantidadTuristas,out cantidadPremium);

            cantidadCamarotesTurista = Embarcacion.calcularCantidadCamarotes(cantidadTuristas);
            cantidadCamarotesPremium = Embarcacion.calcularCantidadCamarotes(cantidadPremium);

        }

        public bool tieneEspacioPara(int cantidadCamarotesTurista,int cantidadCamarotesPremium,float pesoGrupoFamiliar)
        {
            bool retorno = false;
            if(this.capacidadBodega >= pesoGrupoFamiliar && this.CamarotesPremium() >= cantidadCamarotesPremium 
                && this.CamarotesTurista() >= cantidadCamarotesTurista)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
