using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                gepNyer++;
                return 1;
            }
            else //játékos nyer
            {
                jatekosNyer++;
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

        static int gepNyer = 0;
        static int jatekosNyer = 0;
        static int menet = 0;

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

        static bool AkarJatszani()
        {
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.Write("Tovább [i/n:]?");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("\n¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            StatisztikaFajlbol();

            

            bool tovabb = true;

            while (tovabb)
            {
                menet++;

                int jatekosvalasz = jatekosvalasztas();

                int gepvalasz = gepvalasztas();

                eredmenykiiras(gepvalasz, jatekosvalasz);

                tovabb = AkarJatszani();
            }
            StatisztikaKiiras();
            Console.ReadKey();
        }

        static void StatisztikaFajlbol()
        {
            StreamReader stat = new StreamReader("Statisztika.txt");           
            
            while (!stat.EndOfStream)
            {               
                string[] szovegAdat = stat.ReadLine().Split(';');
                int[] adat = new int[3];
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(szovegAdat[i]);
                }
                Console.WriteLine("{0} {1} {2}",adat[0],adat[1],adat[2]);
            }
            stat.Close();
            Console.WriteLine("-------------------------Statisztika-------------------------");
        }

        static void StatisztikaKiiras()
        {
            Console.WriteLine("Menetek száma: {0}, " +
                "Játékos győzelmek száma: {1}, " +
                "Gép győzelmek száma: {2}",menet, jatekosNyer, gepNyer);    
        }
    }
}
