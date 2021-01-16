using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class ManagerRepository<TEntity, TDal> : IServiceRepository<TEntity> where TEntity : class, new()
        where TDal : class, IRepository<TEntity>, new()
    {
        TDal _dal = new TDal();
        public void Add(TEntity entity)
        {
            _dal.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dal.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            _dal.Update(entity);
        }
    }
}
