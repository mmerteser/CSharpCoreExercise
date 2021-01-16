using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    interface IServiceRepository<TEntity> where TEntity:class,new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
