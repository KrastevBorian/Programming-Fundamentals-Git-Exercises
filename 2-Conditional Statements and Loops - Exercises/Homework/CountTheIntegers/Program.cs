using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    count += 1;
                }
                catch (Exception)
                {
                    break;
                }
            }

            Console.WriteLine($"{count}");
        }
    }
}
