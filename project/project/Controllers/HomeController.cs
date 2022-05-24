using Microsoft.AspNetCore.Mvc;
using project.DAL;
using project.Models;
using project.ViewSlider;
using System.Collections.Generic;
using System.Linq;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContex contex;

        public HomeController(AppDbContex contex)
        {
            this.contex = contex;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = contex.Sliders.ToList();
            List<Slider2> sliders2 = contex.sliders2.ToList();
            SliderBV sliderBV = new SliderBV
            {
               slider2s = sliders2,
               sliders = sliders
            };
            return View(sliderBV);
        }
    }
}
