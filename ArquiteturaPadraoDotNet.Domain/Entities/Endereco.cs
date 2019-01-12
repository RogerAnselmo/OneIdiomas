using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class Endereco
    {
        public int CodigoEndereco { get; set; }
        public int Numero { get; set; }
        public string  Logradouro { get; set; }
        public int CodigoBairro { get; set; }

        [ForeignKey("CodigoBairro")]
        public Bairro Bairro { get; set; }
    }
}
