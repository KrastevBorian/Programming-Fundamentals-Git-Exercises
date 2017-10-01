using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int calori = 0;

            for (int i = 0; i < number; i++)
            {
                string ingrid = Console.ReadLine().ToLower();

                if (ingrid == "cheese")
                {
                    calori += 500;
                }
                else if (ingrid == "tomato sauce")
                {
                    calori += 150;
                }
                else if (ingrid == "salami")
                {
                    calori += 600;
                }
                else if (ingrid == "pepper")
                {
                    calori += 50;
                }
            }

            Console.WriteLine($"Total calories: {calori}");
        }
    }
}
