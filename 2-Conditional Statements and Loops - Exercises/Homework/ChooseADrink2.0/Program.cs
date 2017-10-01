using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string prof = Console.ReadLine();
            decimal quan = decimal.Parse(Console.ReadLine());

            decimal water  = 0.70m;
            decimal coffie = 1.00m;
            decimal beer   = 1.70m;
            decimal tea    = 1.20m;

            if (prof == "Athlete")
            {
                Console.WriteLine($"The {prof} has to pay {quan * water}.");
            }
            else if (prof == "Businessman" || prof == "Businesswoman")
            {
                Console.WriteLine($"The {prof} has to pay {quan * coffie}.");
            }
            else if (prof == "SoftUni Student")
            {
                Console.WriteLine($"The {prof} has to pay {quan * beer}.");
            }
            else
            {
                Console.WriteLine($"The {prof} has to pay {quan * tea}.");
            }
        }
    }
}
