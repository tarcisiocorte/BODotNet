using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TccpDotNet.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string CNPJ { get; set; }
        public string CNPJCompleto { get; set; }
        public string IE { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
    }
}
