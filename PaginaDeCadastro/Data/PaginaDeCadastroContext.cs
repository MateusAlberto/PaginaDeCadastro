using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PaginaDeCadastro.Models
{
    public class PaginaDeCadastroContext : DbContext
    {
        public PaginaDeCadastroContext (DbContextOptions<PaginaDeCadastroContext> options)
            : base(options)
        {
        }

        public DbSet<PaginaDeCadastro.Models.Pessoa> Pessoa { get; set; }
    }
}
