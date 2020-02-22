using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_CourseWork
{
    public class ServicesController
    {
        private DBCourseWorkContext context;

        public ServicesController(DBCourseWorkContext context)
        {
            this.context = context;
        }

        // список всех услуг
        public List<ServicesViewModel> GetList()
        {
            List<ServicesViewModel> result = context.Services.Select(rec => new
           ServicesViewModel
            {
                Id = rec.Id,
                Name = rec.Name
            })
            .ToList();
            return result;
        }
        // добавление новой услуги
        public void AddElement(Service model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Service element = context.Services.FirstOrDefault(rec =>
                   rec.Id == model.Id);
                    if (element != null)
                    {
                        throw new Exception("Услуга с данным идентификатором уже существует");
                    }
                    element = new Service
                    {
                        Id = model.Id,
                        Name = model.Name
                    };
                    context.Services.Add(element);
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
        //удалить услугу
        public void delElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Service element = context.Services.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.Services.Remove(element);
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
