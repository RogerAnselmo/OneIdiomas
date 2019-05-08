using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.ViewModels.ACProfessorVM;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Professor")]
    public class ACProfessorController : BaseController
    {
        public ACProfessorController(IOptions<BaseUrl> baseUrl, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : base(baseUrl, userManager, signInManager)
        {
        }


        [Route("Cadastro-Professor/{id: int}")]
        public IActionResult Cadastro(int id)
        {
            return View(id == 0? new CadastroProfessorViewModel(): null);
        }
    }
}