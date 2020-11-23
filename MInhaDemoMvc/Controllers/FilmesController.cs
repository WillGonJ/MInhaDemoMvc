using Microsoft.AspNetCore.Mvc;
using MInhaDemoMvc.Models;

namespace MInhaDemoMvc.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                //
            }
            return View(filme);
        }
    }
}
