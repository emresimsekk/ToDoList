using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Interfaces;

namespace ToDo.Business.Interfaces
{
    public interface IGenericService<T>where T:class,IEntity,new()
    {
        void Save(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int Id);
        List<T> GetAll();
    }
    
}
