using System.Collections.Generic;
using ToDo.Entities.Concrete;

namespace ToDoList.DataAccess.Interfaces
{
    public interface IBusinessRepository
    {
        void Save(Business business);
        void Delete(Business business);
        void Update(Business business);
        Business GetById(int Id);
        List<Business> GetAll();
    }
}
