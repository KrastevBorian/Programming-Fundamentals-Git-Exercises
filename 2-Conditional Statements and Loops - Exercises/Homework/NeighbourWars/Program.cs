using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int dPesho = int.Parse(Console.ReadLine());
            int dGosho = int.Parse(Console.ReadLine());

            int hPesho = 100;
            int hgosho = 100;
            int turn = 0;

            while (true)
            {
                turn += 1;
                if (turn % 2 != 0)
                {
                    hgosho -= dPesho;
                    if (hPesho <= 0 || hgosho <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {hgosho} health.");
                }
                if (hPesho <= 0 || hgosho <= 0)
                {
                    break;
                }
                if (turn %2 == 0)
                {
                    hPesho -= dGosho;
                    if (hPesho <= 0 || hgosho <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {hPesho} health.");
                }
                if (hPesho <= 0 || hgosho <= 0)
                {
                    break;
                }
                if (turn % 3 == 0)
                {
                    hPesho += 10;
                    hgosho += 10;
                }
            }

            if (hPesho > hgosho)
            {
                Console.WriteLine($"Pesho won in {turn}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {turn}th round.");
            }
        }
    }
}
