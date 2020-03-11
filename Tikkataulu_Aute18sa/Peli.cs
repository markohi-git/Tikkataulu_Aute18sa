using System;
using System.Collections.Generic;
using System.Text;

namespace Tikkataulu_Aute18sa
{
    class Peli
    {
        Tikkataulu TT = new Tikkataulu();
        List<Pelaaja> Pelaajat = new List<Pelaaja>();

        public void Alustus()
        {
            Console.Write("Montako pelaajaa ");
            int pelaajienLkm = int.Parse(Console.ReadLine());
            for (int i = 0; i < pelaajienLkm; i++)
            {
                Pelaaja p = new Pelaaja(TT);
                p.SetNumero(i + 1);
                Console.WriteLine("Pelaajan nimi");
                p.SetNimi(Console.ReadLine());
                Pelaajat.Add(p);
            }
            Console.WriteLine("pelaajia on " + Pelaajat.Count);
            for (int i = 0; i < Pelaajat.Count; i++)
            {
                Pelaaja p = Pelaajat[i];
                Console.WriteLine("Pelaaja " + p.GetNumero()+" "+p.GetNimi());
            }
            Console.WriteLine("Taulussa tikkoja " + TT.TikkojenMaara());
            for (int i = 0; i < Pelaajat.Count; i++)
            {
                Pelaaja p = Pelaajat[i];
                Console.WriteLine("Pelaaja " + p.GetNumero() + " " + p.TikkojenMaara());
            }
            //ensimmäinen pelaaja
            Pelaaja p1 = Pelaajat[0];
            p1.HaeTikat();

            Console.WriteLine("Taulussa tikkoja " + TT.TikkojenMaara());
            for (int i = 0; i < Pelaajat.Count; i++)
            {
                Pelaaja p = Pelaajat[i];
                Console.WriteLine("Pelaaja " + p.GetNumero() + " " + p.TikkojenMaara());
            }

            Console.ReadKey();
        }
    }
}
