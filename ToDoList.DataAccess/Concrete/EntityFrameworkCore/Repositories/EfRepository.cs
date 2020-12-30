using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.Entities.Interfaces;
using ToDoList.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDoList.DataAccess.Interfaces;

namespace ToDoList.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        public void Delete(T entity)
        { 
            using var context = new ToDoListContext();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {

            using var context = new ToDoListContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            using var context = new ToDoListContext();
            return context.Set<T>().Find(Id);
        }

        public void Save(T entity)
        {

            using var context = new ToDoListContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new ToDoListContext();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
