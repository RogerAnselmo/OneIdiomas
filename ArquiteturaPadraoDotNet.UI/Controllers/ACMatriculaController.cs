using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;

namespace One.UI.Controllers
{
    [Route("Gerenciar-Matricula")]
    public class ACMatriculaController : BaseController
    {
        public ACMatriculaController(IOptions<BaseUrl> baseUrl, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : base(baseUrl, userManager, signInManager)
        {
        }

        [Route("Cadastro-Matricula")]
        public IActionResult Cadastro()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            ViewBag.Title = "Cadastro de Matrículas";
            return View();
        }

        [Route("Selecionar-Aluno")]
        public IActionResult SelecionarAluno()
        {
            return View();
        }

        [Route("Selecionar-Responsavel")]
        public IActionResult SelecionarResponsavel()
        {
            return View();
        }
    }
}