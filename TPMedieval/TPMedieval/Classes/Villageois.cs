using System;
using System.Collections.Generic;
using System.Text;

namespace TPMedieval.Classes
{
    public abstract class Villageois
    {
        private string nom;
        private string prenom;
        private int age;

        protected Villageois(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
    }
}
