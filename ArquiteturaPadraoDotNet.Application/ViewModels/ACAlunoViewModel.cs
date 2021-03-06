﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class ACAlunoViewModel
    {
        #region ACResponsavelViewModel
        [DisplayName("Código do Responsavel")]
        public int CodigoAluno { get; set; }

        [DisplayName("Idade")]
        public int Idade { get; set; }

        [DisplayName("Vencimento")]
        public int DiaVencimento { get; set; }
        #endregion

        #region GEEndereco
        public virtual GEEnderecoViewModel GEEnderecoViewModel { get; set; }
        #endregion

        #region ACResponsavel
        public virtual ACResponsavelViewModel ACResponsavelViewModel { get; set; }
        #endregion

        #region SEGUsuario
        public virtual SEGUsuarioViewModel SEGUsuarioViewModel { get; set; }
        #endregion        

        #region ACMatricula
        public virtual IEnumerable<ACMatriculaViewModel> ACMatriculaViewModel { get; set; }
        #endregion

        #region GETelefoneViewModel
        public virtual GETelefoneViewModel GETelefoneViewModel { get; set; } 
        #endregion
    }
}
