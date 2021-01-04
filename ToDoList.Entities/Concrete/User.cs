using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public class User:IEntity
    {
       
        public int Id { get; set; }
      
        public string Name { get; set; }
       
        public string Surname { get; set; }
     
        public string Mail { get; set; }
    
        public string Phone { get; set; }
        public List<Work> Businesses { get; set; }
    }
}
