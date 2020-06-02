using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        public string DoWork()
        {
            return "Hello WCF Service";
        }

        public List<ProductDT> GetProducts()
        {
            ApplicationDbContext ctx = new ApplicationDbContext();
            return ctx.Products.Select(x => new ProductDT { BrandId = x.BrandId, CategoryId = x.CategoryId, CreateDate = x.CreateDate, DeleteDate = x.DeleteDate, Description = x.Description, Discount = x.Discount, Id = x.Id, ImageUrl = x.ImageUrl, IsDelete = x.IsDelete, Name = x.Name, Price = x.Price, Stock = x.Stock, Tax = x.Tax, UpdateDate = x.UpdateDate }).ToList();
        }
    }
}
