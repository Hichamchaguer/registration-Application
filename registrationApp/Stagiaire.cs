using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_EX1_PE
{
    class Stagiaire
    {
        private string nom;
        private string prenom;
        private string sexe;
        private string option;
        private int age;

        public string Nom{ get {  return nom; } set{nom = value; }}
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Sexe { get { return sexe; } set { sexe = value; } }
        public string Option { get { return option; } set {option = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Stagiaire() { }
        public Stagiaire(string nom ,string prenom,string sexe,string option,int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.option = option;
            this.age = age;
        }
    }
}
