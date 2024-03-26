using Microsoft.EntityFrameworkCore;
using ProjetoAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Corrida> Corridas { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
