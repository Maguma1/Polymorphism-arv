using System;
using System.Collections.Generic;
using System.Text;

namespace ArvUppgift
{
    class Kläder : Person
    {
        public Kläder()
        {
            Console.WriteLine("Har du kläder på dig?  true/false");
            bool bKläder = bool.Parse(Console.ReadLine());
            if (bKläder == (false))
            {
                Console.WriteLine("Ta på dig kläder!!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nämen va bra, Hur många plagg har du på dig?");
                int Plagg = int.Parse(Console.ReadLine());

                Console.WriteLine("Nämen du har " + Plagg + " plagg på dig");
            }
        }
    }
}
