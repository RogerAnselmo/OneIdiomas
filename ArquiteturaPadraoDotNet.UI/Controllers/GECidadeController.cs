using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;
using System;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Cidade")]
    public class GECidadeController : BaseController
    {
        #region Seção: Inteface - IoC
        private readonly IAcademicoAppService _iacademicoAppService;
        private readonly IGeralAppService _geralAppService;
        #endregion

        #region Seção: Construtor
        public GECidadeController(IAcademicoAppService academicoAppService,
                              IGeralAppService geralAppService,
                              IOptions<BaseUrl> baseUrl,
                              UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager) : base(baseUrl, userManager, signInManager)
        {
            _iacademicoAppService = academicoAppService;
            _geralAppService = geralAppService;
        }
        #endregion

        #region Seção: Ajax
        [HttpPost]
        [Route("Obter-Cidades-Por-UF")]
        public JsonResult ObterCidadesPorUF([FromBody]GEUFViewModel pGEUFViewModel)
        {
            try
            {
                return Json(new { erro = 0, data = _geralAppService.ObterCidadesPorUF(pGEUFViewModel.CodigoUF) });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, error = ex.Message, mensagem = "Erro ao carregar cidade por UF" });
            }
        } 
        #endregion
    }
}