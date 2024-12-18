using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Hi!");
            }
        }
    }
}
