using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCI_Compendium.Models;
using MVCI_Compendium.Data;

namespace MVCI_Compendium.Controllers
{
    public class HomeController : Controller
    {

        private CharacterRepository _characterRepository = null;

        public HomeController()
        {
            _characterRepository = new CharacterRepository();
        }
        public IActionResult Index()
        {
            var characters = _characterRepository.GetCharacter();

            return View(characters);
        }

        public IActionResult Detail(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var character = _characterRepository.GetCharacter((string)id);

            return View(model: character);
        }

        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
