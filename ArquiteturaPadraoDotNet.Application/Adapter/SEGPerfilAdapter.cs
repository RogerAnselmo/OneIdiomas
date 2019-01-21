using System.Collections.Generic;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;

namespace One.Application.Adapter
{
    public static class SEGPerfilAdapter
    {
        #region DomainToViewModel
        public static SEGPerfilViewModel DomainToViewModel(SEGPerfil entity)
        {
            return new SEGPerfilViewModel
            {
                CodigoPerfil = entity.CodigoPerfil,
                Descricao = entity.Descricao
            };
        }

        public static IList<SEGPerfilViewModel> DomainToViewModel(IList<SEGPerfil> entity)
        {
            IList<SEGPerfilViewModel> lista = new List<SEGPerfilViewModel>();

            if (entity != null)
            {
                foreach (SEGPerfil SEGPerfil in entity)
                {
                    lista.Add(DomainToViewModel(SEGPerfil));
                }
            }

            return lista;
        }
        #endregion

        #region ViewModelToDomain
        public static SEGPerfil ViewModelToDomain(SEGPerfilViewModel entity)
        {
            return new SEGPerfil
            {
                CodigoPerfil = entity.CodigoPerfil,
                Descricao = entity.Descricao
            };
        }

        public static IList<SEGPerfil> ViewModelToDomain(IList<SEGPerfilViewModel> entityViewModel)
        {
            IList<SEGPerfil> lista = new List<SEGPerfil>();

            if (entityViewModel != null)
            {
                foreach (SEGPerfilViewModel PerfilViewModel in entityViewModel)
                {
                    lista.Add(ViewModelToDomain(PerfilViewModel));
                }
            }

            return lista;
        } 
        #endregion
    }
}
