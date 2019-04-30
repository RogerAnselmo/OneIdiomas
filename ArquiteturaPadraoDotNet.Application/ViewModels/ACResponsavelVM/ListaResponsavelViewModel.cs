using System.Collections.Generic;
using System.ComponentModel;

namespace One.Application.ViewModels.ACResponsavelVM
{
    public class ListaResponsavelViewModel
    {
        public ListaResponsavelViewModel()
        {
            NomeResponsavel = "";
            ListaResponsavel = new List<ACResponsavelViewModel>();
        }

        [DisplayName("Nome do Responsável")]
        public string NomeResponsavel { get; set; }
        public IEnumerable<ACResponsavelViewModel> ListaResponsavel { get; set; }
    }
}
