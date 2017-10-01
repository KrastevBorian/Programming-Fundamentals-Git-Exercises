using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
            else
            {
                int swich = b;
                b = a;
                a = swich;

                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
