using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Application.Adapter
{
    public static class SEGUsuarioAdapter
    {
        #region ViewModelToDomain
        public static SEGUsuario ViewModelToDomain(SEGUsuarioViewModel usuarioViewModel)
        {
            return new SEGUsuario
            {
                CodigoUsuario = usuarioViewModel.CodigoUsuario,
                flAtivo = usuarioViewModel.flAtivo,
                Login = usuarioViewModel.Login,
            };
        }

        public static IEnumerable<SEGUsuario> ViewModelToDomain(IEnumerable<SEGUsuarioViewModel> listaUsuarioViewModel)
        {
            IList<SEGUsuario> listaSEGUsuario = new List<SEGUsuario>();

            foreach (SEGUsuarioViewModel usuarioViewModel in listaUsuarioViewModel)
            {
                listaSEGUsuario.Add(ViewModelToDomain(usuarioViewModel));
            }

            return listaSEGUsuario;
        }
        #endregion

        #region DomainToViewModel
        public static SEGUsuarioViewModel DomainToViewModel(SEGUsuario SEGUsuario)
        {
            #region SEGUsuarioViewModel
            SEGUsuarioViewModel SEGUsuarioViewModel = new SEGUsuarioViewModel
            {
                CodigoUsuario = SEGUsuario.CodigoUsuario,
                flAtivo = SEGUsuario.flAtivo,
                Login = SEGUsuario.Login
            }; 
            #endregion

            #region PerfilViewModel
            if(SEGUsuario.SEGUsuarioPerfis != null)
            {
                SEGUsuarioViewModel.SEGPerfilViewModel = new List<SEGPerfilViewModel>();

                foreach (SEGUsuarioPerfil SEGUsuarioPerfil in SEGUsuario.SEGUsuarioPerfis)
                {
                    SEGUsuarioViewModel.SEGPerfilViewModel.Add(new SEGPerfilViewModel
                    {
                        CodigoPerfil = SEGUsuarioPerfil.CodigoPerfil,
                        Descricao = SEGUsuarioPerfil.SEGPerfil != null ? SEGUsuarioPerfil.SEGPerfil.Descricao : "Não Informado"
                    });
                }
            }
            #endregion

            return SEGUsuarioViewModel;
        }

        public static IEnumerable<SEGUsuarioViewModel> DomainToViewModel(IEnumerable<SEGUsuario> listaSEGUsuario)
        {
            IList<SEGUsuarioViewModel> listaUsuarioViewModel = new List<SEGUsuarioViewModel>();

            foreach (SEGUsuario SEGUsuario in listaSEGUsuario)
            {
                listaUsuarioViewModel.Add(DomainToViewModel(SEGUsuario));
            }

            return listaUsuarioViewModel;
        } 
        #endregion
    }
}
