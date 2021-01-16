using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Divide(20,0));

            Console.ReadLine();
        }

        public class Math
        {
            public int Count(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public decimal Divide(int sayi1, int sayi2)
            {
                try
                {
                    return sayi1 / sayi2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("0'a bölünemez");
                    throw new DivideByZeroException("0'a Bölünemez");
                }
                catch (DllNotFoundException)
                {
                    Console.WriteLine("Dll bulunamadı");
                    throw new DllNotFoundException();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Öngörülemeyen bir hata oluştu");
                    Console.WriteLine(e.InnerException);
                    throw;
                }
                finally
                {
                    Console.WriteLine("İşlemi kontrol edin");
                }
                
            }
        }
    }
}
