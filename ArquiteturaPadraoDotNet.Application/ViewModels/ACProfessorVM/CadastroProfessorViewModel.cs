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
        public int Codigoprofessor { get; set; }

        [Required]
        [DisplayName("Nome do Professor")]
        public string NomeProfessor { get; set; }

        [Required]
        [DisplayName("Data de Nascimento")]
        public string DataNascimento { get; set; }
    }
}
