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
        private readonly IUsuarioOneAppService _iUsuarioOneAppService;

        public CidadeController(IUsuarioOneAppService iUsuarioOneAppService)
        {
            _iUsuarioOneAppService = iUsuarioOneAppService;
        }

        [HttpPost]
        [Route("Obter-Cidades-Por-UF")]
        public JsonResult ObterCidadesPorUF([FromBody]GEUFViewModel pGEUFViewModel)
        {
            try
            {
                var xicote = _iUsuarioOneAppService.ObterCidadesPorUF(pGEUFViewModel.CodigoUF).ToList();

                return Json(new { erro = 0, data = _iUsuarioOneAppService.ObterCidadesPorUF(pGEUFViewModel.CodigoUF) });
            }
            catch (Exception ex)
            {
                return Json(new { erro = 0, error = ex.Message, mensagem = "Erro ao carregar cidade por UF" });
            }
        }
    }
}