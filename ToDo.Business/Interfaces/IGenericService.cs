﻿using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Interfaces;

namespace ToDo.Business.Interfaces
{
    public interface IGenericService<T>where T:class,IEntity,new()
    {
    }
}
