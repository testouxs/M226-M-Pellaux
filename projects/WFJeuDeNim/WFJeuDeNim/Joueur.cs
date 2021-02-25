using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFJeuDeNim
{
    class Joueur
    {
        private string _nom;
        private bool _estActif;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public bool EstActif
        {
            get { return _estActif; }
            set { _estActif = value; }
        }

        public Joueur()
        {
            Nom = "bibi";
            EstActif = true;
        }

        public Joueur(string pNom, bool pActif)
        {
            Nom = pNom;
            EstActif = pActif;
        }
    }
}
