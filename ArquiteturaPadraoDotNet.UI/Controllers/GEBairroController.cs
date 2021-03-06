﻿using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Bairro")]
    public class GEBairroController : BaseController
    {
        #region Seção: Interface - IoC
        private readonly IGeralAppService _geralAppService;
        #endregion

        #region Seção: Construtor
        public GEBairroController(IGeralAppService geralAppService, 
                                  IOptions<BaseUrl> baseUrl, 
                                  UserManager<ApplicationUser> userManager, 
                                  SignInManager<ApplicationUser> signInManager) 
                                  : base(baseUrl, userManager, signInManager)
        {
            _geralAppService = geralAppService;
        }
        #endregion

        #region Seção: Ajax
        [HttpGet]
        [Route("Obter-Bairros-Por-Cidade/{CodigoCidade:int}")]
        public JsonResult ObterBairrosPorCidade(int CodigoCidade)
        {
            try
            {
                return Json(new { erro = 0, data = _geralAppService.ObterBairroPorCidade(CodigoCidade) });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 1, error = ex.Message, mensagem = "Erro ao carregar bairros por cidade" });
            }
        } 
        #endregion
    }
}