using System;
using System.Collections.Generic;
using System.Text;

namespace TriVoiture
{
    class Voiture
    {
        string _marque;
        string _modele;
        int _puissance;
        int _annee;

        public string Marque { get => _marque; private set => _marque = value; }
        public int Puissance { get => _puissance; private set => _puissance = value; }
        public string Modele { get => _modele; private set => _modele = value; }
        public int Annee { get => _annee; set => _annee = value; }

        public Voiture():this("","",0,0)
        {

        }

        public Voiture(string marque, string modele, int puissance, int annee)
        {
            this.Marque = marque;
            this.Modele = modele;
            this.Puissance = puissance;
            this.Annee = annee;
        }

        public override string ToString()
        {
            return "Voiture: marque=" + this.Marque + " modèle=" + this.Modele + " année=" + this.Annee + " puissance=" + this.Puissance;
        }
    }
}
