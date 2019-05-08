using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace One.Application.ViewModels.ACProfessorVM
{
    public class CadastroProfessorViewModel
    {
        [Required]
        [DisplayName("Código Usuário")]
        public int CodigoUsuario { get; set; }

        [Required]
        [DisplayName("Código Professor")]
        public int CodigoProfessor { get; set; }

        [Required]
        [DisplayName("Nome do Professor")]
        public string NomeProfessor { get; set; }

        [Required]
        [DisplayName("Data de Nascimento")]
        public string DataNascimento { get; set; }

        [Required]
        [DisplayName("RG")]
        public string RG { get; set; }

        [Required]
        [DisplayName("CPF")]
        public string CPF { get; set; }
    }
}
