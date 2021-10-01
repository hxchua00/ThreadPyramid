using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPyramid
{
    class Program
    {
        class Triangle
        {
            public static void CreatePyramid(int num)
            {
                char a = 'A';
                //Applies to all loops, setting initial to 1 will print exact numbers as stated by num
                for (int i = 1; i <= num; i++)
                {
                    for (int j = num; j >= i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int x = 1; x <= i; x++)
                    {
                        Console.Write(a++);
                    }
                    a--;
                    for (int y = 1; y <i; y++)
                    {
                        Console.Write(--a);
                        
                    }
                    Console.WriteLine();
                    //Revert original char A for next line
                    a = 'A';
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter limit here: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Thread s = new Thread(()=> { Triangle.CreatePyramid(limit); });
            s.Start();

            Console.ReadLine();
        }
    }
}
