using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project5.Entities;

namespace Project5.DataAccess
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.SingleOrDefault(c => c.CategoryId == id);
            }
        }

        public void Add(Category entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Categories.Remove(context.Categories.SingleOrDefault(c => c.CategoryId == entity.CategoryId));
                context.SaveChanges();
            }
        }

        public void Update(Category entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var categoryToUpdate = context.Categories.SingleOrDefault(c => c.CategoryId == entity.CategoryId);
                categoryToUpdate.CategoryName = entity.CategoryName;
                categoryToUpdate.Description = entity.Description;
                context.SaveChanges();
            }

        }
    }
}
