using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using FiltrationSolutionsLtd.Models;

namespace FiltrationSolutionsLtd.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Carousel()
        {
            using (FiltrationSolutionsLtdDbContext DbContext = new FiltrationSolutionsLtdDbContext())
            {
                var carouselList = DbContext.HomeCarouselContext.ToList();
                return PartialView("~/Views/Shared/CarouselView.cshtml", carouselList);
            }
        }
    }
}