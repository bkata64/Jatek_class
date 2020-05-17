using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    class hos
    {
        public string nev;
        public string[] kasztok = { "Harcos", "Varázsló", "Tolvaj", "Orrgyilkos", "Pap" };
        public int kasztSorszam;
        public int elet;
        public int arany;
        public int dobas;
        Random rnd = new Random();

        public hos()
        {
            Console.Write("\nAdd meg a hős nevét:");
            nev = Console.ReadLine();
            for (int i = 0; i < kasztok.Length; i++)
            {
                Console.WriteLine("\t{0}..............{1}", i+1, kasztok[i]);
            }
            Console.Write("Add meg a kaszt sorszámát:");
            kasztSorszam = int.Parse(Console.ReadLine()) - 1;
            elet = 5;
            arany = 0;
            kiir();
        }

        public void kiir()
        {
            if(dobas == 0)
                Console.WriteLine("\n{0}, a {1} Élete: {2} Aranya:{3}", nev, kasztok[kasztSorszam], elet, arany);
            else
                Console.WriteLine("\n{0}, a {1} Dobása: {2} Élete: {3} Aranya:{4}", nev, kasztok[kasztSorszam], dobas, elet, arany);

        }

        public void Jatek()
        {
            dobas = rnd.Next(1, 7);
            if (dobas > 3)
                arany += dobas;
            else
                elet--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Játék kezdete\n");
            hos user = new hos();
            hos ellenfel = new hos();

            while (user.elet > 0 && ellenfel.elet > 0)
            {
                user.Jatek();
                user.kiir();
                ellenfel.Jatek();
                ellenfel.kiir();
                Console.ReadKey();
                Console.Clear();
            }
            if(user.elet == 0)
                Console.WriteLine("Sajnálom, vesztettél!");
            else
                Console.WriteLine("Gratulálok, győztél!");

            Console.ReadKey();
        }
    }
}
