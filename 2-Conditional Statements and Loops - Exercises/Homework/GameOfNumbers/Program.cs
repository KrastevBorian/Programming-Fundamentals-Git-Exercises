using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magick = int.Parse(Console.ReadLine());

            int aa = 0;
            int bb = 0;
            int check = 0;
            int com = 0;

            for (int i = a; i <= b; i++)
            {
                for (int f = a; f <= b; f++)
                {
                    com += 1;
                    if (i + f == magick)
                    {
                        aa = i;
                        bb = f;
                        check += 1;
                    }
                }
            }

            if (check != 0)
            {
                Console.WriteLine($"Number found! {aa} + {bb} = {magick}");
            }
            else
            {
                Console.WriteLine($"{com} combinations - neither equals {magick}");
            }
        }
    }
}
