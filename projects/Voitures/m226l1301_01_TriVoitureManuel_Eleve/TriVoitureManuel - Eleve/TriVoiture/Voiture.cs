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

        public string Marque { get => _marque; private set => _marque = value; }
        public int Puissance { get => _puissance; private set => _puissance = value; }
        public string Modele { get => _modele; private set => _modele = value; }

        public Voiture():this("","",0)
        {

        }

        public Voiture(string marque, string modele, int puissance)
        {
            this.Marque = marque;
            this.Modele = modele;
            this.Puissance = puissance;
        }

        public override string ToString()
        {
            return "Voiture: marque=" + this.Marque + " modèle=" + this.Modele + " puissance=" + this.Puissance;
        }
    }
}
