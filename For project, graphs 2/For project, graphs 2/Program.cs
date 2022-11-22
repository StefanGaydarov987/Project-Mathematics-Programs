using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace For_project__graphs_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());
            Console.Write("    1");
            for (var i = 2; i <= p; i++)
            {
                Console.Write(" {0}",i);
            }
            Console.WriteLine();
            for (var j = 1; j <= p; j++)
            {
                if(j <10)
                {
                    Console.Write("  {0}", j);
                }
                if(j>=10)
                {
                    Console.Write(" {0}", j);
                }
                if(j>=100)
                {
                    Console.Write("{0}", j);
                }
                for (var i = 1; i <= p; i++)
                {
                    var x = a*(i * i * i * i * i) + b*(i * i * i * i) + c*(i * i * i) + d*(i * i) + e*(i);
                    if (x % p == j%p && i< 11)
                    {
                        Console.Write(" 1");
                    }
                    if (x % p == j % p && i >= 11)
                    {
                        Console.Write("  1");
                    }
                    if (x % p == j % p && i >= 101)
                    {
                        Console.Write("   1");
                    }
                    if (x % p != j % p && i < 11)
                    {
                        Console.Write(" 0");
                    }
                    if (x % p != j % p && i >= 11)
                    {
                        Console.Write("  0");
                    }
                    if (x % p != j % p && i >= 101)
                    {
                        Console.Write("   0");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
