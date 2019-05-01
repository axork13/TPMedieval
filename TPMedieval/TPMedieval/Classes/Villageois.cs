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

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }

        public Villageois(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }
    }
}
