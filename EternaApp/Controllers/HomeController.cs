using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EternaApp.Controllers
{
    public class HomeController : Controller
    {
        private EternaDbContext _context;
        public HomeController(EternaDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            HomeVm vm = new HomeVm()
            {


                features = _context.Features.ToList(),
                services=_context.Services.ToList(),
                homeServices=_context.HomeServices.ToList(),
            };
            return View(vm);
        }
        
        public IActionResult About()
        {
            HomeVm vm = new HomeVm()
            {
                testimonials = _context.Testimonials.ToList(),
            };
            return View(vm);
        }

    }
}