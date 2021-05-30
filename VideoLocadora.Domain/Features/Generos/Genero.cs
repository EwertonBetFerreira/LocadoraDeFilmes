using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLocadora.Domain.Features.Generos
{
    public class Genero
    {
        //Classe que define as propriedades da entidade GENERO

        //Seta a chave primaria da tabela e informa que é gerenciada pela database
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataCriacao { get; set; }

        public int Ativo { get; set; }
    }
}
