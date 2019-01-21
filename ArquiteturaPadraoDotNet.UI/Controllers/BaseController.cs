using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using One.Application.ViewModels;
using One.Infra.CrossCutting.Identity.Data.Models;
using System.Threading.Tasks;

namespace One.UI.Controllers
{
    public class BaseController : Controller
    {
        #region Interface - IoC
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        #endregion

        public BaseController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public bool LoginJaExiste(string Login)
        {
            var usuario = _userManager.FindByEmailAsync(Login);
            return usuario.Result == null;
        }
        


        public async Task<ApplicationUser> ObterUsuarioPorEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<bool> AutenticarUsuarioAsync(SEGUsuarioViewModel usuarioViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(usuarioViewModel.Login, usuarioViewModel.Senha, false, false);
            return result.Succeeded;
        }

        public string ObterUsuarioLogado()
        {
            var a = _userManager.GetUserId(User);
            return _userManager.GetUserId(User);
        }
    }
}