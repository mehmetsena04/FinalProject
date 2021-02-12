using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfProductDal : EfEntityFrameRepositoryBase<Product, NortWindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NortWindContext nortWindContext = new NortWindContext())
            {
                var result = from p in nortWindContext.Products
                             join c in nortWindContext.Categories
                             on p.CategoryID equals c.CategoryID
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductID,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
    //Code Refactoring
}
