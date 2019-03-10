using SmartUniServerless.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartUniServerless.Services
{
    public interface IUserService
    {
        User Authenticate(string user, string password);
        IQueryable GetAll();
        IQueryable GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password);
        void Delete(int id);

    }
}
