using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiltrationSolutionsLtd.Models;

namespace FiltrationSolutionsLtd.Controllers
{
    public class CaptchaController : Controller
    {
        // GET: Captcha
        public ActionResult Index()
        {
           
            return View();
        }
       
    }
}