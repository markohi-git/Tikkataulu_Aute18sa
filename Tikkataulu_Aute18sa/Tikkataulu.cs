using System;
using System.Collections.Generic;
using System.Text;

namespace Tikkataulu_Aute18sa
{
    class Tikkataulu
    {
        List<Tikka> Tikat = new List<Tikka>();
        public Tikkataulu(){
            for (int i = 0; i<5; i++)
            {
                Tikka t = new Tikka();
                Tikat.Add(t);
            }
        }
        public Tikka GetTikka()
        {
            int tikkojenmaara = Tikat.Count;
            Tikka t = Tikat[tikkojenmaara-1];
            Tikat.Remove(t);
            return t;
        }
        public int TikkojenMaara()
        {
            return Tikat.Count;
        }
        public int Osuma(Tikka tikka)
        {
            Tikat.Add(tikka);
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(11);
        }
    }
}
