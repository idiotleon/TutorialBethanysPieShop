using Microsoft.AspNetCore.Mvc;
using TutorialBethanysPieShop.Models;
using TutorialBethanysPieShop.ViewModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialBethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.Pies;

            piesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(piesListViewModel);
        }

        public ViewResult Index()
        {
            ViewBag.Message = "Welcome to Bethany's Pie Shop";
            return View();
        }
    }
}
