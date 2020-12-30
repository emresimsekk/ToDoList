using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Concrete;
using ToDoList.DataAccess.Concrete.EntityFrameworkCore.Mapping;

namespace ToDoList.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class ToDoListContext:DbContext
    {
        //public ToDoListContext( )
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-C588JTV\SQLEXPRESS;Database=ToDoList;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new BusinessMap());

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
    }
}
