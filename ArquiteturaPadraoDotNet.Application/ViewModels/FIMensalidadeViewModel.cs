using System;
using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class FIMensalidadeViewModel
    {
        #region FIMensalidade
        [DisplayName("Código Mensalidade")]
        public int CodigoMensalidade { get; set; }

        [DisplayName("Cúmero da Parcela")]
        public int NumeroParcela { get; set; }

        [DisplayName("Data de Vencimento")]
        public DateTime DataVencimento { get; set; }

        [DisplayName("Data de Pagamento")]
        public DateTime DataPagamento { get; set; }

        [DisplayName("Data de Emissão")]
        public DateTime DataEmissao { get; set; }

        [DisplayName("Valor da Mensalidade")]
        public decimal Valor { get; set; }

        [DisplayName("Mês da Mensalidade")]
        public int MesCompetencia { get; set; }

        [DisplayName("Ano da Mensalidade")]
        public int AnoCompetencia { get; set; }

        [DisplayName("Situação da Mensalidade")]
        public string flSituacao { get; set; }
        #endregion

        #region ACMatriculaViewModel
        public ACMatriculaViewModel ACMatriculaViewModel { get; set; }
        #endregion
    }
}
