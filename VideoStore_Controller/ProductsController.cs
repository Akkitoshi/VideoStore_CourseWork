using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_Controller
{
    public class ProductsController
    {
        private VideoStoreDbContext context;

        public ProductsController(VideoStoreDbContext context)
        {
            this.context = context;
        }

        // список всех товаров
        public List<ProductViewModel> GetList()
        {
            List<ProductViewModel> result = context.Products.Select(rec => new
           ProductViewModel
            {
                Id = rec.Id,
                Type = rec.Type,
                Price = rec.Price,
                Name = rec.Name
            })
            .ToList();
            return result;
        }
        // добавление нового товара
        public void AddElement(Product model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Product element = context.Products.FirstOrDefault(rec =>
                   rec.Id == model.Id);
                    if (element != null)
                    {
                        throw new Exception("Продукт с данным идентификатором уже существует");
                    }
                    element = new Product
                    {
                        Id = model.Id,
                        Type = model.Type,
                        Price = model.Price,
                        Name = model.Name
                    };
                    context.Products.Add(element);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
