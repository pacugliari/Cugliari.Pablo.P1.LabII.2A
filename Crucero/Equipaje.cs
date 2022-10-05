using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public class Equipaje
    {
        private bool bolsoMano;
        private int valijas;
        private static int pesoBolso;
        private static int pesoValija;

        //PESO BOLSO Y VALIJAS DE 25KG
        /// <summary>
        /// Propiedad para obtener si el pasajero tiene bolso de mano
        /// </summary>
        public bool BolsoMano { get { return this.bolsoMano; } }
        /// <summary>
        /// Propiedad para obtener la cantidad de valijas del pasajero
        /// </summary>
        public int Valijas { get { return this.valijas; } }

        /// <summary>
        /// Constructor estatico que iniciliza el peso de los bolsos y las valijas comun a todas las instancias
        /// </summary>
        static Equipaje()
        {
            Equipaje.pesoBolso = Equipaje.pesoValija = 25;
        }

        /// <summary>
        /// Constructor para inicializar el bolso de mano y la cantidad de valijas
        /// </summary>
        /// <param name="bolsoMano">si es true tiene bolso sino false</param>
        /// <param name="valijas">cantidad de valijas que poseee el pasajero</param>
        public Equipaje(bool bolsoMano, int valijas) 
        {
            this.bolsoMano = bolsoMano;
            this.valijas = valijas;
        }

        /// <summary>
        /// Retorna el peso total de una lista de pasajeros tomando en cuenta si tiene bolso, y cantidad de valijas
        /// </summary>
        /// <param name="listaViajeros">lista generica de pasajeros</param>
        /// <returns>peso total de los pasajeros de la lista</returns>
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

        /// <summary>
        /// Retorna un string con el estado del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.bolsoMano}-{this.valijas}";
        }

        /// <summary>
        /// Retorna el codigo Hash del objeto
        /// </summary>
        /// <returns>codigo Hash</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Compara si el objeto actual this es igual al del parametro
        /// </summary>
        /// <param name="obj">de tipo object</param>
        /// <returns>si el objeto actual this es igual al del parametro retorna true, sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Equipaje)
            {
                retorno = this == ((Equipaje)obj);
            }
            return retorno;
        }
    }
}
