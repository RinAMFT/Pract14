using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Func()
        {
            for (int x = 1; x <= 18; x++)
                Console.WriteLine("#");
        }
        //static void Func()
        //{
        //    for (int x = 1; x <= 25; x++)
        //    Console.WriteLine("#");
        //}
        static void Main(string[] args)
        {
            Console.Title = "Работа с консолью";
            Console.WriteLine("WindowWidth : " + Console.WindowWidth);
            Console.WriteLine("WindowHeight: " + Console.WindowHeight);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\a");
            Console.CursorVisible = false;
            Func();
            Console.ReadKey();    
        }
    }
}
