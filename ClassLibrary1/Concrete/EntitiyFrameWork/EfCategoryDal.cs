using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfCategoryDal : EfEntityFrameRepositoryBase<Category, NortWindContext>,ICategoryDal
    {
       
    }
}
