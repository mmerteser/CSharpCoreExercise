using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class TestORMProductDal : IProductDal
    {
        List<Product> _products;

        public TestORMProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1,ProductName = "Acer TestORM Bilgisayar",QuantityPerUnit = "32 GB Ram",UnitPrice = 10000,UnitsInStock = 2},
                new Product{ProductId = 2,ProductName = "Aus TestORM Bilgisayar",QuantityPerUnit = "32 GB Ram",UnitPrice = 7000,UnitsInStock = 1},
                new Product{ProductId = 3,ProductName = "HP TestORM Bilgisayar",QuantityPerUnit = "32 GB Ram",UnitPrice = 8000,UnitsInStock = 0},
                new Product{ProductId = 4,ProductName = "Mac TestORM Bilgisayar",QuantityPerUnit = "32 GB Ram",UnitPrice = 13000,UnitsInStock = 3},
                new Product{ProductId = 5,ProductName = "Dell TestORM Bilgisayar",QuantityPerUnit = "32 GB Ram",UnitPrice = 9000,UnitsInStock = 10}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
