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

        public Pasaporte(string nombre, string apellido, char sexo, ePaises nacionalidad, DateTime fechaNacimiento, 
            string numeroDocumento,string domicilio, string lugarNacimiento,string numeroDocumentoViaje,DateTime fechaEmision,
            DateTime fechaVencimiento, ePasaportes tipoPasaporte, string codigoPaisExterior, string autoridadExpedidora) : base(nombre,apellido,
                sexo,nacionalidad,fechaNacimiento,numeroDocumento,domicilio,lugarNacimiento)
        {
            this.numeroDocumentoViaje = numeroDocumentoViaje;
            this.fechaEmision = fechaEmision;
            this.fechaVencimiento = fechaVencimiento;
            this.tipoPasaporte = tipoPasaporte;
            this.codigoPaisExterior = codigoPaisExterior;
            this.autoridadExpedidora = autoridadExpedidora;
        }
    }
}
