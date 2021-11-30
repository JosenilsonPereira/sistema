using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public String NomeUsuario { get; set; }
        public  String SenhaUsuario { get; set; }
    }
}