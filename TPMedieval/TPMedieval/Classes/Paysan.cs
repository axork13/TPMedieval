using System;
using System.Collections.Generic;
using System.Text;

namespace TPMedieval.Classes
{
    public class Paysan : Villageois
    {
        private int cout;
        public Paysan(string n, string p, int a, int cout) : base(n, p, a)
        {
            this.cout = cout;
        }
    }
}
