using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Opilane pois = new Opilane("Bunda", "Bundovich", "BUNDpv21");
            pois.OpInfo();



            Inimene naine1 = new Inimene("Marina","Bunda");
            naine1.Tervitame();

            Inimene[] inimesed = new Inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Nimi: ");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.WriteLine("Vanus: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervitame();
            }

            Inimene mees = new Inimene();
            mees.Eesnimi = "Mark";
            Console.WriteLine("Ma olen {0}. Kui vana ma olen?", mees.Eesnimi);
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervitame();
            Inimene naine2 = new Inimene("Alenka", "UltraBunda");
            naine2.Tervitame();

            Console.ReadLine();
        }
    }
}
