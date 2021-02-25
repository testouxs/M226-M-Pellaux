using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFJeuDeNim
{
    class NimModele
    {
        private int _nbAllumettes;
        private Joueur _joueur1;
        private Joueur _joueur2;

        public int NbAllumettes
        {
            get { return _nbAllumettes; }
            set { _nbAllumettes = value; }
        }

        public Joueur Joueur1
        {
            get { return _joueur1; }
            set { _joueur1 = value; }
        }

        public Joueur Joueur2
        {
            get { return _joueur2; }
            set { _joueur2 = value; }
        }

        public NimModele(string pNom1, string pNom2, int pNumJoueurQuiDebute, int pNbAllumettes)
        {
            Joueur1.Nom = pNom1;
            Joueur2.Nom = pNom2;
            NbAllumettes = pNbAllumettes;

            // Maintenir le numéro du joueur à 1 ou 2
            if (pNumJoueurQuiDebute > 2)
            {
                pNumJoueurQuiDebute = 2;
            }

            if (pNumJoueurQuiDebute < 1)
            {
                pNumJoueurQuiDebute = 1;
            }

            if (pNumJoueurQuiDebute == 1)
            {
                Joueur1.EstActif = true;
                Joueur2.EstActif = false;
            }
            else
            {
                Joueur1.EstActif = false;
                Joueur2.EstActif = true;
            }
        }

        public NimModele()
        {
            Joueur1.Nom = "bob";
            Joueur2.Nom = "patrick";
            NbAllumettes = 14;
            Joueur1.EstActif = true;
            Joueur2.EstActif = false;
        }

        public bool PeutJouer(int pNumJoueur)
        {
            // Maintenir le numéro du joueur à 1 ou 2
            if (pNumJoueur > 2)
            {
                pNumJoueur = 2;
            }

            if (pNumJoueur < 1)
            {
                pNumJoueur = 1;
            }

            if (pNumJoueur == 1)
            {
                return Joueur1.EstActif;
            }
            else
            {
                return Joueur2.EstActif;
            }
        }

        public void ChangeJoueurActif()
        {
            Joueur1.EstActif = !Joueur1.EstActif;
            Joueur2.EstActif = !Joueur2.EstActif;
        }

        public void PrendAllumettes(int pNumJoueur, int pNbAllumettes)
        {
            // Minimum allumettes 1 et maximum 3
            if (pNbAllumettes < 1)
            {
                pNbAllumettes = 1;
            }

            if (pNbAllumettes > 3)
            {
                pNbAllumettes = 3;
            }

            NbAllumettes -= pNbAllumettes;
            if (NbAllumettes <= 0)
            {
                DetermineGagnant();
            }
        }

        public int DetermineGagnant()
        {
            if (Joueur1.EstActif)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }
}
