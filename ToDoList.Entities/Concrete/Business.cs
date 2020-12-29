using System;
using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public class Business:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime createdDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
