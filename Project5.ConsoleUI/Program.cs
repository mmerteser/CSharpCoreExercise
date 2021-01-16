using System;
using System.Threading.Channels;
using Project5.Business;
using Project5.DataAccess;
using Project5.Entities;

namespace Project5.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProductManager productManager = new ProductManager(new ProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine($"Ürün ID : {product.ProductId} - Kategori ID : {product.CategoryId} - Ürün Adı : {product.ProductName} - Fiyatı : {product.UnitPrice}");
            }

            CategoryManager categoryManager = new CategoryManager(new CategoryDal());

            categoryManager.Update(new Category{CategoryId = 18,CategoryName = "Beyaz Eşyalar",Description = "Çamaşır, bulaşık makinaları ve buzdolapları"});
            categoryManager.Delete(new Category{CategoryId = 18});
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine($"Kategori Adı : {category.CategoryName} - Kategori Açıklama : {category.Description}");
            }

            Console.ReadLine();
        }


    }
}
