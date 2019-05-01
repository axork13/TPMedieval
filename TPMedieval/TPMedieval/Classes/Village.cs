using System;
using System.Collections.Generic;
using System.Text;

namespace TPMedieval.Classes
{
    public class Village
    {
        private List<Roturier> roturiers;
        private List<Paysan> paysans;

        private int cout;
        private int impot;

        public List<Roturier> Roturiers { get => roturiers; set => roturiers = value; }
        public List<Paysan> Paysans { get => paysans; set => paysans = value; }
        public int Impot { get => impot; set => impot = value; }

        public Village(int cout)
        {
            roturiers = new List<Roturier>();
            paysans = new List<Paysan>();
            this.cout = cout;
            this.impot = 0;
        }

        public void Vieillir()
        {
            foreach(Roturier r in roturiers)
            {
                r.Age--;
                if (r.Age >= 45)
                {
                    roturiers.Remove(r);
                }
            }

            foreach (Paysan p in paysans)
            {
                p.Age--;
                if(p.Age >= 30)
                {
                    paysans.Remove(p);
                }
            }
        }

        public void Produire()
        {
            // Todo
        }

        public int Imposer()
        {
            foreach (Roturier r in roturiers)
            {
                impot += r.Gain / 2;
            }
            return impot;
        }
    }
}
