using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interfaces;
using ToDo.Entities.Concrete;
using ToDoList.DataAccess.Concrete.EntityFrameworkCore.Repositories;

namespace ToDo.Business.Concrete
{
    class WorkManager : IWorkService
    {
        private readonly EfWorkRepository efWorkRepository;
        public WorkManager()
        {
            efWorkRepository =new  EfWorkRepository();
        }
        public void Delete(Work entity)
        {
            efWorkRepository.Delete(entity);
        }

        public List<Work> GetAll()
        {
            return efWorkRepository.GetAll();
        }

        public Work GetById(int Id)
        {
            return efWorkRepository.GetById(Id);
        }

        public void Save(Work entity)
        {
            efWorkRepository.Save(entity);
        }

        public void Update(Work entity)
        {
            efWorkRepository.Update(entity);
        }
    }
}
