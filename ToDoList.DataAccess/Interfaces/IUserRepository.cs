using System.Collections.Generic;
using ToDo.Entities.Concrete;

namespace ToDoList.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        void Save(User business);
        void Delete(User business);
        void Update(User business);
        User GetById(int Id);
        List<User> GetAll();
    }
}
