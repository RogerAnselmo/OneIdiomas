using System;
using Microsoft.AspNetCore.Mvc;
using One.Application.Interfaces;

namespace One.UI.Controllers
{
    [Route("Gerenciar-Bairro")]
    public class GEBairroController : Controller
    {

        #region Seção: Interface - IoC
        private readonly IGeralAppService _geralAppService;
        #endregion

        #region Seção: Construtor
        public GEBairroController(IGeralAppService geralAppService)
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