using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Infra.CrossCutting.Identity.Data.Models;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace One.UI.Controllers
{
    public class SegurancaController : Controller
    {
        #region Seção: Interface - IoC
        private readonly ISegurancaAppService _segurancaAppService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        #endregion

        #region Seção: Construtor
        public SegurancaController(ISegurancaAppService segurancaAppService,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _segurancaAppService = segurancaAppService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        #endregion

        #region Seção: Actions
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Login(SEGUsuarioViewModel usuarioViewModel)
        {
            usuarioViewModel = usuarioViewModel ?? new SEGUsuarioViewModel();

            return View(usuarioViewModel);
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return View("Login", new SEGUsuarioViewModel());
        } 

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Autenticar(SEGUsuarioViewModel usuarioViewModel, string returnUrl = null)
        {
            try
            {
                var userAspNet = await _userManager.FindByEmailAsync(usuarioViewModel.Login);
                if (userAspNet == null)
                {
                    usuarioViewModel.Mensagem = "Usuário não encontrado";
                    return View("Login", usuarioViewModel);
                }
                else
                {
                    var result = await _signInManager.PasswordSignInAsync(usuarioViewModel.Login, usuarioViewModel.Senha, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Informacao-Geral", "Painel-Controle");
                    }
                    else
                    {
                        usuarioViewModel.Mensagem = "Usuário não autenticado";
                        return View("Login", usuarioViewModel);
                    }
                }
            }
            catch (Exception ex)
            {
                usuarioViewModel.Mensagem = "Erro ao autenticar usuário";
                return View("Login", usuarioViewModel);
            }
        }
        #endregion

        #region Seção: AJAX
        [HttpPost]
        public async Task<JsonResult> SalvarUsuarioAsync([FromBody]SEGUsuarioViewModel usuarioViewModel)
        {
            try
            {
                //procura o usuário identity pelo Login
                var usuario = _userManager.FindByEmailAsync(usuarioViewModel.Login);

                if (usuario.Result != null)//verifica se o login está disponível
                {
                    usuarioViewModel.Mensagem = "Este login já existe!";
                }
                else
                {
                    var user = new ApplicationUser { UserName = usuarioViewModel.Login, Email = usuarioViewModel.Login };
                    var result = await _userManager.CreateAsync(user, usuarioViewModel.Senha);

                    if (result.Succeeded)//salva o usuário no Identity
                    {
                        //salva o usuário na base
                        _segurancaAppService.SalvarUsuario(usuarioViewModel);
                        usuarioViewModel.Mensagem = "Usuário Salvo com sucesso";
                        usuarioViewModel.Autenticado = true;
                    }
                    else
                    {
                        usuarioViewModel.Mensagem = "Erro ao criar usuário no Identity";
                    }
                }
            }
            catch (Exception ex)
            {
                usuarioViewModel.Mensagem = "Erro ao Salvar Usuário";
            }


            return Json(new { erro = usuarioViewModel.Autenticado ? 0 : 1, mensagem = usuarioViewModel.Mensagem });
        }
        #endregion
    }
}
