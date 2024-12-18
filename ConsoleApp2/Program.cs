using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input("n=");
            Func(n);
            Console.ReadKey();
        }
        static int Input(string messege)
        {
            Console.Write(messege);
            return int.Parse(Console.ReadLine());
             
        }
        static void Func(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
