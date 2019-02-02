using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using System.Linq;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Aluno")]
    public class AlunoController : Controller
    {

        #region Inteface - IoC
        private readonly IUsuarioOneAppService _usuarioOneAppService;
        #endregion

        #region Construtor
        public AlunoController(IUsuarioOneAppService usuarioOneAppService)
        {
            _usuarioOneAppService = usuarioOneAppService;
        }
        #endregion

        #region Actions
        [Route("Novo-Aluno")]
        public IActionResult Cadastro()
        {
            var ListaUF = _usuarioOneAppService.ObterTodasUF();
            ListaUF.ToList().Insert(0,new GEUFViewModel { CodigoUF = 0, Descricao = "Selecione", Sigla = "Estado" });

            ViewBag.ListaUF = ListaUF;
            return View(new CadastroAlunoViewModel());
        }

        [Route("Lista-Aluno")]
        public IActionResult Lista()
        {
            return View();
        } 
        #endregion

        public JsonResult SalvarAluno([FromBody]CadastroAlunoViewModel pCadastroAlunoViewModel)
        {


            return Json(new { erro =  0, mensagem = "a"});
        }
    }
}
