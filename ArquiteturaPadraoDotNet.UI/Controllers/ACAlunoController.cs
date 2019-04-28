using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
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
        #endregion

        #region Seção: Construtor
        public ACAlunoController(IAcademicoAppService academicoAppService,
                               IGeralAppService geralAppService,
                               IOptions<BaseUrl> baseUrl,
                               UserManager<ApplicationUser> userManager, 
                               SignInManager<ApplicationUser> signInManager): base(baseUrl, userManager, signInManager)
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
            ViewBag.ListaUF = ObterTodasUF(_geralAppService);
            ViewBag.ListaParentesco = ObterTodosParentesco(_geralAppService);
            ViewBag.ListaCidade = ObterCidadesPorUF(_geralAppService, 5); //5 = Pará
            ViewBag.ListaBairro = ObterBairroPorCidade(_geralAppService, 1); //1 = Abaetetuba

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
            ViewBag.ListaUF = ObterTodasUF(_geralAppService);
            ViewBag.ListaParentesco = ObterTodosParentesco(_geralAppService);
            ViewBag.ListaCidade = ObterCidadesPorUF(_geralAppService, 5); //5 = Pará
            ViewBag.ListaBairro = ObterBairroPorCidade(_geralAppService, 1); //1 = Abaetetuba

            return View(_academicoAppService.ObterAlunoParaEdicao(id));
        }
        #endregion

        #region Seção: Ajax
        [Route("Registrar-Cadastro-Aluno")]
        public JsonResult RegistrarCadastro([FromBody]CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _academicoAppService.SalvarAluno(pCadastroAlunoViewModel);
                    return Json(new { erro = 0, mensagem = "Operação Realizada com sucesso" });
                }
                return Json(new { erro = 1, mensagem = "Modelo inválido" });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, mensagem = "Erro ao realizar operação", error = ex.Message });
            }
        }

        [Route("Registrar-Edicao-Aluno")]
        public JsonResult RegistrarEdicao([FromBody]EditarAlunoViewModel editarAlunoViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _academicoAppService.AlterarAluno(editarAlunoViewModel);
                    return Json(new { erro = 0, mensagem = "Operação Realizada com sucesso" });
                }
                return Json(new { erro = 1, mensagem = "Modelo inválido" });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, mensagem = "Erro ao realizar operação", error = ex.Message });
            }
        }

        [Route("Grid-Aluno")]
        public IActionResult ListaGrid([FromBody]string nomeAluno) => View(_academicoAppService.ObterAlunosPorNome(nomeAluno ?? ""));

        [Route("Excluir-Aluno")]
        public JsonResult RegistrarExclusao([FromBody]int id)
        {
            try
            {
                _academicoAppService.ExcluirAluno(id);
                return Json(new { erro = 0, mensagem = "Operação realizada com sucesso" });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, mensagem = "Erro ao realizar operação", error = ex.Message });
            }
        }
        #endregion
    }
}
