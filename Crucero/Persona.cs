using System;

namespace CruceroLOG
{
    abstract public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected char sexo;
        protected ePaises nacionalidad;
        protected DateTime fechaNacimiento;
        protected string numeroDocumento;
        protected string domicilio;
        protected string lugarNacimiento;

        public string NumeroDocumento { get { return this.numeroDocumento.ToString(); } }


        private Persona()
        {
            this.nombre = this.apellido = this.numeroDocumento = this.domicilio = this.lugarNacimiento = "";
            this.sexo = ' ';
            this.nacionalidad = ePaises.Vacio;
            this.fechaNacimiento = new DateTime();
        }

        protected Persona(string nombre, string apellido):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        protected Persona(string nombre,string apellido,char sexo,string nacionalidad,DateTime fechaNacimiento,string numeroDocumento,
            string domicilio,string lugarNacimiento):this(nombre,apellido)
        {
            this.sexo = sexo;
            Enum.TryParse(nacionalidad,out this.nacionalidad);
            this.fechaNacimiento = fechaNacimiento;
            this.numeroDocumento = numeroDocumento;
            this.domicilio = domicilio;
            this.lugarNacimiento = lugarNacimiento;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode(); 
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Persona)
            {
                retorno = this == ((Persona)obj);
            }
            return retorno;
        }
        public override string ToString()
        {
            string sexoLargo = this.sexo == 'M' ? "Masculino" : "Femenino";
            return $"{this.nombre}-{this.apellido}-{sexoLargo}-{this.nacionalidad}-{this.fechaNacimiento}-{this.numeroDocumento}" +
                $"-{this.domicilio}-{this.lugarNacimiento}";
        }
    }
}
