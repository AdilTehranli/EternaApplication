using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class HomeVm
    {
        public List<Feature> features { get; set; }
        public List<Service> services { get; set; }
        public List<Testimonials> testimonials { get; set;}
        public List<HomeService> homeServices { get; set; }
    }
}
