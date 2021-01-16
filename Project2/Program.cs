using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer() {CustomerID = 1, CustomerDesc = "Mert" });
            customerManager.Update(new Customer() { CustomerID = 1, CustomerDesc = "Mert" });
            customerManager.Delete(new Customer() { CustomerID = 1, CustomerDesc = "Mert" });
            Console.ReadLine();
        }
    }
}
