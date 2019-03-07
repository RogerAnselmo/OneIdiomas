using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Parentesco")]
    public class GEParentescoController : BaseController
    {
        #region Seção: Interface - IoC
        private readonly IGeralAppService _geralAppService; 
        #endregion

        #region Seção: Construtor
        public GEParentescoController(IGeralAppService geralAppService, 
                                      IOptions<BaseUrl> baseUrl,
                                      UserManager<ApplicationUser> userManager,
                                      SignInManager<ApplicationUser> signInManager) 
            : base(baseUrl, userManager, signInManager)
        {
        }
        #endregion

        #region Seção: Ajax
        [HttpGet]
        [Route("Obter-Todos")]
        public JsonResult ObterTodos()
        {
            try
            {
                return Json(new { erro = 0, data = _geralAppService.ObterTodosParentesco() });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, error = ex.Message, mensagem = "Erro ao carregar parentesco" });
            }
        } 
        #endregion
    }
}