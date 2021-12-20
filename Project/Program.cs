using System;
using System.Threading;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Mococo mococo = new Mococo();
            Menu menu = new Menu();
            Console.WriteLine("\n------------------------------------------------모두 로아 하자------------------------------------------------\n\n");
            mococo.printMococo();
            Thread.Sleep(300);
            Console.Clear();
            menu.First();
            mococo.printMococo();
            Console.WriteLine("\n------------------------------------------------모두 로아 하자------------------------------------------------\n\n");
            Thread.Sleep(300);
        }
    }
}