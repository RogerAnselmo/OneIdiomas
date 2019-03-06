using Microsoft.AspNetCore.Mvc;
using One.Application.Interfaces;
using One.Application.ViewModels;
using System;
using System.Linq;

namespace One.UI.Controllers
{
    [Route("Gerenciar-Cidade")]
    public class CidadeController : Controller
    {
        #region Seção: Inteface - IoC
        private readonly IAcademicoAppService _academicoAppService;
        private readonly IGeralAppService _geralAppService;
        #endregion

        public CidadeController(IAcademicoAppService academicoAppService,
                               IGeralAppService geralAppService)
        {
            _academicoAppService = academicoAppService;
            _geralAppService = geralAppService;
        }

        [HttpPost]
        [Route("Obter-Cidades-Por-UF")]
        public JsonResult ObterCidadesPorUF([FromBody]GEUFViewModel pGEUFViewModel)
        {
            try
            {
                var xicote = _geralAppService.ObterCidadesPorUF(pGEUFViewModel.CodigoUF).ToList();

                return Json(new { erro = 0, data = _geralAppService.ObterCidadesPorUF(pGEUFViewModel.CodigoUF) });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 0, error = ex.Message, mensagem = "Erro ao carregar cidade por UF" });
            }
        }
    }
}