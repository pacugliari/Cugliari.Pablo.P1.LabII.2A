using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Flota
    {
        List<Embarcacion> listaCruceros;
        public  Flota()
        {
            Embarcacion crucero1 = new Embarcacion("NOR111BR", "Norwegian Breakaway", 4, new List<eSalones> {eSalones.Comedor,eSalones.Casino,
               eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Galeria,eSalones.Discoteca}, 400);
            Embarcacion crucero2 = new Embarcacion("QUE222MA", "Queen Mary 2", 5, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Discoteca}, 500);
            Embarcacion crucero3 = new Embarcacion("IND333SE", "Independence of The Seas", 1, new List<eSalones> {eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Cine,eSalones.Galeria}, 600);
            crucero3.EstaDisponible = true;
            Embarcacion crucero4 = new Embarcacion("LIB444SE", "Liberty of the Seas", 7, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina}, 700);
            Embarcacion crucero5 = new Embarcacion("FRE555SE", "Freedom of The Seas", 8, new List<eSalones> { eSalones.Comedor,eSalones.Casino,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar}, 800);
            Embarcacion crucero6 = new Embarcacion("NOR666EP", "Norvegian Epic", 9, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine}, 900);
            Embarcacion crucero7 = new Embarcacion("QUA777SE", "Quantum of The Seas", 10, new List<eSalones> { eSalones.Comedor,eSalones.Gimnasio,
                eSalones.Piscina,eSalones.Spa,eSalones.Bar,eSalones.Teatro,eSalones.Cine,eSalones.Galeria,eSalones.Discoteca,eSalones.Casino,}, 1000);
            this.listaCruceros = new List<Embarcacion> { crucero1, crucero2, crucero3, crucero4, crucero5, crucero6, crucero7 };
        }

        public List<Embarcacion> obtenerListaEmbarcacion()
        {
            return this.listaCruceros;
        }

        public static List<Embarcacion> filtrarFlota(Flota flota,List<eSalones> necesidadesPasajero,List<Viajero> listaViajeros)
        {
            List<Embarcacion> filtrada = new List<Embarcacion>();
            List<Embarcacion> filtrada2 = new List<Embarcacion>();
            bool tieneTodos = true;
            foreach (Embarcacion cruceroIndice in flota.listaCruceros)
            {
                tieneTodos = true;
                foreach (eSalones salon in necesidadesPasajero)
                {
                    if (!cruceroIndice.tieneElSalon(salon))
                    {
                        tieneTodos = false;
                    }   
                }
                if (tieneTodos)
                    filtrada.Add(cruceroIndice);
            }

            int cantidadCamarotesTurista=0;
            int cantidadCamarotesPremium=0;
            float pesoGrupoFamiliar = Equipaje.calcularPesoTotal(listaViajeros);

            Embarcacion.calcularCamarotes(listaViajeros,out cantidadCamarotesTurista,out cantidadCamarotesPremium);
            foreach (Embarcacion cruceroIndice in filtrada)
            {
                if (cruceroIndice.tieneEspacioPara(cantidadCamarotesTurista, cantidadCamarotesPremium, pesoGrupoFamiliar))
                {
                    filtrada2.Add(cruceroIndice);
                }    
            }

            return filtrada2;
        }

        public Embarcacion obtenerEmbarcacionDeNombre (string nombreCrucero)
        {
            Embarcacion retorno = null;
            foreach (Embarcacion cruceroIndice in this.listaCruceros)
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
