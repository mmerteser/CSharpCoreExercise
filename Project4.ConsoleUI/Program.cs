using Project4.Business;
using Project4.DataAccess;
using System;
using Project4.Entities;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new TestORMProductDal());

            foreach (var products in productManager.GetAll())
            {
                Console.WriteLine(products.ProductName);
            }

            try
            {
                productManager.Add(new Product
                {
                    ProductId = 10,
                    ProductName = "Laptop",
                    QuantityPerUnit = "4 ayaklı masa",
                    UnitPrice = 1000,
                    UnitsInStock = 10
                });

                foreach (var products in productManager.GetAll())
                {
                    Console.WriteLine(products.ProductName);
                }
            }
            catch (DuplicateProductException e)
            {
                Console.WriteLine(e.Message); 
            }
           

            

            Console.ReadLine();
        }
    }
}
