using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Embarcacion
    {
        private string matricula;///IDENTIFICADOR ALFANUMERICO DE 8 DIGITOS
        private string nombre;
        private int cantidadCamarotes;//35% son premium
        private int cantidadSalones;
        private int cantidadCasinos;
        private float capacidadBodega;
        private int cantidadCamarotesPremium;

        public Embarcacion(string matricula,string nombre,int cantidadCamarotes,int cantidadSalones,int cantidadCasinos,float capacidadBodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.cantidadSalones = cantidadSalones;
            this.cantidadCasinos = cantidadCasinos;
            this.capacidadBodega = capacidadBodega;

            this.cantidadCamarotesPremium = (int)(this.cantidadCamarotes * 0.35);
       
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
    }
}
