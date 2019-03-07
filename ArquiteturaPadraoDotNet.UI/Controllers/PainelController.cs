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

        #region Seção:Interface - IoC
        #endregion

        #region Seção: Construtor
        public PainelController(IOptions<BaseUrl> baseUrl,
                               UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager) : base(baseUrl, userManager, signInManager)
        {
        }
        #endregion

        #region Seção: Actions
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