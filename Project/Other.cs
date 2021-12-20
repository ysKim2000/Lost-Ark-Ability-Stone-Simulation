using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project
{
    class Output
    {
        //숫자로 입력할 때 잘못된 값을 입력하지 않도록 만든 오류검사 메서드
        public int NumCheck(int min, int max)
        {
            int output;
            bool check = int.TryParse(Console.ReadLine(), out output);
            if (check)
            {
                if (output < min || output > max)
                {
                    Console.WriteLine("\n\n{0,0}~{1,0} 중에 선택해주세요.", min, max);
                    return 0;
                }
                else
                    return output;
            }
            else
            {
                Console.WriteLine("\n\n{0,0}~{1,0} 중에 선택해주세요.", min, max);
                return 0;
            }
        }
    }
    class Mococo
    {
        public void printMococo()
        {
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□■■■■■□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□■■■■■■■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□□□□■■■■■■■■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□□□■■■■■■■■■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□□■■■■■■■■■■□□□□□□□□□□■■■□□■□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□■■■■■■■■■■■□□□□□□□□□■□□□■□■□□□■□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□■■■■■■■■■■■□□□□□□□□□■□□□■■□□□■□□□□■□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□■■■■■■■■■■■■□□□□□□□□□□■■■□■□■□■□□■■□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□■■■■■■■■■■■□□□□□□□□□□□□□□□■□□□■□■■■□□□□□■");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□■■■■■■■■■■■□□□□□□□□□□□□□■□□□□□□■■□■□□□□■□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■■■■□□□■■■■■■■■■■■□□□□□□□□□□□□□■□□□□□□□□□■□□□■■□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□■■■■■■■■□■■■■■■■■■■□□□□□□□□□□□□□□■■□□□□□■■■□□□□■□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□□□□■□□□□■□□■□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□■■■■■■■■■■■■■■■■■■■■■■□□□□□□□□□□□□□□□□□□□□□■■■□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□■■■■■■■■■■■■■□□□□□□□□□■■■□□□□□□□□□□□□□□□□□□□□□□□□■□□□");
            Thread.Sleep(100);
            Console.WriteLine("□■■■■■■■■■■■■■□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("■■■■■■■■■■■■□□□□□□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("■■■■■■■■■■■□□□□□□□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□■■■■■■■■■■□□□□□□□□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□■■■■■□□□□□□□□□□□□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□□□□□□□□□□□□□■■■□□□□□■□□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□□□□□□□□□□□□■□■■■□□□■■■■□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□□□□□□□□□□□□■□■■■□□□■□□□■□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□□□□□□□□□□□□■■■■■□■■□□□□■■□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□□□□□□□□□□□□□■■■□■□□□■■□□■□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□■□□□□□□■□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□□■■□□□□□□□□□□□□□□□■□□□□□□■□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□■■■■□□□□□□■■■□□□□□■□□□□□□■□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□■□□■■■□□□□■□■□□□□□□■□□□□□□■□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□■■■■■□□□■■□□■□□□□□□■□□□□□■■□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■□□□□□□□■■■■□□□□□■■□□□□□□□■□□□□□■□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□■■□□□□□□□□□□□□□□□□□□□□□□□■□□□□□□■□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□■□□□□□□■□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□■■□□□□□■□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□■□□□□□□□□□□□□□□□□□□□■■□□□□□□□■□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□■■□□□□□□□□□□□□□□□□□■□□□□□□□□■■□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□■□□□□□□□□□□□□□□■■■□□□□□□□□□■□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□■■□□□□□□□□□□■■□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□■■■□□□■■■■□□□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□■■■■□□□□□□□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
            Console.WriteLine("□□□□□□□□□□□□□□□□□□■□□□□□□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□");
            Thread.Sleep(100);
        }
    }
}
