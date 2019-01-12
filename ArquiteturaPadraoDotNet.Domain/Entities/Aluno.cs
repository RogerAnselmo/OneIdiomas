using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class Aluno
    {
        public int CodigoALuno { get; set; }
        public string NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public string flAtivo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CodigoEndereco { get; set; }

        [ForeignKey("CodigoEndereco")]
        public Endereco Endereco { get; set; }

        public int Idade() {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month || 
                (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                idade--;

            return idade;
        }

    }
}
