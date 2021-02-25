using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTamagotchi
{
    class Tamagotchi
    {
        protected Random rnd = new Random();

        private bool _vivant;
        private int _calorie;
        private int _liquide;
        private int _fatigue;
        private int _virus;
        private string _etat;
        private string _nom;

        public bool Vivant
        {
            get { return _vivant; }
            protected set { _vivant = value; }
        }
        public int Calorie
        {
            get { return _calorie; }
            private set { _calorie = value; }
        }
        public int Liquide
        {
            get { return _liquide; }
            private set { _liquide = value; }
        }
        public int Fatigue
        {
            get { return _fatigue; }
            private set { _fatigue = value; }
        }
        public int Virus
        {
            get { return _virus; }
            private set { _virus = value; }
        }
        public string Etat
        {
            get { return _etat; }
            private set { _etat = value; }
        }
        public string Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }

        public Tamagotchi(string nom)
        {
            _vivant = true;
            _calorie = Entre0et100(rnd.Next(40,60));
            _liquide = Entre0et100(rnd.Next(40,60));
            _fatigue = Entre0et100(rnd.Next(40,60));
            _virus   = Entre0et100(rnd.Next(40,60));
            _etat = "Rien à signaler";
            this._nom = nom;
        }

        public bool EstMort()
        {
            return !Vivant;
        }

        public void Manger()
        {
            if ((Calorie += 15) < 100)
            {
                Calorie += 15;
                Virus += rnd.Next(8, 15);
            }
            else
            {
                Calorie = 100;
            }
        }

        public void Boire()
        {
            if ((Liquide += 15) < 100)
            {
                Liquide += 15;
                Fatigue += rnd.Next(8, 15);
            }
            else
            {
                Liquide = 100;
            }
        }

        public void Dormir()
        {
            if ((Fatigue -= 15) > 0)
            {
                Fatigue -= 15;
                Calorie -= rnd.Next(8, 15);
            }
            else
            {
                Fatigue = 0;
            }
        }

        public void Soigner()
        {
            if ((Virus -= 15) > 0)
            {
                Virus -= 15;
                Liquide += rnd.Next(8, 15);
            }
            else
            {
                Virus = 0;
            }
        }

        public virtual string Vivre()
        {
            Calorie = Entre0et100(Calorie -= 1);
            Liquide = Entre0et100(Liquide -= 1);
            Fatigue = Entre0et100(Fatigue += 1);
            Virus = Entre0et100(Virus += 1);

            if (Entre0et100(Calorie) == 0 || Entre0et100(Liquide) == 0 || Entre0et100(Fatigue) == 100 || Entre0et100(Virus) == 100)
            {
                Vivant = false;
                return "Mort";
            }
            
            if (Calorie <= 25)
            {
                return "J'ai faim";
            }
            else if (Liquide <= 25)
            {
                return "J'ai soif";
            }
            else if (Fatigue >= 75)
            {
                return "Je suis fatigué";
            }
            else if (Virus >= 75)
            {
                return "Je suis malade";
            }
            else
            {
                return "Rien à signaler";
            }
        }

        protected int Entre0et100(int valeur)
        {
            if (valeur >= 100)
            {
                valeur = 100;
                return valeur;
            }
            else if (valeur <= 0)
            {
                valeur = 0;
                return valeur;
            }
            else
            {
                return valeur;
            }
        }
    }
}
