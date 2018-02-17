using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pie entidade)
        {
            if (!ModelState.IsValid) return View();
            _pieRepository.Add(entidade);
            //Colocar um Toaster aqui para avisar que ok
            return RedirectToAction("index");
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies().OrderBy(x => x.Name);
            var homeViewModel = new HomeViewModel
            {
                Title = "Tortas retilíneas",
                Pies = pies.ToList()
            };
            return View(homeViewModel);
        }
    }
}
