using Microsoft.EntityFrameworkCore;
using PaginaDeCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PaginaDeCadastro.Services
{
    public class PessoaServices
    {
        private readonly PaginaDeCadastroContext _context;

        public PessoaServices(PaginaDeCadastroContext context)
        {
            _context = context;
        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoa.ToList();
        }
    }
}
