using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class BeerController : Controller
    {
        private readonly IBeerRepository _beerRepository;

        public BeerController(IBeerRepository beerRepository)
        {
            _beerRepository = beerRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_beerRepository.GetAllBeers().OrderBy(x => x.Nome));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Beer entidade)
        {
            if (!ModelState.IsValid) return View(entidade);
            _beerRepository.Add(entidade);
            //Colocar um Toaster aqui para avisar que ok
            return RedirectToAction("index");
        }
    }
}