using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class ACNivelViewModel
    {
        #region ACNivelViewModel
        [DisplayName("Código Nível")]
        public int CodigoNivel { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        #endregion

        #region ACCategoriaViewModel
        public int CodigoCategoria { get; set; }
        public ACCategoriaViewModel ACCategoriaViewModel { get; set; } 
        #endregion

        public int CodigoFaixaEtaria { get; set; }
        public ACFaixaEtariaViewModel ACFaixaEtariaViewModel { get; set; }
    }
}
