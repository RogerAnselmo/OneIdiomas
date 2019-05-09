using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels.ACProfessorVM
{
    public class ListaProfessorViewModel
    {
        [DisplayName("Nome do Professor")]
        public string NomeProfessor { get; set; }
        public IEnumerable<ACProfessorViewModel> ListaProfessores { get; set; }
    }
}
