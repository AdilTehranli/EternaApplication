using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class ServiceController : Controller
    {
        private EternaDbContext _context;
        public ServiceController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServiceVM vm = new ServiceVM()
            {
              Featuress= _context.ServicesFeature.ToList(),
            };
            return View(vm);
        }
    }
}
