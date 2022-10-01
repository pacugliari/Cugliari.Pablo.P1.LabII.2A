using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Pasaporte : Persona
    {
        private string numeroDocumentoViaje;//ZZZ000104
        private DateTime fechaEmision;
        private DateTime fechaVencimiento;
        private ePasaportes tipoPasaporte;
        private string codigoPaisExterior;
        private string autoridadExpedidora;

        public string NumeroDocumentoViaje { get { return this.numeroDocumentoViaje; } }
        public DateTime FechaEmision { get { return this.fechaEmision; } }
        public DateTime FechaVencimiento { get { return this.fechaVencimiento; } }
        public string TipoPasaporte { get { return this.tipoPasaporte.ToString(); } }
        public string CodigoPaisExterior { get { return this.codigoPaisExterior; } }
        public string AutoridadExpedidora { get { return this.autoridadExpedidora; } }

        public Pasaporte(string nombre, string apellido, char sexo, string nacionalidad, DateTime fechaNacimiento, 
            string numeroDocumento,string domicilio, string lugarNacimiento,string numeroDocumentoViaje,DateTime fechaEmision,
            DateTime fechaVencimiento, string tipoPasaporte, string codigoPaisExterior, string autoridadExpedidora) : base(nombre,apellido,
                sexo,nacionalidad,fechaNacimiento,numeroDocumento,domicilio,lugarNacimiento)
        {
            this.numeroDocumentoViaje = numeroDocumentoViaje;
            this.fechaEmision = fechaEmision;
            this.fechaVencimiento = fechaVencimiento;
            Enum.TryParse(tipoPasaporte, out this.tipoPasaporte);
            this.codigoPaisExterior = codigoPaisExterior;
            this.autoridadExpedidora = autoridadExpedidora;
        }
    }
}
