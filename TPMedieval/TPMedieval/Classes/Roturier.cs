using System;
using System.Collections.Generic;
using System.Text;

namespace TPMedieval.Classes
{
    public class Roturier : Villageois
    {
        private int gain; 

        public Roturier(string n, string p, int a, int gain) : base(n, p, a)
        {
            this.Gain = gain;
        }

        public int Gain { get => gain; set => gain = value; }
    }
}
