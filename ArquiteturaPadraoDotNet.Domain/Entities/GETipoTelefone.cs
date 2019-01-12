using System.ComponentModel.DataAnnotations;

namespace One.Domain.Entities
{
    public class GETipoTelefone
    {
        #region GETipoTelefone
        [Key]
        public int CodigoTipoTelefone { get; set; }

        [Required]
        [MaxLength(30)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; } 
        #endregion
    }
}
