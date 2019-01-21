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
                CPF = usuarioViewModel.CPF,
                flAtivo = usuarioViewModel.flAtivo,
                Login = usuarioViewModel.Login,
                NomeCompleto = usuarioViewModel.NomeCompleto,
                Sexo = usuarioViewModel.Sexo
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
            #region UsuarioViewModel
            SEGUsuarioViewModel usuarioViewModel = new SEGUsuarioViewModel
            {
                CodigoUsuario = SEGUsuario.CodigoUsuario,
                CPF = SEGUsuario.CPF,
                flAtivo = SEGUsuario.flAtivo,
                Login = SEGUsuario.Login,
                NomeCompleto = SEGUsuario.NomeCompleto,
                Sexo = SEGUsuario.Sexo
            }; 
            #endregion

            #region PerfilViewModel
            if(SEGUsuario.SEGUsuarioPerfis != null)
            {
                usuarioViewModel.PerfilViewModel = new List<SEGPerfilViewModel>();

                foreach (SEGUsuarioPerfil SEGUsuarioPerfil in SEGUsuario.SEGUsuarioPerfis)
                {
                    usuarioViewModel.PerfilViewModel.Add(new SEGPerfilViewModel
                    {
                        CodigoPerfil = SEGUsuarioPerfil.CodigoPerfil,
                        Descricao = SEGUsuarioPerfil.SEGPerfil != null ? SEGUsuarioPerfil.SEGPerfil.Descricao : "Não Informado"
                    });
                }
            }
            #endregion

            return usuarioViewModel;
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
