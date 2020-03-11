using System;
using System.Collections.Generic;
using System.Text;

namespace Tikkataulu_Aute18sa
{
    class Pelaaja
    {
        private string Nimi;
        private int Numero;
        List<Tikka> Tikat = new List<Tikka>();
        private Tikkataulu TT;


        public Pelaaja(Tikkataulu tt)
        {
            TT = tt;
        }

        public void SetNimi(string nimi)
        {
            Nimi = nimi;
        }
        public string GetNimi()
        {
            return Nimi;
        }
        public void SetNumero(int numero)
        {
            Numero = numero;
        }
        public int GetNumero()
        {
            return Numero;
        }
        public void HaeTikat()
        {
            for (int i = 0; i < 5; i++) {
                Tikka t = TT.GetTikka();
                Tikat.Add(t);
            }
        }
        public int TikkojenMaara()
        {
            return Tikat.Count;
        }
    }
}
