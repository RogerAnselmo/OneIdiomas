using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using One.Infra.CrossCutting.Identity.Data.Models;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Painel-Controle")]
    public class PainelController : Controller
    {

        #region Interface - IoC
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        #endregion

        #region Construtor
        public PainelController(
           UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        #endregion

        #region Actions
        [Route("Informacao-Geral")]
        public IActionResult DashBoard()
        {
            ViewBag.login = _userManager.GetUserName(User);
            return View();
        }
        #endregion
    }
}