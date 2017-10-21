using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCI_Compendium.Models;
using MVCI_Compendium.Data;
using System.Linq;
using Microsoft.Extensions.Logging;
namespace MVCI_Compendium.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger, CharacterRepository characterRepository)
        {
            _logger = logger;
            _characterRepository = characterRepository;
        }
        private CharacterRepository _characterRepository = null;
        private readonly ILogger<HomeController> _logger;
        
        [HttpGet("")]
        public IActionResult Default()
        {
            return RedirectToAction("Index");
        }

        [HttpGet("Characters")]
        public  IActionResult Index()
        {
            var characters =  _characterRepository.GetCharacter();
            var charList = new CharacterListViewModel
            {

                Characters = characters.Select(c => new CharacterViewModel
                {
                    Icon = c.GetIcon(),
                    Faction = c.Faction,
                    Name = c.Name,
                    CharacterId = c.CharacterId

                }).ToList()
            };
            _logger.LogDebug("Loading a list of all characters");
            return View(charList);
        }


        [HttpGet("Characters/{name}")]
        public IActionResult Detail(string name)
        {
            var character = _characterRepository.GetCharacter((string)name);


            if (character != null)
            {
                var CharacterViewModel = new CharacterViewModel
                {
                    CharacterId = character.CharacterId,
                    Name = character.Name,
                    Stamina = character.Stamina,
                    Bio = character.Bio,
                    MoveList = character.Moves,
                    Combos = character.Combos,
                    Notes = character.Notes
                };

                return View(CharacterViewModel);
            }

            return new NotFoundObjectResult(HttpStatusCode.BadRequest);
        }


        [HttpPost("Characters/{name}/Notes")]
        public IActionResult Save(string name, NotesViewModel notesViewModel)
        {
            var character = _characterRepository.GetCharacter((string)name);

            character.Notes = notesViewModel.Notes;

            return RedirectToAction("Detail");
        }

        [HttpPost("Characters/{name}/Combos")]
        public IActionResult Add(string CharacterId)
        {
            if (CharacterId == null)
            {
                return new NotFoundObjectResult(HttpStatusCode.BadRequest);
            }

            return View();
        }


        public IActionResult Delete(string CharacterId)
        {
            if (CharacterId == null)
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
