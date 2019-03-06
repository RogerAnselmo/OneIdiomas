using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.ViewModels;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System.Threading.Tasks;

namespace One.UI.Controllers
{
    public class BaseController : Controller
    {
        #region Interface - IoC
        private readonly IOptions<BaseUrl> _baseUrl;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        #endregion

        #region Seção: Contrutor
        public BaseController(IOptions<BaseUrl> baseUrl, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _baseUrl = baseUrl;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        #endregion

        #region Seção: Autenticar/Obter Usuário

        public async Task<bool> CreateAsync(SEGUsuarioViewModel usuarioViewModel)
        {
            var user = new ApplicationUser { UserName = usuarioViewModel.Login, Email = usuarioViewModel.Login };
            var result = await _userManager.CreateAsync(user, usuarioViewModel.Senha);

            return result.Succeeded;
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
            return _userManager.GetUserName(User);
        } 
        #endregion

        #region Seção: Login/Logout
        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<bool> LoginAsync(string login, string senha)
        {
            var result = await _signInManager.PasswordSignInAsync(login, senha, false, false);
            return result.Succeeded;
        }

        public bool LoginJaExiste(string Login)
        {
            var usuario = _userManager.FindByEmailAsync(Login);
            return usuario.Result != null;
        }
        #endregion

        #region Seção: Sistema
        public string ObterBaseUrl()
        {
            return _baseUrl.Value.Url;
        } 
        #endregion
    }
}