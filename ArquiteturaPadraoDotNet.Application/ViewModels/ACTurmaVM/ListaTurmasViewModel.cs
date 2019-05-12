using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels.ACTurmaVM
{
    public class ListaTurmaViewModel
    {
        public ListaTurmaViewModel()
        {
            FiltroTurma = "";
            ListaTurma = new List<ACTurmaViewModel>();
        }

        [DisplayName("Filtro")]
        public string FiltroTurma { get; set; }
        public IEnumerable<ACTurmaViewModel> ListaTurma { get; set; }
    }
}
