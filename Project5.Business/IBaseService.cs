using System;
using System.Collections.Generic;
using System.Text;
using Project5.Entities;

namespace Project5.Business
{
    public interface IBaseService<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        T GetById(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
