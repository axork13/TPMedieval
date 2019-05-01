using System;
using System.Collections.Generic;
using System.Text;

namespace TPMedieval.Classes
{
    public abstract class Villageois
    {
        protected string nom;
        protected string prenom;
        protected int age;

        public Villageois(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
    }
}
