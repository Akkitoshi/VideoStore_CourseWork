using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_Controller
{
    public class ProductsController
    {
        private VideoDbContext context;

        public ProductsController(VideoDbContext context)
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
                Name = rec.Name,
                CountContracts = rec.CountContracts
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
                        Name = model.Name,
                        CountContracts = null
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
        //удалить продукт
        public void delElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Product element = context.Products.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.Products.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
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
