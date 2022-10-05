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
        static  Flota()
        {
            Crucero crucero1 = new Crucero("NOR111BR", "Norwegian Breakaway", 4, new List<eSalones> {eSalones.Comedor,eSalones.Casino,
               eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Galeria,eSalones.Discoteca}, 100);
            Crucero crucero2 = new Crucero("QUE222MA", "Queen Mary 2", 5, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Discoteca}, 500);
            Crucero crucero3 = new Crucero("IND333SE", "Independence of The Seas", 1, new List<eSalones> {eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Cine,eSalones.Galeria}, 600);
            crucero3.EstaDisponible = false;
            Crucero crucero4 = new Crucero("LIB444SE", "Liberty of the Seas", 7, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina}, 700);
            Crucero crucero5 = new Crucero("FRE555SE", "Freedom of The Seas", 8, new List<eSalones> { eSalones.Comedor,eSalones.Casino,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar}, 800);
            Crucero crucero6 = new Crucero("NOR666EP", "Norvegian Epic", 9, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine}, 900);
            Crucero crucero7 = new Crucero("QUA777SE", "Quantum of The Seas", 10, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Galeria,eSalones.Discoteca,eSalones.Casino,}, 1000);
            Flota.listaCruceros = new List<Crucero> { crucero1, crucero2, crucero3, crucero4, crucero5, crucero6, crucero7 };
        }

        public static List<Crucero> ObtenerListaEmbarcacion()
        {
            return Flota.listaCruceros;
        }

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
