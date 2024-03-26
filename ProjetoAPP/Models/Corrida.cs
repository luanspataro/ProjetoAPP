using ProjetoAPP.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPP.Models
{
    public class Corrida
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }
        [ForeignKey("Endereco")]
        public int? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public CorridaCategoria CorridaCategoria { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
