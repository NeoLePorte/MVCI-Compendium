using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCI_Compendium.Models;
using MVCI_Compendium.Data;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCI_Compendium.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }
        private Context _context = null;
        private readonly ILogger<HomeController> _logger;
        
        [HttpGet("")]
        public IActionResult Default()
        {
            return RedirectToAction("Index");
        }

        [HttpGet("Characters")]
        public  IActionResult Index()
        {
            var characters =  _context.Characters
                .OrderBy(c => c.Order)
                .ToList();
            if (characters != null)
            {
                var charList = new CharacterListViewModel
                {

                    Characters = characters.Select(c => new CharacterViewModel
                    {
                        Icon = c.GetIcon(),
                        Faction = c.Faction,
                        Name = c.Name,
                        CharacterId = c.CharacterId,
                    })
                    .ToList()
                };
                _logger.LogDebug("Loading a list of all characters");
                return View(charList);
            }
            return new NotFoundObjectResult(HttpStatusCode.BadRequest);
        }


        [HttpGet("Characters/{name}")]
        public IActionResult Detail(string name)
        {
            var character = _context.Characters
                .Include(c => c.Moves)
                .ThenInclude(i => i.Inputs)
                .Include(c => c.Combos)
                .ThenInclude(i => i.Inputs)
                .SingleOrDefault(c => c.Name == name);

            if (character != null)
            {
                var CharacterViewModel = new CharacterViewModel
                {
                    CharacterId = character.CharacterId,
                    Name = character.Name,
                    Stamina = character.Stamina,
                    Bio = character.Bio,
                    Moves = character.Moves,
                    Combos = character.Combos,
                    Notes = character.Notes
                };

                return View(CharacterViewModel);
            }

            return new NotFoundObjectResult(HttpStatusCode.BadRequest);
        }



		/*--------------------Save Notes-------------------------------*/
		[ValidateAntiForgeryToken]
		[HttpPost("Characters/{name}/Notes")]
        public IActionResult SaveNotes(CharacterViewModel characterViewModel)
        {
            
            var characterToUpdate = _context.Characters
                .SingleOrDefault(c => c.Name == characterViewModel.Name);

            if (characterViewModel.Name != null)
            {
                try
                {
                    characterToUpdate.Notes = characterViewModel.Notes;
                    _context.SaveChanges();
                    return RedirectToAction("Detail");
                }
                catch (DbUpdateException ex)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                    return RedirectToAction("Detail", ex);
                }
            }
            return View("Detail");
        }

		/*---------Add Combo--------------*/
		[HttpGet("Characters/{name}/ComboAdd")]
        public IActionResult ComboAdd()
        {

            var ComboView = new ComboView();

                return View("AddEditCombo", ComboView);
        }

		[ValidateAntiForgeryToken]
		[HttpPost("Characters/{name}/AddCombo")]
        public IActionResult AddCombo(string CharacterId, ComboView combo)
        {
            if (combo == null)
            {
                return new NotFoundObjectResult(HttpStatusCode.BadRequest);
            }
            var character = _context.Characters
                .Include(c => c.Moves)
                .ThenInclude(i => i.Inputs)
                .Include(c => c.Combos)
                .ThenInclude(i => i.Inputs)
                .SingleOrDefault(c => c.CharacterId == CharacterId);

            var newCombo = new Combo()
            {
                Inputs = combo.Inputs,
                Type = combo.Type,
                Difficulty = combo.Difficulty
            };
            character.Combos.Add(newCombo);
            return RedirectToAction("Detail");
        }


        /*---------Edit Combo--------------*/
        [HttpGet("Characters/{name}/EditCombo")]
        public IActionResult ComboEdit(int ComboId)
        {

			var combo = _context.Combos
                .Include(i => i.Inputs)
                .SingleOrDefault(c => c.ComboId == ComboId);

            var ComboView = new ComboView()
            {
                ComboId = combo.ComboId,
                Difficulty = combo.Difficulty,
                Type = combo.Type,
                Inputs = combo.Inputs
            };

            return View("AddEditCombo", ComboView);
        }
		[ValidateAntiForgeryToken]
		[HttpPost("Characters/{name}/Edit")]
		public IActionResult EditCombo(int ComboId, ComboView InputEdit)
		{
			 var comboToEdit = _context.Combos
				.Include(i => i.Inputs)
				.SingleOrDefault(c => c.ComboId == ComboId);

			if (comboToEdit.Type != null)
			{
				try
				{
					comboToEdit.Difficulty = InputEdit.Difficulty;
					comboToEdit.Type = InputEdit.Type;
					comboToEdit.Inputs = InputEdit.Inputs;
					_context.SaveChanges();

					return RedirectToAction("Detail");
				}
				catch (DbUpdateException ex)
				{
					//Log the error (uncomment ex variable name and write a log.)
					ModelState.AddModelError("", "Unable to save changes. " +
						"Try again, and if the problem persists, " +
						"see your system administrator.");
					return RedirectToAction("Detail", ex);
				}
			}
			return View("Detail");
		}
		/*---------Delete Combo--------------*/
		[HttpPost("Characters/{name}/DeleteCombo")]
        public IActionResult Delete(int ComboId)
        {
            var combo = _context.Combos
                .Include(i => i.Inputs) 
                .SingleOrDefault(c => c.ComboId == ComboId);

            if (combo != null)  
            {
                _context.Combos.Remove(combo);
                _context.SaveChanges();

                return RedirectToAction("Detail");
            }

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
