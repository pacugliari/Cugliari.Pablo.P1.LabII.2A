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
            Embarcacion crucero1 = new Embarcacion("NOR111BR", "Norwegian Breakaway", 4, 1, 0, 400);
            Embarcacion crucero2 = new Embarcacion("QUE222MA", "Queen Mary 2", 5, 2, 1, 500);
            Embarcacion crucero3 = new Embarcacion("IND333SE", "Independence of The Seas", 6, 3, 2, 600);
            Embarcacion crucero4 = new Embarcacion("LIB444SE", "Liberty of the Seas", 7, 4, 0, 700);
            Embarcacion crucero5 = new Embarcacion("FRE555SE", "Freedom of The Seas", 8, 5, 1, 800);
            Embarcacion crucero6 = new Embarcacion("NOR666EP", "Norvegian Epic", 9, 6, 2, 900);
            Embarcacion crucero7 = new Embarcacion("QUA777SE", "Quantum of The Seas", 10, 6, 0, 1000);
            this.listaCruceros = new List<Embarcacion> { crucero1, crucero2, crucero3, crucero4, crucero5, crucero6, crucero7 };
        }

        public List<Embarcacion> obtenerListaEmbarcacion()
        {
            return this.listaCruceros;
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
