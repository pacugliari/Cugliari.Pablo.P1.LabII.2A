using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public abstract class Equipaje
    {
        protected bool bolsoMano;
        protected float pesosValijas;
    }
    public class EquipajeTurista:Equipaje
    {
        private bool valija;//1 SOLA
    }

    public class EquipajePremium : Equipaje
    {
        private List<bool> valijas;//2 VALIJAS, AMPLIABLE A MAS
    }
}
