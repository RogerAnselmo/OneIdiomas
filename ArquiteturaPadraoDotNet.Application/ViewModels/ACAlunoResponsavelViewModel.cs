using One.Domain.Validation;
using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class ACAlunoResponsavelViewModel
    {
        #region ACAlunoResponsavel
        [DisplayName("Código Aluno Responsável")]
        public int CodigoResponsavelResponsavel { get; set; }

        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region ACResponsavel
        [DisplayName("Código Aluno")]
        public int CodigoAluno { get; set; }

        public virtual ACAlunoViewModel ACAluno { get; set; }
        #endregion

        #region ACResponsavel
        [DisplayName("Código Responsável")]
        public int CodigoResponsavel { get; set; }
        
        public virtual ACResponsavelViewModel ACResponsavel { get; set; }
        #endregion

        #region GEParentesco
        [DisplayName("Código Parentesco")]
        public int CodigoParentesco { get; set; }

        public virtual GEParentescoViewModel GEParentesco { get; set; }
        #endregion
    }
}
