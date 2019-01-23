using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class GETelefoneViewModel
    {
        #region GETelefoneViewModel
        [DisplayName("Código do Telefone")]
        public int CodigoTelefone { get; set; }

        [DisplayName("Telefone")]
        public string NumeroTelefone { get; set; }
        #endregion

        #region GETipoTelefoneViewModel
        public virtual GETipoTelefoneViewModel GETipoTelefoneViewModel { get; set; }
        #endregion

        #region SEGUsuarioViewModel
        public SEGUsuarioViewModel SEGUsuarioViewModel { get; set; } 
        #endregion
    }
}
