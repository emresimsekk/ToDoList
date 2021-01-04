using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Entities.Concrete;
using ToDoList.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDoList.DataAccess.Interfaces;

namespace ToDoList.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfWorkRepository :EfRepository<Work>, IWorkDal
    { 
    
    }
}
