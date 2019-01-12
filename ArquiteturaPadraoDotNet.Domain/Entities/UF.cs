using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace One.Domain.Entities
{
    public class UF
    {
        [Key]
        public int CodigoUF { get; set; }
        public string  Descricao { get; set; }
        public string Sigla { get; set; }
        public bool flAtivo { get; set; }

        public virtual IEnumerable<Cidade> Cidades { get; set; }
    }
}
