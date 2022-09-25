using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Viaje
    {
        private eCiudades ciudadPartida;
        private eCiudades ciudadDestino;
        private DateTime fechaInicioViaje;
        private Embarcacion crucero;
        private int cantidadCamarotesPremium;
        private int cantidadCamarotesTurista;
        private float costoTurista;
        private float costoPremium;
        private int duracionViaje;

        public Viaje(string ciudadPartida, string ciudadDestino, DateTime fechaInicioViaje, Embarcacion crucero,
            int cantidadCamarotesPremium, int cantidadCamarotesTurista, float costoTurista, float costoPremium, int duracionViaje)
        {
            Enum.TryParse(ciudadPartida, out this.ciudadPartida);
            Enum.TryParse(ciudadDestino, out this.ciudadDestino);
            this.fechaInicioViaje = fechaInicioViaje;
            this.crucero = crucero;
            this.cantidadCamarotesPremium = cantidadCamarotesPremium;
            this.cantidadCamarotesTurista = cantidadCamarotesTurista;
            this.costoTurista = costoTurista;
            this.costoPremium = costoPremium;
            this.duracionViaje = duracionViaje;
        }
        
        public static explicit operator string(Viaje viaje)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"{viaje.ciudadPartida} | {viaje.ciudadDestino} | {(string)viaje.crucero} | {viaje.fechaInicioViaje}           | " +
                $"{viaje.cantidadCamarotesPremium}      | {viaje.cantidadCamarotesTurista}      | ${viaje.costoPremium} | ${viaje.costoTurista} | " +
                $"{viaje.duracionViaje}");

            return texto.ToString();
        }


        private static bool esRegional(string nombreDestino)
        {
            bool retorno = false;
            eCiudades destino;
            if (Enum.TryParse(nombreDestino, out destino))
            {
                if (((int)destino) >= 0 && ((int)destino) <= 9)//SI ESTA ENTRE 0 Y 9 ES UN DESTINO REGIONAL
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static float calcularPrecioTurista(string nombreDestino,int duracion)
        {
            float precio = 120;
            if (esRegional(nombreDestino))
                precio = 57;

            return precio*duracion;
        }

        public static float calcularPrecioPremium(string nombreDestino,int duracion)
        {
            return (float)(Viaje.calcularPrecioTurista(nombreDestino, duracion) * 1.2);
        }

        public static int calcularDuracion(string nombreDestino)
        {
            
            Random myObject = new Random();
            int duracion=0;

            if (Viaje.esRegional(nombreDestino))
            {
                duracion = myObject.Next(72, 360);
            }else
                duracion = myObject.Next(480, 720);

            return duracion;
        }

    }
}
