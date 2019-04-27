using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels.ACAlunoVM
{
    public class ListaAlunoViewModel
    {
        public ListaAlunoViewModel()
        {
            NomeAluno = "";
            ListaAlunos = new List<ACAlunoViewModel>();
        }

        [DisplayName("Nome do Aluno")]
        public string NomeAluno { get; set; }
        public IEnumerable<ACAlunoViewModel> ListaAlunos { get; set; }
            }
}
