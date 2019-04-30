using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Validation;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Aluno")]
    public class ACAlunoController : BaseController
    {
        #region Seção: Inteface - IoC
        private readonly IAcademicoAppService _academicoAppService;
        private readonly IGeralAppService _geralAppService;
        private ValidationResults validationResult;
        #endregion

        #region Seção: Construtor
        public ACAlunoController(IAcademicoAppService academicoAppService,
                               IGeralAppService geralAppService,
                               IOptions<BaseUrl> baseUrl,
                               UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager) : base(baseUrl, userManager, signInManager)
        {
            _academicoAppService = academicoAppService;
            _geralAppService = geralAppService;
        }
        #endregion

        #region Seção: Actions
        [Route("Novo-Aluno")]
        public IActionResult Cadastro()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            ViewBag.ListaUF = _geralAppService.ObterTodasUF();
            ViewBag.ListaParentesco = _geralAppService.ObterTodosParentesco();
            ViewBag.ListaCidade = _geralAppService.ObterCidadesPorUF(5); //5 = Pará
            ViewBag.ListaBairro = _geralAppService.ObterBairroPorCidade(1); //1 = Abaetetuba

            return View(new CadastroAlunoViewModel());
        }

        [Route("Lista-Aluno")]
        public IActionResult Lista()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View();
        }

        [Route("Editar-Aluno/{id:int}")]
        public IActionResult Editar(int id)
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            ViewBag.ListaUF = _geralAppService.ObterTodasUF();
            ViewBag.ListaParentesco = _geralAppService.ObterTodosParentesco();
            ViewBag.ListaCidade = _geralAppService.ObterCidadesPorUF(5); //5 = Pará
            ViewBag.ListaBairro = _geralAppService.ObterBairroPorCidade(1); //1 = Abaetetuba

            return View(_academicoAppService.ObterAlunoParaEdicao(id));
        }
        #endregion

        #region Seção: Ajax
        [Route("Grid-Aluno")]
        public IActionResult ListaGrid([FromBody]string nomeAluno) => View(_academicoAppService.ObterAlunosPorNome(nomeAluno ?? ""));

        [Route("Registrar-Cadastro-Aluno")]
        public JsonResult RegistrarCadastro([FromBody]CadastroAlunoViewModel CadastroAlunoViewModel)
        {
            if (ModelState.IsValid)
                validationResult = _academicoAppService.SalvarAluno(CadastroAlunoViewModel);

            return Json(new { erro = validationResult.IsValid ? 0 : 1, mensagem = validationResult.Message });
        }

        [Route("Registrar-Edicao-Aluno")]
        public JsonResult RegistrarEdicao([FromBody]EditarAlunoViewModel editarAlunoViewModel)
        {
            if (ModelState.IsValid)
                validationResult = _academicoAppService.AlterarAluno(editarAlunoViewModel);

            return Json(new { erro = validationResult.IsValid ? 0 : 1, mensagem = validationResult.Message });
        }

        [Route("Registrar-Exclusao-Aluno")]
        public JsonResult RegistrarExclusao([FromBody]int id)
        {
            validationResult = _academicoAppService.ExcluirAluno(id);
            return Json(new { erro = validationResult.IsValid ? 0 : 1, mensagem = validationResult.Message });
        }
        #endregion
    }
}
