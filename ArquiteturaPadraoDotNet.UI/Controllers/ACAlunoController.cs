using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Validation;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System;
using System.Linq;

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
        [Route("Cadastro-Aluno/{id:int}")]
        public IActionResult Cadastro(int id)
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            ViewBag.ListaUF = _geralAppService.ObterTodasUF();
            ViewBag.ListaParentesco = _geralAppService.ObterTodosParentesco();
            ViewBag.ListaCidade = _geralAppService.ObterCidadesPorUF(5); //5 = Pará

            var lista = _geralAppService.ObterBairroPorCidade(1).ToList();
            lista.Insert(0, new GEBairroViewModel { CodigoBairro = 0, Descricao = "Selecione o Bairro" });
            ViewBag.ListaBairro = lista; //1 = Abaetetuba

            return View(id == 0 ? new CadastroAlunoViewModel() : _academicoAppService.ObterAlunoParaEdicao(id));
        }

        [Route("Lista-Aluno")]
        public IActionResult Lista()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View();
        }

        #endregion

        #region Seção: Ajax
        [Route("Grid-Aluno")]
        public IActionResult ListaGrid([FromBody]string nomeAluno) => View(_academicoAppService.ObterAlunosPorNome(nomeAluno ?? ""));

        [Route("Registrar-Cadastro-Aluno")]
        public JsonResult RegistrarCadastro([FromBody]CadastroAlunoViewModel cadastroAlunoViewModel)
        {
            if (ModelState.IsValid)
                validationResult = cadastroAlunoViewModel.CodigoAluno == 0 ?
                    _academicoAppService.SalvarAluno(cadastroAlunoViewModel)
                    : _academicoAppService.AlterarAluno(cadastroAlunoViewModel);
            else
                validationResult = new ValidationResults(false, "modelo inválido");

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
