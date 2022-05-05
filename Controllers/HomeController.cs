using EnqueteWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnqueteWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Responder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Responder(Resposta resposta)
        {
            Repositorio.AdicionarRespota(resposta);
            return View("Obrigado");
        }

        public IActionResult Resultado()
        {
            return View(Repositorio.Respostas);
        }

    }
}
