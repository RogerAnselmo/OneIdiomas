using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using One.Infra.CrossCutting.Identity.Data.Models;
using Microsoft.Extensions.Options;
using One.UI.Helpers;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Painel-Controle")]
    public class PainelController : BaseController
    {

        #region Interface - IoC
        #endregion

        #region Construtor
        public PainelController(IOptions<BaseUrl> baseUrl,
                               UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager) : base(baseUrl, userManager, signInManager)
        {
        }
        #endregion

        #region Actions
        [Route("Informacao-Geral")]
        public IActionResult DashBoard()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            ViewBag.login = ObterUsuarioLogado();
            return View();
        }
        #endregion
    }
}