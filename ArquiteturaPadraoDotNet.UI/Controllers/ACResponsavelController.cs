using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels.ACResponsavelVM;
using One.Domain.Validation;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Responsavel")]
    public class ACResponsavelController : BaseController
    {
        #region Seão: Interface - IoC
        private readonly IAcademicoAppService _academicoAppService;
        private readonly IGeralAppService _geralAppService;
        private ValidationResults validationResult;
        #endregion

        #region Seção: Construtor
        public ACResponsavelController(IOptions<BaseUrl> baseUrl,
          UserManager<ApplicationUser> userManager,
          SignInManager<ApplicationUser> signInManager,
          IAcademicoAppService academicoAppService) : base(baseUrl, userManager, signInManager)
          => _academicoAppService = academicoAppService;
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

            return View(_academicoAppService.ObterResponsavelParaEdicao(id));
        }
        #endregion

        #region Seção: Ajax
        [Route("Grid-Responsavel")]
        public IActionResult ListaGrid([FromBody]string nome) => View(_academicoAppService.ObterPorResponsavelNome(nome));

        //[Route("Registrar-Cadastro-Responsavel")]
        //public JsonResult RegistrarCadastro([FromBody]CadastroResponsavelViewModel CadastroResponsavelViewModel)
        //{
        //    if (ModelState.IsValid)
        //        validationResult = _academicoAppService.AlterarResponsavel(CadastroResponsavelViewModel);

        //    return Json(new { erro = validationResult.IsValid ? 0 : 1, mensagem = validationResult.Message });
        //}

        [Route("Registrar-Edicao-Responsavel")]
        public JsonResult RegistrarEdicao([FromBody]EditarResponsavelViewModel editarResponsavelViewModel)
        {
            if (ModelState.IsValid)
                validationResult = _academicoAppService.AlterarResponsavel(editarResponsavelViewModel);

            return Json(new { erro = validationResult.IsValid ? 0 : 1, mensagem = validationResult.Message });
        }

        [Route("Registrar-Exclusao-Responsavel")]
        public JsonResult RegistrarExclusao([FromBody]int id)
        {
            validationResult = _academicoAppService.ExcluirResponsavel(id);
            return Json(new { erro = validationResult.IsValid ? 0 : 1, mensagem = validationResult.Message });
        }
        #endregion
    }
}