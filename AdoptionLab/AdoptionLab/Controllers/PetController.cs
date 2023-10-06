using AdoptionLab.Models;
using AdoptionLab.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdoptionLab.Controllers
{
    public class PetController : Controller
    {
        //Dependency injection
        private readonly AppDbContext _appDbContext;

        //we are injecting the DbContect into this controller through the constructor
        public PetController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index(string? searchTerm)
        {

            if(searchTerm != null)
            {
                return View(_appDbContext.Pets.Where(x => x.Species.ToLower().Trim().Contains(searchTerm.ToLower().Trim())).ToList());
            }

            List<Pet> pets = _appDbContext.Pets.ToList();
            return View(pets);
        }

        public IActionResult GetById(int id)
        {
            Pet pet = _appDbContext.Pets.FirstOrDefault(x => x.Id == id);

            if(pet == null)
            {
                return NotFound();
            }
            return View(pet);
        }

        public IActionResult Delete(int id)
        {
            Pet pet = _appDbContext.Pets.FirstOrDefault(x => x.Id == id);
            if (pet != null)
            {
                _appDbContext.Pets.Remove(pet);
                _appDbContext.SaveChanges();
                return RedirectToAction("Confirmation");
            }
            return NotFound();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Adopt()
        {
            Pet pet = new Pet();
            return View(pet);
        }

        [HttpPost]
        public IActionResult ProcessPetForm([FromForm] Pet newPet)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            //db context then table then add and finally what we are adding
            _appDbContext.Pets.Add(newPet);

            //this step is easy to forget
            //this is where it is actually saved to the database. If you dont do this it wont be saved
            _appDbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
