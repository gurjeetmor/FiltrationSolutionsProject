using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FiltrationSolutionsLtd.Models
{
    public class FiltrationSolutionsLtdDbContext: DbContext
    {
        public DbSet<Product> ProductContext { get; set; }
        public DbSet<HomeCarousel> HomeCarouselContext { get; set; }
        public DbSet<ProductCategory> ProductCategoryContext { get; set; }
        public DbSet<ProductDetails> ProductDetailsContext { get; set; }
        public DbSet<RequestQuotes> RequestQuotesContext { get; set; }
        public DbSet<ContactUs> ContactUsContext { get; set; }
    }
}