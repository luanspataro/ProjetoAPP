using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPP.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }

    }
}
