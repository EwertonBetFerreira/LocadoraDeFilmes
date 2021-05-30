using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLocadora.Domain.Features.Filmes
{
    public class CreateFilme
    {
        public string Nome { get; set; }

        public DateTime DataCriacao { get; set; }

        public int Ativo { get; set; }

        public string Genero { get; set; }
    }
}
