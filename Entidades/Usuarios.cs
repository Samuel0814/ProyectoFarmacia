﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string PassUsuario { get; set; }
        public string Tipo { get; set; }
        public Usuarios(int id, string nombreUsuario, string passUsuario, string tipo)
        {
            this.PassUsuario = passUsuario;
            this.Id = id;
            this.NombreUsuario = nombreUsuario;
            this.Tipo = tipo;

        }

        public Usuarios()
        {

        }
    }
}
