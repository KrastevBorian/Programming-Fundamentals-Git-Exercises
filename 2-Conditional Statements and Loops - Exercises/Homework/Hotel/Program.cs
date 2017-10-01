using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            decimal nights = decimal.Parse(Console.ReadLine());

            decimal studio = 0;
            decimal doble = 0;
            decimal sute = 0;

            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                doble = 65 * nights;
                sute = 75 * nights;
                if (nights > 7 && month == "May")
                {
                    studio = 50 * nights;
                    studio = studio - (studio * 5 / 100);
                }
            }
            else if (month == "June" || month == "September")
            {
                doble = 72 * nights;
                studio = 60 * nights;
                sute = 82 * nights;
                if (nights > 14 && month == "June")
                {
                    doble = 72 * nights;
                    doble = doble - (doble * 10 / 100);
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                sute = 89 * nights;
                studio = 68 * nights;
                doble = 77 * nights;
                if (nights > 14)
                {
                    sute = 89 * nights;
                    sute = sute - (sute * 15 / 100);
                }
            }
            if (month == "September" && nights > 7)
            {
                studio = 60 * (nights - 1);
            }
            if (month == "October" && nights > 7)
            {
                studio = 50 * (nights - 1);
                studio = studio - (studio * 5 / 100);
            }

            Console.WriteLine($"Studio: {studio:f2} lv.");
            Console.WriteLine($"Double: {doble:f2} lv.");
            Console.WriteLine($"Suite: {sute:f2} lv.");
        }
    }
}
