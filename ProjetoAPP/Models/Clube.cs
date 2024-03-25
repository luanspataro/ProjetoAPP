﻿using ProjetoAPP.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPP.Models
{
    public class Clube
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }
        [ForeignKey("Endereco")]
        public int? EnderecoId { get; set; }
        public Endereco? Address { get; set; }
        public ClubeCategoria ClubeCategoria { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}