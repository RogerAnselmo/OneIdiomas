using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class Cidade
    {
        [Key]
        public int CodigoCidade { get; set; }
        public string Descricao { get; set; }
        public string flAtivo { get; set; }

        [ForeignKey("CodigoUF")]
        public int CodigoUF { get; set; }
        public virtual UF UF { get; set; }
    }
}
