using System;
using System.Collections.Generic;
using ToDo.Entities.Concrete;
using ToDoList.DataAccess.Interfaces;

namespace ToDoList.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : IUserRepository
    {
        public void Delete(User business)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save(User business)
        {
            throw new NotImplementedException();
        }

        public void Update(User business)
        {
            throw new NotImplementedException();
        }
    }
}
