using System;
using System.Collections.Generic;
using ToDo.Entities.Concrete;
using ToDoList.DataAccess.Interfaces;

namespace ToDoList.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBusinessRepository : IBusinessRepository
    {
        public void Delete(Business business)
        {
            throw new NotImplementedException();
        }

        public List<Business> GetAll()
        {
            throw new NotImplementedException();
        }

        public Business GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save(Business business)
        {
            throw new NotImplementedException();
        }

        public void Update(Business business)
        {
            throw new NotImplementedException();
        }
    }
}
