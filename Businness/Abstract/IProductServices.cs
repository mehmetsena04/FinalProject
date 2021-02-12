using Entities.concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstract
{
   public interface IProductServices
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int Id);
        List<Product> GetUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();

    }
}
