using System;
using System.Collections.Generic;
using System.Text;
using Project4.Entities;

namespace Project4.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
