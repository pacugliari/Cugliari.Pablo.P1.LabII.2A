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

        /// <summary>
        /// Propiedad que retorna el numero de documento en formato string de la persona
        /// </summary>
        public string NumeroDocumento { get { return this.numeroDocumento.ToString(); } }

        /// <summary>
        /// Inicializa con datos vacios un objeto derivado de persona
        /// </summary>
        private Persona()
        {
            this.nombre = this.apellido = this.numeroDocumento = this.domicilio = this.lugarNacimiento = "";
            this.sexo = ' ';
            this.nacionalidad = ePaises.Vacio;
            this.fechaNacimiento = new DateTime();
        }
        /// <summary>
        /// Incializa con nombre/apellido un objeto derivado de persona
        /// </summary>
        /// <param name="nombre">nombre de la persona</param>
        /// <param name="apellido">apellido de la persona</param>
        protected Persona(string nombre, string apellido):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Inicializa con los datos del parametro un objeto derivado de persona
        /// </summary>
        /// <param name="nombre">nombre de la persona</param>
        /// <param name="apellido">apellido de la persona</param>
        /// <param name="sexo">sexo de la persona, M->Masculino, F->Femenino</param>
        /// <param name="nacionalidad">pais de origen</param>
        /// <param name="fechaNacimiento">fecha de nacimiento de la persona</param>
        /// <param name="numeroDocumento">numero de documento de la persona</param>
        /// <param name="domicilio">domicilio de la persona</param>
        /// <param name="lugarNacimiento">lugar de nacimiento de la persona</param>
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

        /// <summary>
        /// Codigo Hash del objeto 
        /// </summary>
        /// <returns>Codigo Hash del objeto </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode(); 
        }
        
        /// <summary>
        /// Compara si el objeto actual this es igual al objeto del parametro, es comparado por la sobrecarga del ==
        /// </summary>
        /// <param name="obj">de tipo object</param>
        /// <returns>si son iguales retorna true sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Persona)
            {
                retorno = this == ((Persona)obj);
            }
            return retorno;
        }

        /// <summary>
        /// Retorna un string con el estado del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sexoLargo = this.sexo == 'M' ? "Masculino" : "Femenino";
            return $"{this.nombre}-{this.apellido}-{sexoLargo}-{this.nacionalidad}-{this.fechaNacimiento}-{this.numeroDocumento}" +
                $"-{this.domicilio}-{this.lugarNacimiento}";
        }
    }
}
