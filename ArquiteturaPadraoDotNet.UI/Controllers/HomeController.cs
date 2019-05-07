using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using One.Infra.Data.Context;

namespace One.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly OneContext context;

        public HomeController(OneContext context) => this.context = context;

        public ActionResult Index()
        {
            return View();
        }

        [Route(nameof(ServidorDeveExistir))]
        public ActionResult ServidorDeveExistir()
        {
            return StatusCode(StatusCodes.Status200OK);
        }

        [Route(nameof(BancoDeDadosDeveExistir))]
        public ActionResult BancoDeDadosDeveExistir()
        {
            return (context.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists()
            ? StatusCode(StatusCodes.Status200OK)
            : StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
