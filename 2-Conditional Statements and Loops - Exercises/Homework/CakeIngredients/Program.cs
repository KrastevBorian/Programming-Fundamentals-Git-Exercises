using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                string ing = Console.ReadLine();
                if (ing == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {number} ingredients.");
                    break;
                }
                Console.WriteLine($"Adding ingredient {ing}.");
                number += 1;
                
            }
        }
    }
}
