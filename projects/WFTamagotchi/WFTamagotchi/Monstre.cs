using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTamagotchi
{
    class Monstre : Tamagotchi
    {
        private int _mechant;

        public int Mechant
        {
            get { return Entre0et100(_mechant); }
            protected set { _mechant = value; }
        }

        public Monstre(string nom) : base(nom)
        {
            Mechant = Entre0et100(rnd.Next(40, 60));
        }

        public void Punir()
        {
            if ((Mechant -= 15) > 0)
            {
                Mechant -= 15;
                //Calorie -= rnd.Next(8, 15);
            }
            else
            {
                Mechant = 0;
            }
        }

        public override string Vivre()
        {
            Mechant = Entre0et100(Mechant += 1);
            if (Entre0et100(Mechant) == 100)
            {
                Vivant = false;
                return "Mort";
            }
            if (Mechant > 75)
            {
                return "Punir";
            }
            string var = base.Vivre();
            return var;
        }
    }
}
