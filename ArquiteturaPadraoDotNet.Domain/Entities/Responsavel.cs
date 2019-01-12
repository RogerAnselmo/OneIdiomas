using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
public     class Responsavel
    {
        public int CodigoResponsavel { get; set; }
        public string CPF { get; set; }
        public string NomeCompleto { get; set; }
        public int CodigoEndereco { get; set; }
        public string flAtivo { get; set; }

        [ForeignKey("CodigoEndereco")]
        public Endereco Endereco { get; set; }
    }
}
