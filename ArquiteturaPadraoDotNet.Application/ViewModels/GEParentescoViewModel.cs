using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace One.Application.ViewModels
{
    public class GEParentescoViewModel
    {
        [DisplayName("Código: ")]
        public int CodigoParentesco { get; set; }

        [DisplayName("Parentesco: ")]
        [MaxLength(60)]
        public string Descricao { get; set; }

        [DisplayName("Ativo: ")]
        [MaxLength(1)]
        public string flAtivo { get; set; }
    }
}
