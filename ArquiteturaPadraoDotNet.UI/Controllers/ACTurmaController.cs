using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Application.ViewModels.ACTurmaVM;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System.Linq;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Turma")]
    public class ACTurmaController : BaseController
    {
        #region Seção: Interface - IoC
        private readonly IAcademicoAppService _iacademicoAppService;
        #endregion

        #region Seção: Construtor
        public ACTurmaController(IOptions<BaseUrl> baseUrl, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
                IAcademicoAppService academicoAppService) : base(baseUrl, userManager, signInManager)
        {
            _iacademicoAppService = academicoAppService;
        }
        #endregion

        #region Seção: Serviços
        [Route("Cadastro-Turma/{id:int?}")]
        public IActionResult Cadastro(int? id)
        {
            ViewBag.BaseUrl = ObterBaseUrl();

            var listaProfessores = _iacademicoAppService.ObterProfessorPorNome("").ToList();
            listaProfessores.Insert(0, new ACProfessorViewModel { CodigoProfessor = 0, NomeCompleto = "Selecione o Professor" });
            ViewBag.listaProfessores = listaProfessores;

            var listaNiveis = _iacademicoAppService.ObterNiveisAtivos().ToList();
            listaNiveis.Insert(0, new ACNivelViewModel { CodigoNivel = 0, Descricao = "Selecione o Nível" });
            ViewBag.ListaNiveis = listaNiveis;

            return View(!id.HasValue ? new CadastroTurmaViewModel() : _iacademicoAppService.ObterTurmaParaEdicao(id.Value));
        }

        [Route("Lista-Turma")]
        public IActionResult Lista()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View();
        }
        #endregion

        #region Seção: AJAX
        [Route("Grid-Turma")]
        public IActionResult ListaGrid([FromBody] string filtro) => View(_iacademicoAppService.ObterTurmaPorDescicaoNivelCategoria(filtro));

        [Route("Registrar-Cadastro-Turma")]
        public JsonResult RegistrarCadastroTurma([FromBody] CadastroTurmaViewModel cadastroTurmaViewModel)
        {
            if (ModelState.IsValid)
                validationResult = cadastroTurmaViewModel.CodigoTurma == 0 ?
                    _iacademicoAppService.SalvarTurma(cadastroTurmaViewModel) :
                    _iacademicoAppService.AlterarTurma(cadastroTurmaViewModel);
            else
                validationResult = new Domain.Validation.ValidationResults(false, "Modelo inválido");

            return ReturnValidationResult();
        }

        [Route("Registrar-Exclusao-Turma")]
        public JsonResult RegistrarExclusaoTurma([FromBody] int id)
        {
            validationResult = _iacademicoAppService.ExcluirTurma(id);
            return ReturnValidationResult();
        }
        #endregion
    }
}