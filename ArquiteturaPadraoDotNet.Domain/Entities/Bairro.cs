using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class Bairro
    {
        public int CodigoBairro { get; set; }
        public string descricao { get; set; }
        public int CodigoCidade { get; set; }

        [ForeignKey("CodigoCidade")]
        public virtual Cidade Cidade { get; set; }
    }
}
