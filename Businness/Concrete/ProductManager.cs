using Businness.Abstract;
using DataAccess.Abstract;

using Entities.concrete;
using Entities.DTOs;
using System.Collections.Generic;
namespace Businness.Concrete
{
    public class ProductManager : IProductServices
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int Id)
        {
            return _productDal.GetAll(p => p.CategoryID== Id);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();        }

        public List<Product> GetUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

    }
}
