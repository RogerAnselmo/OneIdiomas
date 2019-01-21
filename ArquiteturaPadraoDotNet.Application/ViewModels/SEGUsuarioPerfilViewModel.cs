using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class SEGUsuarioPerfilViewModel
    {
        #region SEGUsuarioPerfilViewModel
        [DisplayName("Código Usuário Perfil")]
        public int CodigoUsuarioPerfil { get; set; } 
        #endregion

        #region SEGUsuarioViewModel
        public int CodigoUsuario { get; set; }
        public SEGUsuarioViewModel SEGUsuarioViewModel { get; set; }
        #endregion

        #region SEGPerfilViewModel
        public int CodigoPerfil { get; set; }
        public SEGPerfilViewModel SEGPerfilViewModel { get; set; } 
        #endregion
    }
}
