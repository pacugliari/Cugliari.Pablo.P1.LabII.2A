using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Equipaje
    {
        private bool bolsoMano;
        private int valijas;
        private static int pesoBolso;
        private static int pesoValija;

        //PESO BOLSO Y VALIJAS DE 25KG

        public bool BolsoMano { get { return this.bolsoMano; } }
        public int Valijas { get { return this.valijas; } }

        static Equipaje()
        {
            Equipaje.pesoBolso = Equipaje.pesoValija = 25;
        }
        public Equipaje(bool bolsoMano, int valijas) 
        {
            this.bolsoMano = bolsoMano;
            this.valijas = valijas;
        }

        public static float calcularPesoTotal(List<Pasajero> listaViajeros)
        {
            float retorno = 0;
            Equipaje equipaje;
          
            foreach (Pasajero item in listaViajeros)
            {
                equipaje = item.Equipaje;
                if (equipaje.bolsoMano)
                {
                    retorno += Equipaje.pesoBolso;
                }
                retorno += equipaje.valijas * Equipaje.pesoValija;
            }
            return retorno;
        }
    }
}
