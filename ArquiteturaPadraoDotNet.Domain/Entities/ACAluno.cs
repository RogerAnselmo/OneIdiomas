﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACAluno
    {
        #region ACAluno
        [Key]
        public int CodigoALuno { get; set; }

        [MaxLength(10)]
        public string RG { get; set; }

        [MaxLength(10)]
        public string CPF { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        [Required]
        public int DiaVencimento { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }
        #endregion

        #region GEEndereco
        [Required]
        public int CodigoEndereco { get; set; }

        [ForeignKey("CodigoEndereco")]
        public virtual GEEndereco GEEndereco { get; set; }
        #endregion

        #region ACAlunoResponsavel
        public virtual IEnumerable<ACAlunoResponsavel> ACAlunoResponsavel { get; set; }
        #endregion

        #region SEGUsuario
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion        

        #region ACMatricula
        public virtual IEnumerable<ACMatricula> ACMatricula { get; set; } 
        #endregion

        #region Métodos Inteigentes
        public int Idade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month ||
                (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                idade--;

            return idade;
        } 
        #endregion
    }
}
