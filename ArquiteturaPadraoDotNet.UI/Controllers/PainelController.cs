using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace One.UI.Controllers
{
    [Route("Painel-Controle")]
    public class PainelController : Controller
    {
        [Route("Informacao-Geral")]
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}