﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
            int gepValasz = vel.Next(0, 3);
            Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);
            int jatekosvalasz;
            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");
            Console.Write("Válassz: ");
            jatekosvalasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);
            Console.ReadKey();
        }
    }
}
