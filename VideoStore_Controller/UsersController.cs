using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_CourseWork
{
    public class UsersController
    {
        private DBCourseWorkContext context;

        public UsersController(DBCourseWorkContext context)
        {
            this.context = context;
        }

        // список всех продавцов
        public List<UserViewModel> GetList()
        {
            List<UserViewModel> result = context.Users.Select(rec => new
           UserViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Role = rec.Role,
                Position = rec.Position
            })
            .ToList();
            return result;
        }


        //удалить продавца
        public void delElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    User element = context.Users.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.Users.Remove(element);
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
