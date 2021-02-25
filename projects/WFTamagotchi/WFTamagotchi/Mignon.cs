using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTamagotchi
{
    class Mignon : Tamagotchi
    {
        private int _gentil;

        public int Gentil
        {
            get { return Entre0et100(_gentil); }
            protected set { _gentil = value; }
        }
        
        public Mignon(string nom) : base(nom)
        {
            Gentil = Entre0et100(rnd.Next(40, 60));
        }

        public void Calinou()
        {
            if ((Gentil += 15) < 100)
            {
                Gentil += 15;
            }
            else
            {
                Gentil = 100;
            }
        }

        public override string Vivre()
        {
            Gentil = Entre0et100(Gentil -= 1);
            if (Entre0et100(Gentil) == 0)
            {
                Vivant = false;
                return "Mort";
            }
            if (Gentil < 25)
            {
                return "Calinou";
            }
            string var = base.Vivre();
            return var;
        }

    }
}
