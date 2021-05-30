using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLocadora.Domain.Features.Locacoes
{
    public class Locacao
    {
        //Seta a chave primaria da tabela e informa que é gerenciada pela database
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ListaFilmes { get; set; }

        public string CPFCliente { get; set; }

        public DateTime DataLocacao { get; set; }
    }
}
