using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EternaApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeVm vm = new HomeVm()
            {
                features = Data.features
            };
            return View(vm);
        }
        
        public IActionResult About()
        {
            return View();
        }

    }
}