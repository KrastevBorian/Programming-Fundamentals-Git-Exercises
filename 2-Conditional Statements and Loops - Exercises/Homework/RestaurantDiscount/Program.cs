using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal grup = decimal.Parse(Console.ReadLine());
            string pakig = Console.ReadLine();

            decimal hallP = 0m;
            string name = "asd";

            if (grup <= 50)
            {
                hallP = 2500m;
                name = "Small Hall";
            }
            else if (grup > 50 && grup <= 100)
            {
                hallP = 5000;
                name = "Terrace";
            }
            else if (grup > 100 && grup <= 120)
            {
                hallP = 7500;
                name = "Great Hall";
            }
            

            if (pakig == "Normal")
            {
                hallP += 500;
                hallP = hallP - (hallP * 5 / 100);
            }
            else if (pakig == "Gold")
            {
                hallP += 750;
                hallP = hallP - (hallP * 10 / 100);
            }
            else if (pakig == "Platinum")
            {
                hallP += 1000;
                hallP = hallP - (hallP * 15 / 100);
            }

            if (grup >= 1 && grup <=120)
            {
                Console.WriteLine($"We can offer you the {name}");
                Console.WriteLine($"The price per person is {hallP / grup:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
