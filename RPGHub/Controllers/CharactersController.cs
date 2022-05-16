using Microsoft.AspNetCore.Mvc;
using RPGHub.Models;

namespace RPGHub.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Character(Character character)
        {
            return View();
        }
    }
}