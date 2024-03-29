﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Core.Utilities.Results;
using Business.Abstract;

namespace ConsoleUI
{
    class Program
    {
          static void Main(string[] args)
        {
            //ProductTest();

            // CategoryTest();

            // DtoTest();



           Success();

        }

        private static void Success()
        {
            
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)

                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DtoTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    

    private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            foreach (var product in productManager.GetAllByCategoryId(2).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
