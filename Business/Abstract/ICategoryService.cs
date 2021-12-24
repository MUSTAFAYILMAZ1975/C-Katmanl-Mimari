﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
      // IDataResult<List<Category>> GetList();
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
        IResult Update(Category category);
        IResult Add(Category category);
        IResult Delete(Category category);
    }
}


