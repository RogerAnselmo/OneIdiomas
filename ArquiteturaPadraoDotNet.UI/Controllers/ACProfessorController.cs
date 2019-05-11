using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels.ACProfessorVM;
using One.Domain.Validation;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Professor")]
    public class ACProfessorController : BaseController
    {
        #region Seção: Interface - IoC
        private readonly IAcademicoAppService _iAcademicoAppService;
        #endregion

        #region Seção: Construtor
        public ACProfessorController(IOptions<BaseUrl> baseUrl,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IAcademicoAppService iAcademicoAppService) : base(baseUrl, userManager, signInManager)
        {
            _iAcademicoAppService = iAcademicoAppService;
        }
        #endregion

        #region Seção: Actions
        [Route("Cadastro-Professor/{id:int?}")]
        public IActionResult Cadastro(int? id)
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View(!id.HasValue ? new CadastroProfessorViewModel() : _iAcademicoAppService.ObterProfessorParaEdicao(id.Value));
        }

        [Route("Lista-Professor")]
        public IActionResult Lista(int id)
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View();
        }
        #endregion

        #region Seção: Ajax
        [HttpPost]
        [Route("Registrar-Cadastro-Professor")]
        public JsonResult RegistrarCadastroProfessor([FromBody] CadastroProfessorViewModel cadastroProfessorViewModel)
        {
            if (ModelState.IsValid)
                validationResult = cadastroProfessorViewModel.CodigoProfessor == 0 ?
                      _iAcademicoAppService.SalvarProfessor(cadastroProfessorViewModel)
                    : _iAcademicoAppService.AlterarProfessor(cadastroProfessorViewModel);
            else
                validationResult = new ValidationResults(false, "modelo inválido");

            return ReturnValidationResult();
        }

        [HttpPost]
        [Route("Registrar-Exclusao-Professor")]
        public JsonResult RegistrarExclusaoProfessor([FromBody] int id)
        {
            validationResult = _iAcademicoAppService.ExcluirProfessor(id);
            return ReturnValidationResult();
        }

        [HttpPost]
        [Route("Grid-Professor")]
        public IActionResult ListaGrid([FromBody]string nome)
           => View(_iAcademicoAppService.ObterProfessorPorNome(nome));
        #endregion
    }
}