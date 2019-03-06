using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using System;
using System.Linq;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Aluno")]
    public class AlunoController : Controller
    {
        #region Seção: Inteface - IoC
        private readonly IAcademicoAppService _academicoAppService;
        private readonly IGeralAppService _geralAppService;
        #endregion

        #region Seção: Construtor
        public AlunoController(IAcademicoAppService academicoAppService,
                               IGeralAppService geralAppService)
        {
            _academicoAppService = academicoAppService;
            _geralAppService = geralAppService;
        }
        #endregion

        #region Seção: Actions
        [Route("Novo-Aluno")]
        public IActionResult Cadastro()
        {
            var ListaUF = _geralAppService.ObterTodasUF().ToList();
            ListaUF.Insert(0,new GEUFViewModel { CodigoUF = 0, Descricao = "Selecione", Sigla = "Estado" });

            ViewBag.ListaUF = ListaUF;
            return View(new CadastroAlunoViewModel());
        }

        [Route("Lista-Aluno")]
        public IActionResult Lista()
        {
            return View();
        }
        #endregion

        #region Seção: Ajax
        [Route("Registrar-Cadastro-Aluno")]
        public JsonResult RegistrarCadastro([FromBody]CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            try
            {
                _academicoAppService.SalvarAluno(pCadastroAlunoViewModel);
                return Json(new { erro = 0, mensagem = "Operação Realizada com sucesso" });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, mensagem = "Erro ao realizar operação", error = ex.Message });
            }
        } 
        #endregion
    }
}
