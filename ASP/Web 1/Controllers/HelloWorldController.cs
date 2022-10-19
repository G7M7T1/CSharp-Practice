using Microsoft.AspNetCore.Mvc;
using MVCAPP.Models;

namespace MVCAPP.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // return View("Index");
            dogs.Add(dogViewModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            return View();
        }
    }
}
