using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPP.Models
{
    public class AppUser
    {
        public string Id { get; set; }
        public int? Passos { get; set; }
        public int? Quilometragem { get; set; }
        public Endereco? Address { get; set; }
        public ICollection<Clube> Clubes { get; set; }
        public ICollection<Corrida> Corridas { get; set; }
    }
}
