using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiltrationSolutionsLtd.Models;

namespace FiltrationSolutionsLtd.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            using (FiltrationSolutionsLtdDbContext dbContext = new FiltrationSolutionsLtdDbContext())
            {
                var serviceBarList = dbContext.ProductCategoryContext.ToList();
                return View(serviceBarList);
            }
        }
        //this method pass the products category list to shared partial view to display the 
        //category list in left menu bar directly from the categories stored in database

        public ActionResult ServicesNavBarList()
        {
            using (FiltrationSolutionsLtdDbContext dbContext = new FiltrationSolutionsLtdDbContext())
            {
                var serviceBarList = dbContext.ProductCategoryContext.ToList();
                ViewBag.ServiceCategory = TempData["serviceCategory"];
                return PartialView("~/Views/Shared/ServiceCategoryNavBar.cshtml", serviceBarList);
            }
        }

        //method display the products related to particular category when click on particular category
        public ActionResult BrowseServiceCategory(int categoryId)
        {
            using (FiltrationSolutionsLtdDbContext dbContext = new FiltrationSolutionsLtdDbContext())
            {
                var categoryProducts = dbContext.ProductContext.Where(x => x.CategoryId == categoryId).ToList();
                var categoryName = (from productCategory in dbContext.ProductCategoryContext
                                    where productCategory.Id == categoryId
                                    select productCategory.CategoryName).FirstOrDefault();
                ViewBag.productCategoryName = categoryName;
                TempData["serviceCategory"] = categoryName;
                TempData["categoryId"] = categoryId;
                return View(categoryProducts);
            }
        }

        public ActionResult ServiceDescription(int productId)
        {
            using (FiltrationSolutionsLtdDbContext dbContext = new FiltrationSolutionsLtdDbContext())
            {
                TempData["ProductId"] = productId;
                int serviceCategoryId = Convert.ToInt32(TempData["categoryId"]);
                var serviceCategoryName = (from productCategory in dbContext.ProductCategoryContext
                                           where productCategory.Id == serviceCategoryId
                                           select productCategory.CategoryName).FirstOrDefault();
                ViewBag.categoryId = Convert.ToInt32(TempData["categoryId"]);
                ViewBag.categoryName = serviceCategoryName;
                var productImages = dbContext.ProductDetailsContext.Where(x => x.ProductId == productId).ToList();
                ////this query return the First image Url from productImage table that match
                ////with the productId and this URL used as by Default image URL when user browse
                ////the product description after that image can be change as user mouseover the other product images display on left side
                //var productDefaultImage = (from productDetails in dbContext.ProductDetailsContext
                //                           where productDetails.ProductId == productId
                //                           select productDetails.ImageUrl).FirstOrDefault();
                //ViewBag.defaultImage = productDefaultImage;
                var productName = (from product in dbContext.ProductContext
                                   where product.Id == productId
                                   select product.ProductName).FirstOrDefault();
                ViewBag.selectedProduct = productName;
                return View(productImages);
            }
        }
        public ActionResult Details()
        {
            using (FiltrationSolutionsLtdDbContext dbContext = new FiltrationSolutionsLtdDbContext())
            {
                //ViewBag.categoryName = TempData["productCategory"];
                //ViewBag.categoryId= Convert.ToInt32(TempData["categoryId"]);
                var productId = Convert.ToInt32(TempData["ProductId"]);
                var productDetail = dbContext.ProductContext.Where(x => x.Id == productId).SingleOrDefault();
                return PartialView("DetailsPartial", productDetail);
            }
        }

        [HttpGet]
        public ActionResult CreateQuote()
        {
            return PartialView("RequestQuotePartial");
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult CreateQuote(RequestQuotes requestQuotes)
        {
            if (ModelState.IsValid)
            {
                using (FiltrationSolutionsLtdDbContext dbContext = new FiltrationSolutionsLtdDbContext())
                {
                    dbContext.RequestQuotesContext.Add(requestQuotes);
                    dbContext.SaveChanges();
                    ModelState.Clear();

                }
                //return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
