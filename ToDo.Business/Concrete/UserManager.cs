using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interfaces;
using ToDo.Entities.Concrete;
using ToDoList.DataAccess.Concrete.EntityFrameworkCore.Repositories;

namespace ToDo.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly EfUserRepository efUserRepository;
        public UserManager()
        {
            efUserRepository = new EfUserRepository();
        }
        public void Delete(User entity)
        {
            efUserRepository.Delete(entity); 
        }

        public List<User> GetAll()
        {
            return efUserRepository.GetAll();
        }

        public User GetById(int Id)
        {
            return efUserRepository.GetById(Id);
        }

        public void Save(User entity)
        {
            efUserRepository.Save(entity);
        }

        public void Update(User entity)
        {
            efUserRepository.Update(entity);
        }
    }
}
