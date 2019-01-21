using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class GETipoTelefoneViewModel
    {
        #region GETipoTelefone
        [DisplayName("Código Tipo Telefone")]
        public int CodigoTipoTelefone { get; set; }

        [DisplayName("Tipo de Telefone")]
        public string Descricao { get; set; }
        #endregion
    }
}
