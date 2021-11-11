using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a;
                do
                {
                    Console.WriteLine("Введите число");
                    a = int.Parse(Console.ReadLine());
                    if (a > 5 || a < -5) Console.WriteLine("число НЕ ВХОДИТ в интервал значений a>5 или a<-5");
                    else Console.WriteLine("число ВХОДИТ в интервал значений a>5 или a<-5 ");
                }
                while (a != 10000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
