using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstract
{
   public  interface ICategoryServices
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
