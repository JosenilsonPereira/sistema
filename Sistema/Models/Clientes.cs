using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class Clientes
    {
        [Key]
        public int id { get; set; }
        public String nome { get; set; }
        public string email { get; set; }
        public String telefone { get; set; }
        public String cep { get; set; }
        public String rua { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String uf { get; set; }
        public int ibge { get; set; }
    }
}