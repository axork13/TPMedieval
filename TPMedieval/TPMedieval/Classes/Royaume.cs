using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPMedieval.Classes
{
    public class Royaume
    {
        List<Village> villages;
        private int impot;

        public List<Village> Villages { get => villages; set => villages = value; }
        public int Impot { get => impot; set => impot = value; }

        public Royaume()
        {
            villages = new List<Village>();
            Impot = 0;
        }

        private void Vieillir()
        {
            foreach(Village v in Villages)
            {
                v.Vieillir();
            }
        }

        private void Produire()
        {
            // Todo
        }

        private void Imposer()
        {
            foreach (Village v in Villages)
            {
                impot += v.Imposer();
            }
        }

        private void AjouteHabitant(Roturier r)
        {
            Random rand = new Random();
            int numeroVillage = rand.Next(villages.Count);

            villages.ElementAt(numeroVillage).Roturiers.Add(r);
        }

        private void Depense()
        {
            // Todo
        }
    }
}
