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

        private readonly IUsuarioOneAppService _usuarioOneAppService;

        public AlunoController(IUsuarioOneAppService usuarioOneAppService)
        {
            _usuarioOneAppService = usuarioOneAppService;
        }

        [Route("Novo-Aluno")]
        public IActionResult Cadastro()
        {
            var ListaUF = _usuarioOneAppService.ObterTodasUF().ToList();
            ListaUF.Add(new GEUFViewModel { CodigoUF = 0, Descricao = "Selecione", Sigla = "Estado" });

            ViewBag.ListaUF = ListaUF;
            return View(new CadastroAlunoViewModel());
        }

        [Route("Lista-Aluno")]
        public IActionResult Lista()
        {
            return View();
        }
    }
}
