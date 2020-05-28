using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiltrationSolutionsLtd.Models;
using CaptchaMvc.HtmlHelpers;

namespace FiltrationSolutionsLtd.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult ContactUs(ContactUs contactUs)
        {          
            if (ModelState.IsValid)
            {
                using (FiltrationSolutionsLtdDbContext dbContext = new FiltrationSolutionsLtdDbContext())
                {
                    dbContext.ContactUsContext.Add(contactUs);
                    dbContext.SaveChanges();
                    ModelState.Clear();

                }
                //return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


    }
}