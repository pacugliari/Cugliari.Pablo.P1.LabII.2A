using System;

namespace Crucero
{
    public class Persona
    {
        protected string nombre;//28 CARACTERES
        protected string apellido;//28 CARACTERES
        private char sexo;//1 CARACTER
        private ePaises nacionalidad;//18 CARACTERES
        private DateTime fechaNacimiento;
        private string numeroDocumento;
        private string domicilio;
        private string lugarNacimiento;

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


        public Persona(string nombre,string apellido,char sexo,ePaises nacionalidad,DateTime fechaNacimiento,string numeroDocumento,
            string domicilio,string lugarNacimiento):this(nombre,apellido)
        {
            this.sexo = sexo;
            this.nacionalidad = nacionalidad;
            this.fechaNacimiento = fechaNacimiento;
            this.numeroDocumento = numeroDocumento;
            this.domicilio = domicilio;
            this.lugarNacimiento = lugarNacimiento;
        }
    }
}
