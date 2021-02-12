using Businness.Abstract;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
         return   _categoryDal.GetAll();
            //iş kodları
        }

        public Category GetById(int categoryId)
        {

            return _categoryDal.Get(c => c.CategoryID == categoryId);
           //iş kodları();
        }
    }
}
