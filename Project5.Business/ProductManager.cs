﻿using System;
using System.Collections.Generic;
using System.Text;
using Project5.DataAccess;
using Project5.Entities;

namespace Project5.Business
{
    public class ProductManager : IProductService
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

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
