using Businness.Concrete;
using DataAccess.Abstract;

using DataAccess.Concrete.EntitiyFrameWork;
using System;

namespace ConsoleUI
{
    public class Program
    {

        //SOLİD
        //OPEN CLOSED PRİNCİPLE
        static void Main(string[] args)
        {
            /*CategoryTest();*/ ProductTest();
            //DTOs: Data transformation object

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var categories in categoryManager.GetAll())
            {
                Console.WriteLine(categories.CategoryID);
                Console.WriteLine(categories.CategoryName);


            }
        }

        //other version
        //ProductManager productManager = new ProductManager(new İnmemoryProductDal());
        //        foreach (var product in productManager.GetAll())
        //        {
        //            Console.WriteLine(product.ProductName);

        //        }


        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);

            }

            Console.WriteLine("-----------------------------------------------------");

            foreach (var product in productManager.GetAllByCategory(2))
            {
                Console.WriteLine(product.ProductName);

            }

            Console.WriteLine("-----------------------------------------------------");
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }
        }
    }
}

