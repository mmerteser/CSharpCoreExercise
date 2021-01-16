using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    { 
        public void Add(TEntity entity)
        {
            Console.WriteLine("Ekleme yapıldı");
        }

        public void Delete(TEntity entity)
        {
            Console.WriteLine("Silme yapıldı");
        }

        public void Update(TEntity entity)
        {
            Console.WriteLine("Güncelleme yapıldı");
        }
    }
}
