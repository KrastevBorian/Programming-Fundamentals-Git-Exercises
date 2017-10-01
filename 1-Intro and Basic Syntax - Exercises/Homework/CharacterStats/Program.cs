using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int HC = int.Parse(Console.ReadLine());
            int HM = int.Parse(Console.ReadLine());
            int EC = int.Parse(Console.ReadLine());
            int EM = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            Console.WriteLine($"Health: |{new string('|', HC)}{new string('.', HM - HC)}|");
            Console.WriteLine($"Energy: |{new string('|', EC)}{new string('.', EM - EC)}|");
        }
    }
}
