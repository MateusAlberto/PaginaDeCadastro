using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaDeCadastro.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }
        public string CidadeNac { get; set; }
        public string EstadoNac { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int Idade { get; set; }
    }
}
