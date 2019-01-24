using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaDeCadastro.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é necessário")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve estar entre {2} e {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é necessário")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve estar entre {2} e {1} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "{0} é necessária")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} é necessária")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho da {0} deve estar entre {2} e {1} caracteres")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "{0} é necessária")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho da {0} deve estar entre {2} e {1} caracteres")]
        [Display(Name = "Naturalidade")]
        public string CidadeNat { get; set; }

        [Required(ErrorMessage = "{0} é necessário")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Tamanho da {0} deve estar entre {2} e {1} caracteres")]
        [Display(Name = "Estado")]
        public string EstadoNat { get; set; }

        [Required(ErrorMessage = "{0} é necessário")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve estar entre {2} e {1} caracteres")]
        [Display(Name = "Nome do Pai")]
        public string NomePai { get; set; }

        [Required(ErrorMessage = "{0} é necessário")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve estar entre {2} e {1} caracteres")]
        [Display(Name = "Nome da Mãe")]
        public string NomeMae { get; set; }

        public int Idade { get; set; }
    }
}
