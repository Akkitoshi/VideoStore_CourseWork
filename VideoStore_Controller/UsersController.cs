using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_CourseWork
{
    public class UsersController
    {
        private VideoStoreDbContext context;

        public UsersController(VideoStoreDbContext context)
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
    }
}
