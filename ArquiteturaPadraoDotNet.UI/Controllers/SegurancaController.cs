using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System;
using System.Threading.Tasks;

namespace One.UI.Controllers
{
    public class SegurancaController : BaseController
    {
        #region Seção: Interface - IoC
        private readonly ISegurancaAppService _segurancaAppService;
        #endregion

        #region Seção: Construtor
        public SegurancaController(ISegurancaAppService segurancaAppService,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IOptions<BaseUrl> baseUrl) : base(baseUrl, userManager, signInManager)
        {
            _segurancaAppService = segurancaAppService;
        }
        #endregion

        #region Seção: Actions
        public IActionResult Cadastro()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View();
        }

        public IActionResult Registro()
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View();
        }

        public IActionResult Login(SEGUsuarioViewModel usuarioViewModel)
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            usuarioViewModel = usuarioViewModel ?? new SEGUsuarioViewModel();
            return View(usuarioViewModel);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Autenticar(SEGUsuarioViewModel usuarioViewModel, string returnUrl = null)
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            try
            {
                if (ObterUsuarioPorEmailAsync(usuarioViewModel.Login) == null)
                {
                    usuarioViewModel.Mensagem = "Usuário não encontrado";
                    return View("Login", usuarioViewModel);
                }
                else
                {
                    if (await LoginAsync(usuarioViewModel.Login, usuarioViewModel.Senha))
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
            catch (Exception)
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
                if (LoginJaExiste(usuarioViewModel.Login))//verifica se o login está disponível
                {
                    usuarioViewModel.Mensagem = "Este login já existe!";
                }
                else
                {
                    if (await CreateAsync(usuarioViewModel))//salva o usuário no Identity
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
            catch (Exception)
            {
                usuarioViewModel.Mensagem = "Erro ao Salvar Usuário";
            }


            return Json(new { erro = usuarioViewModel.Autenticado ? 0 : 1, mensagem = usuarioViewModel.Mensagem });
        }
        #endregion
    }
}
