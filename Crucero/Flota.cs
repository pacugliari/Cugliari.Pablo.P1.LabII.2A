using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceroLOG
{
    public static class Flota
    {
        private static List<Crucero> listaCruceros;

        /// <summary>
        /// Constructor estatico que inicializa 7 cruceros con sus nombre,caracteristicas y los agrega a la lista de cruceros
        /// </summary>
        static  Flota()
        {
            Crucero crucero1 = new Crucero("NOR111BR", "Norwegian Breakaway", 4, new List<eSalones> {eSalones.Comedor,eSalones.Casino,
               eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Galeria,eSalones.Discoteca}, 100);
            Crucero crucero2 = new Crucero("QUE222MA", "Queen Mary 2", 5, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Discoteca}, 500);
            Crucero crucero3 = new Crucero("IND333SE", "Independence of The Seas", 1, new List<eSalones> {eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Cine,eSalones.Galeria}, 600);
            Crucero crucero4 = new Crucero("LIB444SE", "Liberty of the Seas", 7, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina}, 700);
            Crucero crucero5 = new Crucero("FRE555SE", "Freedom of The Seas", 8, new List<eSalones> { eSalones.Comedor,eSalones.Casino,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar}, 800);
            Crucero crucero6 = new Crucero("NOR666EP", "Norvegian Epic", 9, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine}, 900);
            Crucero crucero7 = new Crucero("QUA777SE", "Quantum of The Seas", 10, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Galeria,eSalones.Discoteca,eSalones.Casino,}, 1000);

            crucero3.EstaDisponible = false;
            crucero6.EstaDisponible = false;
            Flota.listaCruceros = new List<Crucero> { crucero1, crucero2, crucero3, crucero4, crucero5, crucero6, crucero7 };
        }

        /// <summary>
        /// Retorna la lista de cruceros de la flota
        /// </summary>
        /// <returns>Lista de cruceros</returns>
        public static List<Crucero> ObtenerListaEmbarcacion()
        {
            return Flota.listaCruceros;
        }

        /// <summary>
        /// Obtiene una lista filtrada segun las necesidades del pasajero de una lista de viajeros/pasajeros
        /// </summary>
        /// <param name="necesidadesPasajero">List de eSalones requeridos por el pasajero</param>
        /// <param name="listaViajeros">Lista de pasajeros que contienen el peso y numero de camarotes necesarios</param>
        /// <returns>Lista filtrada segun las necesidades</returns>
        public static List<Crucero> FiltrarFlota(List<eSalones> necesidadesPasajero,List<Pasajero> listaViajeros)
        {
            List<Crucero> filtrada = new List<Crucero>();
            List<Crucero> filtrada2 = new List<Crucero>();
            int cantidadCamarotesTurista = 0;
            int cantidadCamarotesPremium = 0;
            bool tieneTodos = true;
            float pesoGrupoFamiliar;

            foreach (Crucero cruceroIndice in Flota.listaCruceros)
            {
                tieneTodos = true;
                foreach (eSalones salon in necesidadesPasajero)
                {
                    if (!cruceroIndice.TieneElSalon(salon))
                    {
                        tieneTodos = false;
                    }   
                }
                if (tieneTodos)
                    filtrada.Add(cruceroIndice);
            }
            pesoGrupoFamiliar = Equipaje.calcularPesoTotal(listaViajeros);

            Crucero.CalcularCamarotes(listaViajeros,out cantidadCamarotesTurista,out cantidadCamarotesPremium);
            foreach (Crucero cruceroIndice in filtrada)
            {
                if (cruceroIndice.TieneEspacioPara(cantidadCamarotesTurista, cantidadCamarotesPremium, pesoGrupoFamiliar))
                {
                    filtrada2.Add(cruceroIndice);
                }    
            }

            return filtrada2;
        }

        /// <summary>
        /// Busca en la lista de cruceros si alguno corresponde con el nombre del parametro
        /// </summary>
        /// <param name="nombreCrucero">nombre del crucero</param>
        /// <returns>Si se encuentra en la lista retorna el Crucero sino null</returns>
        public static Crucero ObtenerEmbarcacionDeNombre (string nombreCrucero)
        {
            Crucero retorno = null;
            foreach (Crucero cruceroIndice in Flota.listaCruceros)
            {
                if((string)cruceroIndice == nombreCrucero)
                {
                    retorno = cruceroIndice;
                    break;
                }
            }
            return retorno;
        }

    }
}
