using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static int n = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            FactorialAsync(n);
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine(s);
        }
        static async void FactorialAsync(int n)
        { 
            await Task.Run(()=>Factorial(n));
        }
    }
}
