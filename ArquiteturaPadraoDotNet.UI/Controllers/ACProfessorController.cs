﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using One.Application.Interfaces;
using One.Application.ViewModels.ACProfessorVM;
using One.Domain.Validation;
using One.Infra.CrossCutting.Identity.Data.Models;
using One.UI.Helpers;

namespace One.UI.Controllers
{
    [Authorize]
    [Route("Gerenciar-Professor")]
    public class ACProfessorController : BaseController
    {
        #region Seção: Interface - IoC
        private ValidationResults validationResult;
        private readonly IAcademicoAppService _iAcademicoAppService;
        #endregion

        #region Seção: Construtor
        public ACProfessorController(IOptions<BaseUrl> baseUrl,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IAcademicoAppService iAcademicoAppService) : base(baseUrl, userManager, signInManager)
        {
            _iAcademicoAppService = iAcademicoAppService;
        }
        #endregion


        #region Seção: Actions
        [Route("Cadastro-Professor/{id:int}")]
        public IActionResult Cadastro(int id)
        {
            ViewBag.BaseUrl = ObterBaseUrl();
            return View(id == 0 ? new CadastroProfessorViewModel() : null);
        }
        #endregion

        #region Seção: Ajax
        [HttpPost]
        [Route("Registrar-Cadastro-Professor")]
        public JsonResult RegistrarCadastroProfessor([FromBody] CadastroProfessorViewModel cadastroProfessorViewModel)
        {
            if (ModelState.IsValid)
                validationResult = cadastroProfessorViewModel.CodigoProfessor == 0 ?
                      _iAcademicoAppService.SalvarProfessor(cadastroProfessorViewModel)
                    : _iAcademicoAppService.AlterarProfessor(cadastroProfessorViewModel);
            else
                validationResult = new ValidationResults(false, "modelo inválido");

            return Json(new { erro = validationResult.IsValid ? 0 : 1, mensagem = validationResult.Message });
        }
        #endregion
    }
}