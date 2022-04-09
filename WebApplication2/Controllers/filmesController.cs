using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class filmesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BemVindo(string nome, int Id)
        {

            ViewData["Title"] = "Bem vindo";

            ViewData["Nome"] = nome;
            ViewData["Numerox"] = Id;

            return View();
        }
    }
}