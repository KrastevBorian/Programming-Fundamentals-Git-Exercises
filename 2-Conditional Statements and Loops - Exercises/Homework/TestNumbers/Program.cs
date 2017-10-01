using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            int number = 0;
            int combin = 0;

            for (int g = a; g >= 1; g--)
            {
                for (int f = 1; f <= b; f++)
                {
                    number += 3 * (g * f);
                    combin += 1;
                    if (number >= control)
                    {
                        break;
                    }
                }
                if (number >= control)
                {
                    break;
                }
            }

            Console.WriteLine($"{combin} combinations");
            if (number >= control)
            {
                Console.WriteLine($"Sum: {number} >= {control}");
            }
            else
            {
                Console.WriteLine($"Sum: {number}");
            }
        }
    }
}
