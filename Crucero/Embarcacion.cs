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
        private List<eSalones> salones;
        private List<Persona> personas;
        private int cantidadCasinos;
        private float capacidadBodega;
        private int cantidadCamarotesPremium;

        public Embarcacion(string matricula,string nombre,int cantidadCamarotes,List<eSalones> salones,float capacidadBodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.salones = salones;
            this.cantidadSalones = this.salones.Count;
            this.cantidadCasinos = 0;
            foreach (eSalones item in this.salones)
            {
                if (item == eSalones.Casino)
                    this.cantidadCasinos++;
            }

            this.capacidadBodega = capacidadBodega;

            this.cantidadCamarotesPremium = (int)(this.cantidadCamarotes * 0.35);
       
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
    }
}
