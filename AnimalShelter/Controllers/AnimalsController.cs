using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index(string sortOrder)
    {
      List<Animal> model = new List<Animal>();
      if (sortOrder == "breed")
      {
        model = _db.Animals.OrderBy(x => x.Breed).ToList();
      }
      else if (sortOrder == "type")
      {
        model = _db.Animals.OrderBy(x => x.Type).ToList();
      }
      else
      {
        model = _db.Animals.OrderBy(x => x.AdmittanceDate).ToList();
      }
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }
  }
}