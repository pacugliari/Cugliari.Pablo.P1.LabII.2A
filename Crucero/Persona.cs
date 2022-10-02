using System;

namespace Crucero
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected char sexo;
        protected ePaises nacionalidad;
        protected DateTime fechaNacimiento;
        protected string numeroDocumento;
        protected string domicilio;
        protected string lugarNacimiento;


        public string Sexo { get { return this.sexo == 'M' ? "Masculino" : "Femenino"; } }
        public string Nacionalidad { get { return this.nacionalidad.ToString(); } }
        public string FechaNacimiento { get { return this.fechaNacimiento.ToString(); } }
        public string NumeroDocumento { get { return this.numeroDocumento.ToString(); } }
        public string Domicilio { get { return this.domicilio; } }
        public string LugarNacimiento { get { return this.lugarNacimiento; } }

        public Persona()
        {
            this.nombre = this.apellido = this.numeroDocumento = this.domicilio = this.lugarNacimiento = "";
            this.sexo = ' ';
            this.nacionalidad = ePaises.Vacio;
            this.fechaNacimiento = new DateTime();
        }

        public Persona(string nombre, string apellido):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        public Persona(string nombre,string apellido,char sexo,string nacionalidad,DateTime fechaNacimiento,string numeroDocumento,
            string domicilio,string lugarNacimiento):this(nombre,apellido)
        {
            this.sexo = sexo;
            Enum.TryParse(nacionalidad,out this.nacionalidad);
            this.fechaNacimiento = fechaNacimiento;
            this.numeroDocumento = numeroDocumento;
            this.domicilio = domicilio;
            this.lugarNacimiento = lugarNacimiento;
        }
    }
}
