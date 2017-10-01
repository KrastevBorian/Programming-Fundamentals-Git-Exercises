using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int check = 0;

            for (int i = a; i <= b; i++)
            {
                for (int f = a; f <= b; f++)
                {
                    for (int g = a; g <= b; g++)
                    {
                        for (int h = a; h <= b; h++)
                        {
                            for (int j = a; j <= b; j++)
                            {
                                if (f > i && g > f && h > g && j > h)
                                {
                                    Console.WriteLine($"{i} {f} {g} {h} {j}");
                                    check += 1;
                                }
                            }
                        }
                    }
                }
            }

            if (check == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
