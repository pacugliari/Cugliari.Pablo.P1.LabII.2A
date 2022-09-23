﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero
{
    public class Vendedor : Persona
    {
        private string usuario;
        private string contrasenia;
        private DateTime fechaActual;

        public Vendedor(string usuario,string contrasenia, string nombre, string apellido) :base(nombre,apellido)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.fechaActual = DateTime.Now;
        }

        public static bool operator ==(Vendedor vendedor1,Vendedor vendedor2)
        {
            return ((vendedor1.usuario == vendedor2.usuario) && (vendedor1.contrasenia == vendedor2.contrasenia));
        }

        public static bool operator !=(Vendedor vendedor1, Vendedor vendedor2)
        {
            return !(vendedor1==vendedor2);
        }

        public static explicit operator string(Vendedor usuario)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Nombre: {usuario.nombre}");
            texto.AppendLine($"Apellido: {usuario.apellido}");
            texto.AppendLine($"Fecha actual: {usuario.fechaActual.ToShortDateString()}");
            return texto.ToString();
        }
    }
}
