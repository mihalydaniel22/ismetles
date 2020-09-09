using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismetles
{
    class Program
    {

        static int embernyer(int gep, int ember)
        {
            if (ember == gep) //döntetlen
            {
                return 0;
            }
            else if ((ember == 0 && gep == 1)
                    ||
                    (ember == 1 && gep == 2)
                    ||
                    (ember == 2 && gep == 0)
                    ) //gép nyer
            {
                return 1;
            }
            else //játékos nyer
            {
                return 2;
            }
        }

        static void eredmenykiiras(int gep, int ember)
        {
            Console.WriteLine("Gép: {0} --- Játékos: {1}", lehetoseg[gep], lehetoseg[ember]);
            switch (embernyer(gep, ember))
            {
                case 0:
                    Console.WriteLine("Döntetlen");
                    break;
                case 1:
                    Console.WriteLine("Skynet nyert");
                    break;
                case 2:
                    Console.WriteLine("Ember nyert");
                    break;
            }
        }

        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

        static int jatekosvalasztas()
        {
            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");

            Console.Write("Válassz: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        static int gepvalasztas()
        {
            Random vel = new Random();

            return vel.Next(0, 3);
        }

        static void Main(string[] args)
        {


            // Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);

            int jatekosvalasz = jatekosvalasztas();

            //int jatekosvalasztas;

            int gepvalasz = gepvalasztas();

            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

           // eredmenykiiras(gepValasz, jatekosvalasz);

            Console.ReadKey();
        }
    }
}
