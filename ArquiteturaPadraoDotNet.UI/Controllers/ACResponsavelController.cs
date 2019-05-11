using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Application.ViewModels.ACResponsavelVM;
using One.Domain.Validation;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System.Linq;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Responsavel")]
    public class ACResponsavelController : BaseController
    {
        #region Seão: Interface - IoC
        private readonly IAcademicoAppService _iacademicoAppService;
        private readonly IGeralAppService _geralAppService;
        #endregion

        #region Seção: Construtor
        public ACResponsavelController(IOptions<BaseUrl> baseUrl,
          UserManager<ApplicationUser> userManager,
          SignInManager<ApplicationUser> signInManager,
          IAcademicoAppService academicoAppService,
          IGeralAppService geralAppService) : base(baseUrl, userManager, signInManager)
        {
            _iacademicoAppService = academicoAppService;
            _geralAppService = geralAppService;
        }
        #endregion

        #region Seção: Actions
        [Route("Lista-Responsavel")]
        public IActionResult Lista()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View();
        }

        [Route("Editar-Responsavel/{id:int}")]
        public IActionResult Editar(int id)
        {

            ViewBag.BaseUrl = ObterBaseUrl();
            ViewBag.ListaUF = _geralAppService.ObterTodasUF();
            ViewBag.ListaParentesco = _geralAppService.ObterTodosParentesco();
            ViewBag.ListaCidade = _geralAppService.ObterCidadesPorUF(5); //5 = Pará
            ViewBag.ListaBairro = _geralAppService.ObterBairroPorCidade(1); //1 = Abaetetuba

            return View(_iacademicoAppService.ObterResponsavelParaEdicao(id));
        }

        [Route("Cadastro-Responsavel/{id:int?}")]
        public IActionResult Cadastro(int? id)
        {
            ViewBag.Title = id == 0 ? "Cadastro Responsável" : "Editar Responsável";
            ViewBag.BaseUrl = ObterBaseUrl();
            ViewBag.ListaUF = _geralAppService.ObterTodasUF();
            ViewBag.ListaParentesco = _geralAppService.ObterTodosParentesco();
            ViewBag.ListaCidade = _geralAppService.ObterCidadesPorUF(5); //5 = Pará

            //TODO: refatorar esse código
            var lista = _geralAppService.ObterBairroPorCidade(1).ToList();
            lista.Insert(0, new GEBairroViewModel { CodigoBairro = 0, Descricao = "Selecione o Bairro" });
            ViewBag.ListaBairro = lista; //1 = Abaetetuba

            return View(!id.HasValue ? new CadastroResponsavelViewModel() : _iacademicoAppService.ObterResponsavelParaEdicao(id.Value));
        }
        #endregion

        #region Seção: Ajax
        [Route("Grid-Responsavel")]
        public IActionResult ListaGrid([FromBody]string nome)
            => View(_iacademicoAppService.ObterResponsavelPorNome(nome));

        [Route("Registrar-Cadastro-Responsavel")]
        [HttpPost]
        public JsonResult RegistrarCadastro([FromBody]CadastroResponsavelViewModel CadastroResponsavelViewModel)
        {
            if (ModelState.IsValid)
                validationResult = CadastroResponsavelViewModel.CodigoResponsavel == 0 ?
                    _iacademicoAppService.SalvarResponsavel(CadastroResponsavelViewModel)
                    : _iacademicoAppService.AlterarResponsavel(CadastroResponsavelViewModel);
            else
                validationResult = new ValidationResults(false, "modelo inválido");

            return ReturnValidationResult();
        }

        [Route("Registrar-Exclusao-Responsavel")]
        public JsonResult RegistrarExclusao([FromBody]int id)
        {
            validationResult = _iacademicoAppService.ExcluirResponsavel(id);
            return ReturnValidationResult();
        }
        #endregion
    }
}