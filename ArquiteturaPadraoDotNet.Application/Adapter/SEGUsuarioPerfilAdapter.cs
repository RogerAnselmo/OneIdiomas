﻿using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Adapter
{
    public static class SEGUsuarioPerfilAdapter
    {
        #region DomainToViewModel
        public static SEGUsuarioPerfilViewModel DomainToViewModel(SEGUsuarioPerfil domain)
        {
            return new SEGUsuarioPerfilViewModel
            {
                CodigoPerfil = domain.CodigoPerfil,
                CodigoUsuario = domain.CodigoUsuario,
                UsuarioViewModel = domain.SEGUsuario == null ? new SEGUsuarioViewModel() : SEGUsuarioAdapter.DomainToViewModel(domain.SEGUsuario),
                PerfilViewModel = domain.SEGPerfil == null ? new SEGPerfilViewModel() : SEGPerfilAdapter.DomainToViewModel(domain.SEGPerfil)
            };
        }

        public static IEnumerable<SEGUsuarioPerfilViewModel> DomainToViewModel(IEnumerable<SEGUsuarioPerfil> listaDomain)
        {
            IList<SEGUsuarioPerfilViewModel> lista = new List<SEGUsuarioPerfilViewModel>();

            if (listaDomain != null)
            {
                foreach (SEGUsuarioPerfil SEGUsuarioPerfil in listaDomain)
                {
                    lista.Add(DomainToViewModel(SEGUsuarioPerfil));
                }
            }
            return lista;
        }
        #endregion

        #region ViewModelToDomain
        public static SEGUsuarioPerfil ViewModelToDomain(SEGUsuarioPerfilViewModel viewModel)
        {
            return new SEGUsuarioPerfil
            {
                CodigoPerfil = viewModel.CodigoPerfil,
                CodigoPerfilPadrao = viewModel.CodigoPerfil,
                CodigoUsuario = viewModel.CodigoUsuario,
                CodigoUsuarioPerfil = viewModel.CodigoUsuario,
                SEGPerfil = viewModel.PerfilViewModel == null ? new SEGPerfil() : SEGPerfilAdapter.ViewModelToDomain(viewModel.PerfilViewModel),
                SEGUsuario = viewModel.UsuarioViewModel == null ? new SEGUsuario() : SEGUsuarioAdapter.ViewModelToDomain(viewModel.UsuarioViewModel)
            };
        }

        public static IEnumerable<SEGUsuarioPerfil> ViewModelToDomain(IEnumerable<SEGUsuarioPerfilViewModel> listaViewModel)
        {
            IList<SEGUsuarioPerfil> lista = new List<SEGUsuarioPerfil>();

            if (listaViewModel != null)
            {
                foreach (SEGUsuarioPerfilViewModel SEGUsuarioPerfilViewModel in listaViewModel)
                {
                    lista.Add(ViewModelToDomain(SEGUsuarioPerfilViewModel));
                }
            }

            return lista;
        } 
        #endregion
    }
}
