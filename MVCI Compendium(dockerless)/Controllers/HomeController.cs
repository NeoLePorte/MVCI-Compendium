using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCI_Compendium.Models;
using MVCI_Compendium.Data;
using System.Linq;
namespace MVCI_Compendium.Controllers
{
    public class HomeController : Controller
    {

        private CharacterRepository _characterRepository = null;

        public HomeController()
        {
            _characterRepository = new CharacterRepository();
        }

        public  IActionResult Index()
        {
            var characters =  _characterRepository.GetCharacter();

            return View(characters);
        }



        public IActionResult Detail(string id)
        {
            if (id == null)
            {
                return new NotFoundObjectResult(HttpStatusCode.BadRequest);
            }
            var character = _characterRepository.GetCharacter((string)id);


            return View(model: character);
        }

        [HttpPost]
        public IActionResult Detail(string id, string notes)
        {
            var character = _characterRepository.GetCharacter((string)id);

            character.Notes = notes;

            return RedirectToAction("Detail");
        }


        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return new NotFoundObjectResult(HttpStatusCode.BadRequest);
            }

            return View();
        }


        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return new NotFoundObjectResult(HttpStatusCode.BadRequest);
            }

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
