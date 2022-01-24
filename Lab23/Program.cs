using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab23
{
    class Program
    {
        static int Method1(int n)
        {
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }
            return a;
        }
        static async void Method1Async(int n)
        {
            int result = await Task.Run(() => Method1(n));
            Console.WriteLine($"Факториал равен {result}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            Method1Async(n);
            Console.WriteLine($"{Method1(n)}");
            Console.ReadKey();
        }
    }
}
