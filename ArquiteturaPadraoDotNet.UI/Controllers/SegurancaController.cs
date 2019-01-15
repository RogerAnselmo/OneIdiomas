using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using One.Application.ViewModels;
using One.Infra.CrossCutting.Identity.Data.Models;
using System;
using System.Threading.Tasks;

namespace One.UI.Controllers
{
    //[Route("Gerenciar-Seguranca")]
    public class SegurancaController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        //[Route("Novo-Usuario")]
        public IActionResult Cadastro()
        {
            return View();
        }

        //[Route("Login-Usuario")]
        public IActionResult Login()
        {
            return View();
        }

        #region Seção: AJAX
        [HttpPost]
        [Route("Autenticar-Usuario")]
        public async Task<JsonResult> AutenticarAsync([FromBody]UsuarioViewModel usuario)
        {
            try
            {
                var userAspNet = await _userManager.FindByEmailAsync(usuario.Login);
                if (userAspNet == null)
                {
                    usuario.Mensagem = "Usuário não encontrado no Identity";
                }
                else
                {
                    var result = await _signInManager.PasswordSignInAsync(usuario.Login, usuario.Senha, false, false);
                    if (!result.Succeeded)
                    {
                        usuario.Mensagem = "Usuário não autenticado no Identity";
                    }
                    else
                    {
                        //usuario = _usuarioAppservice.AutenticarUsuario(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                usuario.Mensagem = ex.Message;
            }

            return Json(new { erro = usuario.Autenticado ? 0 : 1, data = usuario, mensagem = usuario.Mensagem });
        }

        [HttpPost]
        [Route("Salvar-Novo-Usuario")]
        public async Task<JsonResult> SalvarUsuarioAsync([FromBody]UsuarioViewModel usuario)
        {
            try
            {

                var user = new ApplicationUser { UserName = usuario.Login, Email = usuario.Login };
                var result = await _userManager.CreateAsync(user, usuario.Senha);

                if (result.Succeeded)
                {

                    _usuarioAppservice.SalvarUsuario(usuario);

                    usuario.Mensagem = "Usuário Salvo com sucesso";
                    return Json(new { erro = 0, mensagem = usuario.Mensagem });
                }
                else
                {
                    usuario.Mensagem = "erro";
                    return Json(new { erro = 1, mensagem = usuario.Mensagem });
                }
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, mensagem = "Erro ao Salvar Usuário", exc = ex });
            }
        }
        #endregion
    }
}
}