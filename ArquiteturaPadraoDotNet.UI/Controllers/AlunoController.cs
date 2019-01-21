using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Aluno")]
    public class AlunoController : Controller
    {
        [Route("Novo-Aluno")]
        public IActionResult Cadastro()
        {
            return View();
        }

        [Route("Lista-Aluno")]
        public IActionResult Lista()
        {
            return View();
        } 
    }
}
