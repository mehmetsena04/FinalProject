using DataAccess.Abstract;
using Entities.concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.concrete.İnMemory
{
    public class İnmemoryProductDal : IProductDal
    {
        List<Product> _products;
        public İnmemoryProductDal()
        {
            _products = new List<Product>

    {new Product{ProductID=4,UnitPrice=59, CategoryID=85,UnitsInStock=47,ProductName="Bardak" },
    new Product{ProductID=4,UnitPrice=539, CategoryID=85,UnitsInStock=447,ProductName="Kamerea" },
    new Product{ProductID=5,UnitPrice=549, CategoryID=875,UnitsInStock=47,ProductName="Telefon" },
    new Product{ProductID=6,UnitPrice=569, CategoryID=845,UnitsInStock=747,ProductName="Fotoğrafmakinası" },
    new Product{ProductID=7,UnitPrice=589, CategoryID=815,UnitsInStock=437,ProductName="Mause" }
    };
        }

        public void Add(Product Entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategory(int category)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product producttoUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID); ;
            foreach (var p in _products)
            {
                if (product.ProductID == p.ProductID)
                {
                    producttoUpdate = p;
                }
                //}
                producttoUpdate.CategoryID = product.CategoryID;
                producttoUpdate.ProductID = product.ProductID;
                producttoUpdate.ProductName = product.ProductName;
                producttoUpdate.UnitsInStock = product.UnitsInStock;
                producttoUpdate.UnitPrice = product.UnitPrice;

            }
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

    }

}

